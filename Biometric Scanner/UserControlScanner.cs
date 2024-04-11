using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPUruNet;
using MySqlConnector;

namespace Biometric_Scanner
{
  public partial class UserControlScanner : UserControl
  {
    public MainForm _sender;
    private static string connstring = DBConnString.connstring();
    int employeeID = 0;

    public UserControlScanner()
    {
      InitializeComponent();
    }

    private void UserControlScanner_Load(object sender, EventArgs e)
    {
      //pbFingerprint.Image = null;
      Console.WriteLine("load");
      if (!_sender.OpenReader())
      {
        Console.WriteLine("!_sender.OpenReader");
        //this();
      }

      if (!_sender.StartCaptureAsync(this.OnCaptured))
      {
        Console.WriteLine("!_sender.StartCaptureAsync(this.OnCaptured)");
        //this.Close();
      }
    }

    public void OnCaptured(CaptureResult captureResult)
    {
      try
      {
        // Check capture quality and throw an error if bad.
        if (!_sender.CheckCaptureResult(captureResult)) return;

        // Create bitmap
        /*foreach (Fid.Fiv fiv in captureResult.Data.Views)
        {
          SendMessage(Action.SendBitmap, _sender.CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height));
        }*/

        DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);

        VerifyFingerprint(resultConversion.Data);

      }
      catch (Exception ex)
      {
        // Send error message, then close form
        //SendMessage(Action.SendMessage, "Error:  " + ex.Message);
      }
    }

    public async Task VerifyFingerprint(Fmd capturedFmd)
    {
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
                //Console.WriteLine(employeeId);
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
                      await EmployeeName(employeeId);
                      Console.WriteLine($"Verification successful for Employee ID: {employeeId}");
                      return; // Exit the method once a match is found
                    }
                  }
                  else
                  {
                    // Error during comparison
                    Console.WriteLine($"Error during comparison for Employee ID: {employeeId}");
                  }
                }
              }
            }

          }
          await conn.CloseAsync();

          // If no match is found after checking all records
          //Report("", "Si bro ay di nakaregistered");
          Console.WriteLine("No matching fingerprint found in the database");
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
                UpdateNameLabel(fullname);
              }
            }
          }
          await conn.CloseAsync();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message + " EmployeeName(int id) dito");
      }
    }

    private void UpdateNameLabel(string name)
    {
      if (NameLabel.InvokeRequired)
      {
        NameLabel.Invoke(new MethodInvoker(delegate { NameLabel.Text = name; }));
      }
      else
      {
        NameLabel.Text = name;
      }
    }
  }
}
