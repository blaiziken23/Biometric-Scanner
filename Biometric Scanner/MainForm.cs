using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPCtlUruNet;
using DPUruNet;

namespace Biometric_Scanner
{
  public partial class MainForm : Form
  {
    readonly UserControlSplashScreen userControlSplashScreen = new UserControlSplashScreen();
    private ReaderCollection _readers;

    public MainForm()
    {
      InitializeComponent();

      this.Controls.Add(userControlSplashScreen);
      userControlSplashScreen.Dock = DockStyle.Fill;
      userControlSplashScreen.BringToFront();
    }

    public Reader CurrentReader
    {
      get { return currentReader; }
      set { currentReader = value; }
    }

    private Reader currentReader;

    public bool Reset
    {
      get { return reset; }
      set { reset = value; }
    }
    private bool reset;

    private ScannerForm _scannerForm;
    private void ScannerBtn_Click(object sender, EventArgs e)
    {
      if (CurrentReader == null)
      {
        MessageBox.Show("Please Choose Fingerprint Scanner", "Select Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (_scannerForm == null && CurrentReader != null)
      {
        _scannerForm = new ScannerForm();
        _scannerForm._sender = this;
        _scannerForm.ShowDialog();
      }

      _scannerForm.Dispose();
      _scannerForm = null;

    }

    private RegisterForm _registerForm;
    private void RegisterBtn_Click(object sender, EventArgs e)
    {
      if (CurrentReader == null)
      {
        MessageBox.Show("Please Choose Fingerprint Scanner", "Select Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (_registerForm == null)
      {
        _registerForm = new RegisterForm();
        _registerForm._sender = this;
      }

      
      _registerForm.ShowDialog();

      /*AddUserControl(_userControlRegister, RegisterBtn);
      UnFocusButton(RegisterBtn);*/
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
      timer1.Start();
      
      //CurrentDateLabel.Text = DateTime.Now.ToString("D");

      /*UserControlScanner userControlScanner = new UserControlScanner();
      AddUserControl(userControlScanner, ScannerBtn);
      UnFocusButton(ScannerBtn);*/

      if (CurrentReader != null)
      {
        CurrentReader.Dispose();
        CurrentReader = null;

      }

      RefreshBtn_Click(sender, e);

      CurrentReader = Properties.Settings.Default.scanner;
      Console.WriteLine(CurrentReader);

      await Task.Delay(3000);
      userControlSplashScreen.Visible = false;

      CurrentReader = _readers[ReadersComboBox.SelectedIndex];
    }

    private ReaderSelectionForm _readerSelectionForm;
    private void ReaderBtn_Click(object sender, EventArgs e)
    {

      if (_readerSelectionForm == null)
      {
        _readerSelectionForm = new ReaderSelectionForm();
        _readerSelectionForm.Sender = this;
      }

      _readerSelectionForm.ShowDialog();

      _readerSelectionForm.Dispose();
      _readerSelectionForm = null;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      //CurrentTimeLabel.Text = DateTime.Now.ToString("T").ToUpper();
      Console.WriteLine();
    }

    /*private void AddUserControl(UserControl userControl, Button button)
    {
      userControl.Width = ContainerPanel.Width;
      userControl.Dock = DockStyle.Fill;
      ContainerPanel.Controls.Clear();
      ContainerPanel.Controls.Add(userControl);
      userControl.BringToFront();

      button.BackColor = Color.FromArgb(234, 234, 234);
      TitleLabel.Text = userControl.GetType().Name.Replace("UserControl", "");
    }*/

    private void UnFocusButton(Button button)
    {
      Button[] buttons = { ScannerBtn, RegisterBtn };

      foreach (Button btn in buttons)
      {
        if (button.Name != btn.Name) btn.BackColor = Color.Transparent;
      }
    }

    public Bitmap CreateBitmap(byte[] bytes, int width, int height)
    {
      byte[] rgbBytes = new byte[bytes.Length * 3];

      for (int i = 0; i <= bytes.Length - 1; i++)
      {
        rgbBytes[(i * 3)] = bytes[i];
        rgbBytes[(i * 3) + 1] = bytes[i];
        rgbBytes[(i * 3) + 2] = bytes[i];
      }
      Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

      BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

      for (int i = 0; i <= bmp.Height - 1; i++)
      {
        IntPtr p = new IntPtr(data.Scan0.ToInt64() + data.Stride * i);
        System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3);
      }

      bmp.UnlockBits(data);

      return bmp;
    }

    public bool StartCaptureAsync(Reader.CaptureCallback OnCaptured)
    {
      // Activate capture handler
      currentReader.On_Captured += new Reader.CaptureCallback(OnCaptured);

      // Call capture
      if (!CaptureFingerAsync())
      {
        return false;
      }

      return true;
    }

    public bool CaptureFingerAsync()
    {
      try
      {
        GetStatus();

        Constants.ResultCode captureResult = currentReader.CaptureAsync(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, currentReader.Capabilities.Resolutions[0]);
        if (captureResult != Constants.ResultCode.DP_SUCCESS)
        {
          reset = true;
          throw new Exception("" + captureResult);
        }

        return true;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error:  " + ex.Message);
        return false;
      }
    }

    public void GetStatus()
    {
      Constants.ResultCode result = currentReader.GetStatus();

      if ((result != Constants.ResultCode.DP_SUCCESS))
      {
        reset = true;
        throw new Exception("" + result);
      }

      if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
      {
        Thread.Sleep(50);
      }
      else if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
      {
        currentReader.Calibrate();
      }
      else if ((currentReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
      {
        throw new Exception("Reader Status - " + currentReader.Status.Status);
      }
    }

    public bool OpenReader()
    {
      reset = false;
      Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;

      // Open reader
      result = currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

      if (result != Constants.ResultCode.DP_SUCCESS)
      {
        MessageBox.Show("Error:  " + result);
        reset = true;
        return false;
      }

      return true;
    }

    public bool CheckCaptureResult(CaptureResult captureResult)
    {
      if (captureResult.Data == null)
      {
        if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
        {
          reset = true;
          throw new Exception(captureResult.ResultCode.ToString());
        }

        // Send message if quality shows fake finger
        if ((captureResult.Quality != Constants.CaptureQuality.DP_QUALITY_CANCELED))
        {
          throw new Exception("Quality - " + captureResult.Quality);
        }
        return false;
      }

      return true;
    }

    public void CancelCaptureAndCloseReader(Reader.CaptureCallback OnCaptured)
    {
      if (currentReader != null)
      {
        currentReader.CancelCapture();

        // Dispose of reader handle and unhook reader events.
        currentReader.Dispose();

        if (reset)
        {
          CurrentReader = null;
        }
      }
    }

    private void panel5_Paint(object sender, PaintEventArgs e)
    {

    }

    private void RefreshBtn_Click(object sender, EventArgs e)
    {
      ReadersComboBox.Text = string.Empty;
      ReadersComboBox.Items.Clear();
      ReadersComboBox.SelectedIndex = -1;

      try
      {
        _readers = ReaderCollection.GetReaders();

        foreach (Reader Reader in _readers)
        {
          ReadersComboBox.Items.Add(Reader.Description.SerialNumber);
        }

        if (ReadersComboBox.Items.Count > 0)
        {
          ReadersComboBox.SelectedIndex = 0;
          SelectBtn.Enabled = true;
        }
        else
        {
          SelectBtn.Enabled = false;
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Cannot access readers", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SelectBtn_Click(object sender, EventArgs e)
    {
      if (CurrentReader != null)
      {
        CurrentReader.Dispose();
        CurrentReader = null;
      }
      CurrentReader = _readers[ReadersComboBox.SelectedIndex];
      MessageBox.Show($"{_readers[ReadersComboBox.SelectedIndex]} is Selected", "Biometric Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
