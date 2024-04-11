using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPCtlUruNet;
using DPUruNet;

namespace Biometric_Scanner
{
  public partial class ReaderSelectionForm : Form
  {
    private ReaderCollection _readers;
    private MainForm _sender;
    private Reader _reader;

    public MainForm Sender
    {
      get { return _sender; }
      set { _sender = value; }
    }

    public Reader CurrentReader
    {
      get { return _reader; }
      set { _reader = value; }
    }

    public ReaderSelectionForm()
    {
      InitializeComponent();
    }

    private void SelectBtn_Click(object sender, EventArgs e)
    {
      if (_sender.CurrentReader != null)
      {
        _sender.CurrentReader.Dispose();
        _sender.CurrentReader = null;
      }
      _sender.CurrentReader = _readers[ReadersComboBox.SelectedIndex];
      Properties.Settings.Default.scanner = _readers[ReadersComboBox.SelectedIndex];
      this.Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.scanner = _readers[ReadersComboBox.SelectedIndex];
      //Console.WriteLine(Properties.Settings.Default.scanner);
      this.Close();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
      this.Close();
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
          SaveBtn.Enabled = true;
        }
        else
        {
          SelectBtn.Enabled = false;
          SaveBtn.Enabled = false;
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Cannot access readers", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


    }

    private void ReaderSelectionForm_Load(object sender, EventArgs e)
    {
      RefreshBtn_Click(sender, e);
    }

    private void ReadersComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
