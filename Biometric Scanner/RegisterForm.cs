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
using DPCtlUruNet;
using MySqlConnector;

namespace Biometric_Scanner
{
  public partial class RegisterForm : Form
  {
    private EnrollmentControl _enrollmentControl;
    public MainForm _sender;
    private static string connstring = DBConnString.connstring();

    public RegisterForm()
    {
      InitializeComponent();
    }

    private void DisplayEnrolmentControl()
    {
      if (_enrollmentControl != null)
      {
        _enrollmentControl.Reader = _sender.CurrentReader;
      }
      else
      {
        _enrollmentControl = new EnrollmentControl(_sender.CurrentReader, Constants.CapturePriority.DP_PRIORITY_COOPERATIVE)
        {
          BackColor = SystemColors.Window,
          Location = new Point(10, 10),
          Name = "ctlEnrollmentControl",
          Size = new Size(482, 346),
          TabIndex = 0,
          Dock = DockStyle.Top
        };
        _enrollmentControl.OnCancel += new EnrollmentControl.CancelEnrollment(this.Enrollment_OnCancel);
        _enrollmentControl.OnCaptured += new EnrollmentControl.FingerprintCaptured(this.Enrollment_OnCaptured);
        _enrollmentControl.OnDelete += new EnrollmentControl.DeleteEnrollment(this.Enrollment_OnDelete);
        _enrollmentControl.OnEnroll += new EnrollmentControl.FinishEnrollment(this.Enrollment_OnEnroll);
        _enrollmentControl.OnStartEnroll += new EnrollmentControl.StartEnrollment(this.Enrollment_OnStartEnroll);
        _enrollmentControl.BringToFront();
      }
      panel2.Controls.Add(_enrollmentControl);
    }

