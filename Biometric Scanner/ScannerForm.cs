using DPUruNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Biometric_Scanner
{
  public partial class ScannerForm : Form
  {
    public MainForm _sender;
    private static string connstring = DBConnString.connstring();
    DateTime todaydate = DateTime.Now.Date;
    string currentDay = DateTime.Now.Date.ToString("dddd");
    int resettextboxes = 0;
    string scanLabel = "SCAN FINGERPRINT...";

    string employeeName = "";

    public enum AttendanceStatus
    {
      ABSENT = 0,
      IN = 1,
      OUT = 2,
      NIGHT_IN = 3,
      NIGHT_OUT = 4
    }

    public enum ScheduleStatus
    {
      INACTIVE = 0,
      ACTIVE = 1,
      INC = 2
    }

    Color TimeIn = Color.FromArgb(105, 108, 255);
    Color TimeOut = Color.FromArgb(113, 221, 55);
    Color Error = Color.FromArgb(255, 62, 29);
    Color Warning = Color.FromArgb(255, 171, 0);

    public ScannerForm()
    {
      InitializeComponent();
    }

    private void ScannerForm_Load(object sender, EventArgs e)
    {
      timer1.Start();
      CurrentDateLabel.Text = DateTime.Now.ToString("D");

      if (!_sender.OpenReader())
      {
        Console.WriteLine("!_sender.OpenReader");
        this.Close();
      }

      if (!_sender.StartCaptureAsync(this.OnCaptured))
      {
        this.Close();
      }

      // Get the screen dimensions
      /*int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
      int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

      // Calculate the new dimensions
      int newWidth = (int)(screenWidth * 0.8);
      int newHeight = (int)(screenHeight * 0.8);

      // Set the form dimensions
      this.Width = newWidth;
      this.Height = newHeight;

      // Center the form on the screen
      this.StartPosition = FormStartPosition.CenterScreen;*/
    }

    private async void OnCaptured(CaptureResult result)
    {
      try
      {
        // Check capture quality and throw an error if bad.
        if (!_sender.CheckCaptureResult(result)) return;

        // Create bitmap
        /*foreach (Fid.Fiv fiv in captureResult.Data.Views)
        {
          SendMessage(Action.SendBitmap, _sender.CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height));
        }*/

        DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(result.Data, Constants.Formats.Fmd.ANSI);

        await VerifyFingerprint(resultConversion.Data);
        resettextboxes = 0;
      }
      catch (Exception ex)
      {

        // Send error message, then close form
        //SendMessage(Action.SendMessage, "Error:  " + ex.Message);
      }
    }

    private async Task VerifyFingerprint(Fmd capturedFmd)
    {
      DateTime currentTime = DateTime.Now;

      try
      {
        using (MySqlConnection conn = new MySqlConnection(connstring))
        {
          await conn.OpenAsync();
          string query = "SELECT employee_id, verification FROM biometric_tbl";
          using (MySqlCommand command = new MySqlCommand(query, conn))
          {
            using (MySqlDataReader reader = await command.ExecuteReaderAsync())
            {
              while (await reader.ReadAsync())
              {
                int employeeId = reader.GetInt32("employee_id");
                string storedXmlData = reader.GetString("verification");
                if (storedXmlData != null)
                {
                  Fmd storedFmd = Fmd.DeserializeXml(storedXmlData);

                  // Compare the extracted FMD with the captured FMD
                  CompareResult compareResult = Comparison.Compare(capturedFmd, 0, storedFmd, 0);
                  
                  if (compareResult.ResultCode == Constants.ResultCode.DP_SUCCESS)
                  {
                    // If the score is below a certain threshold, consider it a match
                    double threshold = 0x7fffffff * 1 / 100000; // Adjust threshold as per your requirements
                    if (compareResult.Score < threshold)
                    {
                      // Verification successful
                      await InsertAttendance(employeeId);
                      Console.WriteLine($"Verification successful for Employee ID: {employeeId}");
                      return; // Exit the method once a match is found
                    }
                  }
                  else
                  {
                    // Error during comparison
                    Console.WriteLine($"Error during comparison for Employee ID: {employeeId}");
                    Display("ERROR COMPARISON.", "TRY AGAIN!", currentTime, Error);
                  }
                }
              }
            }

          }
          await conn.CloseAsync();
          // If no match is found after checking all records
          //Report("", "Si bro ay di nakaregistered");
          Console.WriteLine("No matching fingerprint found in the database");
          Display("NO MATCHING FINGERPRINT...", "TRY AGAIN!", currentTime, Error);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: " + ex.Message);
      }
    }

    private async Task EmployeeName(int id)
    {
      try
      {
        using (MySqlConnection conn = new MySqlConnection(connstring))
        {
          await conn.OpenAsync();
          string sql = "SELECT `id_number`, CONCAT(`lastname`, ' ', `firstname`) AS name FROM `employee_tbl` WHERE `id` = @id";
          using (MySqlCommand command = new MySqlCommand(sql, conn))
          {
            command.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = await command.ExecuteReaderAsync())
            {
              while (await reader.ReadAsync())
              {
                string fullname = reader.GetString("name");
              }
            }
          }
          await conn.CloseAsync();

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " EmployeeName(int id)");
      }
    }

    private async Task InsertAttendance(int id)
    {
      bool canInsert = false;
      DateTime currentTime = DateTime.Now;

      try
      {
        using (MySqlConnection conn = new MySqlConnection(connstring))
        {
          await conn.OpenAsync();
          
          string checkAttendance = "SELECT COUNT(*) AS count FROM `attendance_tbl` WHERE `employee_id` = @employee_id AND `date` = @currentdate";
          using (MySqlCommand command = new MySqlCommand(checkAttendance, conn))
          {
            command.Parameters.AddWithValue("@employee_id", id);
            command.Parameters.AddWithValue("@currentdate", todaydate);
            int count = Convert.ToInt32(await command.ExecuteScalarAsync());
            if (count == 0) canInsert = true;
          }

          // Not Existing in DB
          if (canInsert)
          {
            int result = await AttendanceData(id, conn);
            if (result == 0)
            {
              await NoSchedInsertAttendance(id);
            }
            
          }
          else
          {
            await UpdateAttendance(id, conn);
            Console.WriteLine("update na");
          }
          await conn.CloseAsync();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " InsertAttendance");
      }
    }

    

    protected void Report(string name, string status)
    {
      this.Invoke(new Action(delegate ()
      {
        NameLabel.Text = name;
        StatusLabel.Text = status;
      }));
    }

    private void ScannerForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      _sender.CancelCaptureAndCloseReader(this.OnCaptured);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      CurrentTimeLabel.Text = DateTime.Now.ToString("T").ToUpper();

      if (NameLabel.Text != scanLabel && NameLabel.Text != "")
      {
        resettextboxes++;
      }

      if (resettextboxes >= 15 && NameLabel.Text != "")
      {
        resettextboxes = 0;
        NameLabel.Text = scanLabel;
        StatusLabel.Text = "";
        TimeLabel.Text = "";
        StatusLabel.BackColor = Color.Transparent;
      }

    }


    private async Task NoSchedInsertAttendance(int id)
    {
      try
      {
        using (MySqlConnection conn = new MySqlConnection(connstring))
        {
          // Insert Schedule
          await conn.OpenAsync();
          string query = "INSERT INTO `schedule_tbl`(`day`, `status`, `employee_id`) " +
                          "VALUES (@day, @status, @employee_id)";
          using (MySqlCommand command = new MySqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@day", currentDay.ToUpper());
            command.Parameters.AddWithValue("@status", ScheduleStatus.INC);
            command.Parameters.AddWithValue("@employee_id", id);
            int result = await command.ExecuteNonQueryAsync();

            if (result != 0) await AttendanceData(id, conn);
          }
          await conn.CloseAsync();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " NoSchedInsertAttendance()");
      }
    }

    private async Task<int> AttendanceData(int id, MySqlConnection conn)
    {
      TimeSpan timestart = TimeSpan.Zero;
      TimeSpan timeend = TimeSpan.Zero;
      DateTime currentTime = DateTime.Now;
      //DateTime created = DateTime.Now;

      try
      {
        string scheduleQuery = "SELECT schedule_tbl.id, `start`, `end`, `day`, `total_hour`, schedule_tbl.status, `employee_id`, CONCAT(employee_tbl.lastname, ' ', employee_tbl.firstname) AS name FROM `schedule_tbl` INNER JOIN employee_tbl ON employee_tbl.id = schedule_tbl.employee_id WHERE `employee_id` = @employee_id";
        using (MySqlCommand command = new MySqlCommand(scheduleQuery, conn))
        {
          command.Parameters.AddWithValue("@employee_id", id);
          using (MySqlDataReader reader = await command.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              timestart = reader.GetTimeSpan("start");
              timeend = reader.GetTimeSpan("end");
              employeeName = reader.GetString("name");
            }
            reader.Close();
          }
        }

        TimeSpan lateduration = currentTime.TimeOfDay - timestart - TimeSpan.FromMinutes(5);

        if (currentTime.Hour >= 20) // 8 PM
        {
          // Night IN 
          string query = "INSERT INTO `attendance_tbl`(`date`, `night_time_in`, `status`, `employee_id`, `schedule_id`) SELECT @date, @night_time_in, @status, @employee_id, schedule_tbl.id FROM `schedule_tbl` WHERE schedule_tbl.day = @currentDay AND schedule_tbl.employee_id = @schedule_tbl_employee_id";
          using (MySqlCommand command = new MySqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@date", todaydate);
            command.Parameters.AddWithValue("@night_time_in", currentTime.TimeOfDay);
            command.Parameters.AddWithValue("@status", AttendanceStatus.NIGHT_IN);
            command.Parameters.AddWithValue("@employee_id", id);
            command.Parameters.AddWithValue("@schedule_tbl_employee_id", id);
            command.Parameters.AddWithValue("@currentDay", currentDay);
            int result = await command.ExecuteNonQueryAsync();
            Display(employeeName, "TIME IN", currentTime, TimeIn);
            Console.WriteLine("GABI");
            return result;
          }
        }
        else
        {
          // Regular Day
          //TimeSpan timeSpan = created.TimeOfDay.Add(TimeSpan.FromMinutes(1));

          string query = "INSERT INTO `attendance_tbl`(`date`, `time_in`, `status`, `employee_id`, `late`, `schedule_id`) SELECT @date, @time_in, @status, @employee_id, @late, schedule_tbl.id FROM `schedule_tbl` WHERE schedule_tbl.day = @currentDay AND schedule_tbl.employee_id = @schedule_tbl_employee_id";
          using (MySqlCommand command = new MySqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@date", todaydate);
            command.Parameters.AddWithValue("@time_in", currentTime.TimeOfDay);
            command.Parameters.AddWithValue("@status", AttendanceStatus.IN);
            command.Parameters.AddWithValue("@employee_id", id);
            command.Parameters.AddWithValue("@schedule_tbl_employee_id", id);
            command.Parameters.AddWithValue("@currentDay", currentDay);
            command.Parameters.AddWithValue("@late", (timestart < currentTime.TimeOfDay && timestart != TimeSpan.Zero) ? lateduration : TimeSpan.Zero);
            int result = await command.ExecuteNonQueryAsync();
            Display(employeeName, "TIME IN", currentTime, TimeIn);
            return result;
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " AttendanceData()");
      }

      return 0;
    }

    private async Task UpdateAttendance(int id, MySqlConnection conn)
    {
      int status = 0;
      int primaryId = 0;
      TimeSpan total = TimeSpan.Zero;
      DateTime currentTime = DateTime.Now;
      DateTime created = DateTime.Now;

      try
      {
        //string query = "SELECT `id`, `status` FROM `attendance_tbl` WHERE `employee_id` = @employee_id";
        string query = "SELECT attendance_tbl.id, attendance_tbl.status, CONCAT(employee_tbl.lastname, ' ', employee_tbl.firstname) AS name, attendance_tbl.created FROM `attendance_tbl` INNER JOIN employee_tbl ON employee_tbl.id = attendance_tbl.employee_id WHERE `employee_id` = @employee_id ORDER BY attendance_tbl.id DESC LIMIT 1";
        using (MySqlCommand command = new MySqlCommand(query, conn))
        {
          command.Parameters.AddWithValue("@employee_id", id);
          using (MySqlDataReader reader = await command.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              status = reader.GetInt16("status");
              primaryId = reader.GetInt16("id");
              employeeName = reader.GetString("name");
              created = reader.GetDateTime("created");
            }
            reader.Close();
          }
        }

        Console.WriteLine(primaryId);
        if (status == 1)
        {
          TimeSpan timeSpan = created.TimeOfDay.Add(TimeSpan.FromMinutes(5));

          if (currentTime.TimeOfDay < timeSpan)
          {
            Display(employeeName, "TOO EARLY TO LOG OUT", currentTime, Warning);
          }
          else
          {
            // Update Time Out
            string timeOut = "UPDATE `attendance_tbl` SET `time_out` = @timeout, `hour` = TIMEDIFF(`time_out`, `time_in`), `status` = @status WHERE `id` = @id";
            using (MySqlCommand command = new MySqlCommand(timeOut, conn))
            {
              command.Parameters.AddWithValue("@timeout", currentTime.TimeOfDay);
              command.Parameters.AddWithValue("@id", primaryId);
              command.Parameters.AddWithValue("@status", AttendanceStatus.OUT);

              int result = await command.ExecuteNonQueryAsync();
              if (result > 0)
              {
                Display(employeeName, "TIME OUT", currentTime, TimeOut);
                Console.WriteLine("Time OUT");
              }
            }
          }
          
        }
        else if (status == 2)
        {
          // Insert New Attendance
          await AttendanceData(id, conn);
        }
        else if (status == 2 && currentTime.Hour >= 20)
        {
          // Update NIGHT_IN
          string timeOut = "UPDATE `attendance_tbl` SET `night_time_in` = @night_time_in, `hour` = TIMEDIFF(`time_out`, `time_in`), `status` = @status WHERE `id` = @id";
          using (MySqlCommand command = new MySqlCommand(timeOut, conn))
          {
            command.Parameters.AddWithValue("@night_time_in", currentTime.TimeOfDay);
            command.Parameters.AddWithValue("@id", primaryId);
            command.Parameters.AddWithValue("@status", AttendanceStatus.NIGHT_IN);

            int result = await command.ExecuteNonQueryAsync();
            if (result > 0)
            {
              Display(employeeName, "TIME IN", currentTime, TimeIn);
              Console.WriteLine("Time In Gabi");
            }
          }
        }
        else if (status == 3)
        {
          // Update NIGHT_OUT
          string timeOut = "UPDATE `attendance_tbl` SET `night_time_out` = @night_time_out, `hour` = ADDTIME(TIMEDIFF(`time_out`, `time_in`), TIMEDIFF(`night_time_out`, `night_time_in`)), `status` = @status WHERE `id` = @id";
          using (MySqlCommand command = new MySqlCommand(timeOut, conn))
          {
            command.Parameters.AddWithValue("@night_time_out", currentTime.TimeOfDay);
            command.Parameters.AddWithValue("@id", primaryId);
            command.Parameters.AddWithValue("@status", AttendanceStatus.NIGHT_OUT);

            int result = await command.ExecuteNonQueryAsync();
            if (result > 0)
            {
              Display(employeeName, "TIME OUT", currentTime, TimeOut);
              Console.WriteLine("Time OUT Gabi");
            }
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " UpdateAttendance()");
      }
    }

    private void Display(string employeename, string status, DateTime time, Color timeColor)
    {
      this.Invoke(new Action(delegate ()
      {
        NameLabel.Text = employeename;
        StatusLabel.Text = status;
        StatusLabel.BackColor = timeColor;
        TimeLabel.Text = time.ToString("f").ToUpper();
      }));
    }
  }
}