    private void Enrollment_OnStartEnroll(EnrollmentControl enrollmentControl, Constants.ResultCode result, int fingerPosition)
    {
      if (string.IsNullOrWhiteSpace(EmployeeIDTextBox.Text))
      {
        MessageBox.Show("Please Choose Employee to Register fingerprints", "Select Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (enrollmentControl.Reader != null)
      {
        SendMessage("OnStartEnroll:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
      }
      else
      {
        SendMessage("OnStartEnroll:  No Reader Connected, finger " + fingerPosition);
      }

      CancelBtn.Enabled = true;
    }

    private async void Enrollment_OnEnroll(EnrollmentControl enrollmentControl, DataResult<Fmd> enrollmentResult, int fingerPosition)
    {
      if (enrollmentControl.Reader != null)
      {
        SendMessage("OnEnroll:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
        SendMessage("Enrolled Finger Mask: " + _enrollmentControl.EnrolledFingerMask);
        SendMessage("Disabled Finger Mask: " + _enrollmentControl.DisabledFingerMask);
        Console.WriteLine(enrollmentControl.Reader.Description.Name);
      }
      else
      {
        SendMessage("OnEnroll:  No Reader Connected, finger " + fingerPosition);
      }

      if (enrollmentResult != null && enrollmentResult.Data != null)
      {
        try
        {
          if (string.IsNullOrWhiteSpace(EmployeeIDTextBox.Text))
          {
            MessageBox.Show("Please Choose Employee to Register fingerprints", "Select Employee", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            return;
          }
          using (MySqlConnection conn = new MySqlConnection(connstring))
          {
            await conn.OpenAsync();
            string query = "INSERT INTO `biometric_tbl`(`employee_id`, `verification`, `index_finger`) VALUES (@employee_id, @verification, @index_finger)";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
              command.Parameters.AddWithValue("@employee_id", Convert.ToInt32(EmployeeIDTextBox.Text));
              command.Parameters.AddWithValue("@verification", Fmd.SerializeXml(enrollmentResult.Data));
              command.Parameters.AddWithValue("@index_finger", fingerPosition);

              int res = await command.ExecuteNonQueryAsync();
              if (res > 0)
              {
                MessageBox.Show("Fingerprint Saved", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                MessageBox.Show("Fingerprint Error", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            }
            conn.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      }
      CancelBtn.Enabled = false;
    }

    private void Enrollment_OnDelete(EnrollmentControl enrollmentControl, Constants.ResultCode result, int fingerPosition)
    {
      if (enrollmentControl.Reader != null)
      {
        SendMessage("OnDelete:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
        SendMessage("Enrolled Finger Mask: " + _enrollmentControl.EnrolledFingerMask);
        SendMessage("Disabled Finger Mask: " + _enrollmentControl.DisabledFingerMask);
      }
      else
      {
        SendMessage("OnDelete:  No Reader Connected, finger " + fingerPosition);
      }
    }

    private void Enrollment_OnCaptured(EnrollmentControl enrollmentControl, CaptureResult captureResult, int fingerPosition)
    {
      //Console.WriteLine(fingerPosition);
      if (enrollmentControl.Reader != null)
      {
        SendMessage("OnCaptured:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition + ", quality " + captureResult.Quality.ToString());
        Console.WriteLine(enrollmentControl.Reader.Description.Name);
      }
      else
      {
        SendMessage("OnCaptured:  No Reader Connected, finger " + fingerPosition);
      }

      if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
      {
        if (_sender.CurrentReader != null)
        {
          _sender.CurrentReader.Dispose();
          _sender.CurrentReader = null;
        }

        // Disconnect reader from enrollment control
        _enrollmentControl.Reader = null;

        MessageBox.Show("Error:  " + captureResult.ResultCode);
        CancelBtn.Enabled = false;
      }
      else
      {
        if (captureResult.Data != null)
        {
          foreach (Fid.Fiv fiv in captureResult.Data.Views)
          {
            CaptureFingerPrintPictureBox.Image = _sender.CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height);
          }
        }
      }


    }

    private void Enrollment_OnCancel(EnrollmentControl enrollmentControl, Constants.ResultCode result, int fingerPosition)
    { 
      if (enrollmentControl.Reader != null)
      {
        SendMessage("OnCancel:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
      }
      else
      {
        SendMessage("OnCancel:  No Reader Connected, finger " + fingerPosition);
      }

      CancelBtn.Enabled = false;
    }

    private void SendMessage(string message)
    {
      MessageTextBox.Text += message + "\r\n\r\n";
      MessageTextBox.SelectionStart = MessageTextBox.TextLength;
      MessageTextBox.ScrollToCaret();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      
      result = MessageBox.Show("Are you sure you want to cancel this enrollment?", "Are You Sure?", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

      if (result == DialogResult.Yes)
      {
        _enrollmentControl.Cancel();
      }
    }

    private void EmployeeListComboBox_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(EmployeeListComboBox.Text) || EmployeeListComboBox.Text.Length < 0) EmployeeIDTextBox.Text = null;
    }

    private async void SearchBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmployeeListComboBox.Text))
      {
        EmployeeIDTextBox.Text = null;
        return;
      }

      SearchingLabel.Visible = true;
      await SearchEmployee();
      SearchingLabel.Visible = false;
    }

    private async void EmployeeListComboBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (string.IsNullOrWhiteSpace(EmployeeListComboBox.Text))
        {
          EmployeeIDTextBox.Text = null;
          return;
        }

        SearchingLabel.Visible = true;
        await SearchEmployee();
        SearchingLabel.Visible = false;
      }
    }


    private async Task SearchEmployee()
    {
      string searchText = EmployeeListComboBox.Text;

      using (MySqlConnection conn = new MySqlConnection(connstring))
      {
        await conn.OpenAsync();
        EmployeeListComboBox.Items.Clear();
        string query = "SELECT `id`, `id_number`, `firstname`, `lastname` FROM `employee_tbl` WHERE (`id_number` LIKE @searchText OR `firstname` LIKE @searchText OR `middlename` LIKE @searchText OR `lastname` LIKE @searchText) AND `status` = 1";
        using (MySqlCommand command = new MySqlCommand(query, conn))
        {
          command.Parameters.Clear();
          command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
          using (MySqlDataReader reader = await command.ExecuteReaderAsync())
          {
            while (await reader.ReadAsync())
            {
              int id = reader.GetInt16("id");
              string id_number = reader.GetString("id_number");
              string firstname = reader.GetString("firstname");
              string lastname = reader.GetString("lastname");

              Employee employee = new Employee(id, id_number, firstname, lastname);

              EmployeeListComboBox.Items.Add(employee);
              EmployeeListComboBox.DroppedDown = true;
            }
          }
        }
        await conn.CloseAsync();
      }
    }

    private void EmployeeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (EmployeeListComboBox.SelectedItem != null)
      {
        Employee selectedEmployee = (Employee)EmployeeListComboBox.SelectedItem;
        Console.WriteLine(selectedEmployee.Id);
        EmployeeIDTextBox.Text = selectedEmployee.Id.ToString();
      }
    }

    private void EmployeeIDTextBox_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(EmployeeIDTextBox.Text))
      {
        _enrollmentControl.Visible = false;
      }
      else
      {
        DisplayEnrolmentControl();
        _enrollmentControl.Visible = true;
        //await RegisteredFingerPrint(Convert.ToInt32(EmployeeIDTextBox.Text));
      }
    }

    private async Task RegisteredFingerPrint(int id)
    {
      try
      {
        using (MySqlConnection conn = new MySqlConnection(connstring))
        {
          await conn.OpenAsync();
          string query = "SELECT `index_finger` FROM `biometric_tbl` WHERE `employee_id` = @employee_id ORDER BY `index_finger`";
          using (MySqlCommand command = new MySqlCommand(query, conn))
          {
            command.Parameters.AddWithValue("@employee_id", id);
            using (MySqlDataReader reader = await command.ExecuteReaderAsync())
            {
              while (await reader.ReadAsync())
              {
                label2.Text = $"Registered Fingerprints {reader.GetInt16("index_finger")}";
              }
            }
          }
          await conn.CloseAsync();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "RegisteredFingerPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (_enrollmentControl != null) _enrollmentControl.Cancel();
    }
  }
}
