
namespace Biometric_Scanner
{
  partial class RegisterForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.CaptureFingerPrintPictureBox = new System.Windows.Forms.PictureBox();
      this.CloseBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.panel6 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
      this.SearchingLabel = new System.Windows.Forms.Label();
      this.SearchBtn = new System.Windows.Forms.Button();
      this.EmployeeListComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel7 = new System.Windows.Forms.Panel();
      this.MessageTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.CaptureFingerPrintPictureBox)).BeginInit();
      this.panel6.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel7.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // CaptureFingerPrintPictureBox
      // 
      this.CaptureFingerPrintPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.CaptureFingerPrintPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CaptureFingerPrintPictureBox.Image = global::Biometric_Scanner.Properties.Resources.icons8_fingerprint_120;
      this.CaptureFingerPrintPictureBox.Location = new System.Drawing.Point(5, 5);
      this.CaptureFingerPrintPictureBox.Margin = new System.Windows.Forms.Padding(0);
      this.CaptureFingerPrintPictureBox.Name = "CaptureFingerPrintPictureBox";
      this.CaptureFingerPrintPictureBox.Size = new System.Drawing.Size(328, 190);
      this.CaptureFingerPrintPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.CaptureFingerPrintPictureBox.TabIndex = 0;
      this.CaptureFingerPrintPictureBox.TabStop = false;
      this.CaptureFingerPrintPictureBox.WaitOnLoad = true;
      // 
      // CloseBtn
      // 
      this.CloseBtn.AutoSize = true;
      this.CloseBtn.BackColor = System.Drawing.Color.White;
      this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_close_24__1_;
      this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CloseBtn.Location = new System.Drawing.Point(5, 43);
      this.CloseBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.CloseBtn.Size = new System.Drawing.Size(173, 38);
      this.CloseBtn.TabIndex = 3;
      this.CloseBtn.TabStop = false;
      this.CloseBtn.Text = "  Close";
      this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CloseBtn.UseVisualStyleBackColor = false;
      this.CloseBtn.Visible = false;
      // 
      // CancelBtn
      // 
      this.CancelBtn.AutoSize = true;
      this.CancelBtn.BackColor = System.Drawing.Color.White;
      this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CancelBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_cancel_24;
      this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CancelBtn.Location = new System.Drawing.Point(5, 5);
      this.CancelBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.CancelBtn.Size = new System.Drawing.Size(173, 38);
      this.CancelBtn.TabIndex = 2;
      this.CancelBtn.TabStop = false;
      this.CancelBtn.Text = "  Cancel";
      this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.CancelBtn.UseVisualStyleBackColor = false;
      this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.CloseBtn);
      this.panel6.Controls.Add(this.CancelBtn);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel6.Location = new System.Drawing.Point(338, 0);
      this.panel6.Margin = new System.Windows.Forms.Padding(0);
      this.panel6.Name = "panel6";
      this.panel6.Padding = new System.Windows.Forms.Padding(5);
      this.panel6.Size = new System.Drawing.Size(183, 200);
      this.panel6.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
      this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 373);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 200);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.CaptureFingerPrintPictureBox);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(0, 0);
      this.panel5.Margin = new System.Windows.Forms.Padding(0);
      this.panel5.Name = "panel5";
      this.panel5.Padding = new System.Windows.Forms.Padding(5);
      this.panel5.Size = new System.Drawing.Size(338, 200);
      this.panel5.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Controls.Add(this.tableLayoutPanel2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(10);
      this.panel2.Size = new System.Drawing.Size(541, 583);
      this.panel2.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 255);
      this.label2.Margin = new System.Windows.Forms.Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 28);
      this.label2.TabIndex = 6;
      this.label2.Text = "label2";
      this.label2.Visible = false;
      // 
      // EmployeeIDTextBox
      // 
      this.EmployeeIDTextBox.Location = new System.Drawing.Point(205, 2);
      this.EmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(0);
      this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
      this.EmployeeIDTextBox.ReadOnly = true;
      this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 34);
      this.EmployeeIDTextBox.TabIndex = 5;
      this.EmployeeIDTextBox.Visible = false;
      this.EmployeeIDTextBox.TextChanged += new System.EventHandler(this.EmployeeIDTextBox_TextChanged);
      // 
      // SearchingLabel
      // 
      this.SearchingLabel.AutoSize = true;
      this.SearchingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchingLabel.Location = new System.Drawing.Point(5, 72);
      this.SearchingLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.SearchingLabel.Name = "SearchingLabel";
      this.SearchingLabel.Size = new System.Drawing.Size(97, 23);
      this.SearchingLabel.TabIndex = 4;
      this.SearchingLabel.Text = "Searching...";
      this.SearchingLabel.Visible = false;
      // 
      // SearchBtn
      // 
      this.SearchBtn.AutoSize = true;
      this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_search_client_24__1_;
      this.SearchBtn.Location = new System.Drawing.Point(305, 33);
      this.SearchBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(65, 35);
      this.SearchBtn.TabIndex = 3;
      this.SearchBtn.TabStop = false;
      this.SearchBtn.UseVisualStyleBackColor = false;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
      // 
      // EmployeeListComboBox
      // 
      this.EmployeeListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.EmployeeListComboBox.BackColor = System.Drawing.Color.White;
      this.EmployeeListComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
      this.EmployeeListComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.EmployeeListComboBox.FormattingEnabled = true;
      this.EmployeeListComboBox.Location = new System.Drawing.Point(5, 36);
      this.EmployeeListComboBox.Margin = new System.Windows.Forms.Padding(0);
      this.EmployeeListComboBox.Name = "EmployeeListComboBox";
      this.EmployeeListComboBox.Size = new System.Drawing.Size(300, 36);
      this.EmployeeListComboBox.Sorted = true;
      this.EmployeeListComboBox.TabIndex = 1;
      this.EmployeeListComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListComboBox_SelectedIndexChanged);
      this.EmployeeListComboBox.TextChanged += new System.EventHandler(this.EmployeeListComboBox_TextChanged);
      this.EmployeeListComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeListComboBox_KeyDown);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 5);
      this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(165, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "Search Employee:";
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.MessageTextBox);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel7.Location = new System.Drawing.Point(0, 337);
      this.panel7.Margin = new System.Windows.Forms.Padding(0);
      this.panel7.Name = "panel7";
      this.panel7.Padding = new System.Windows.Forms.Padding(5);
      this.panel7.Size = new System.Drawing.Size(521, 226);
      this.panel7.TabIndex = 1;
      // 
      // MessageTextBox
      // 
      this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MessageTextBox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.MessageTextBox.Location = new System.Drawing.Point(5, 5);
      this.MessageTextBox.Margin = new System.Windows.Forms.Padding(0);
      this.MessageTextBox.Multiline = true;
      this.MessageTextBox.Name = "MessageTextBox";
      this.MessageTextBox.ReadOnly = true;
      this.MessageTextBox.Size = new System.Drawing.Size(511, 216);
      this.MessageTextBox.TabIndex = 0;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 563);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.label2);
      this.panel4.Controls.Add(this.EmployeeIDTextBox);
      this.panel4.Controls.Add(this.SearchingLabel);
      this.panel4.Controls.Add(this.SearchBtn);
      this.panel4.Controls.Add(this.EmployeeListComboBox);
      this.panel4.Controls.Add(this.label1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Margin = new System.Windows.Forms.Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Padding = new System.Windows.Forms.Padding(5);
      this.panel4.Size = new System.Drawing.Size(521, 337);
      this.panel4.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Controls.Add(this.tableLayoutPanel3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(541, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(10);
      this.panel3.Size = new System.Drawing.Size(541, 583);
      this.panel3.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 583);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.tableLayoutPanel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1082, 583);
      this.panel1.TabIndex = 1;
      // 
      // RegisterForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
      this.ClientSize = new System.Drawing.Size(1082, 583);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "RegisterForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Register Form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.CaptureFingerPrintPictureBox)).EndInit();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox CaptureFingerPrintPictureBox;
    private System.Windows.Forms.Button CloseBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox EmployeeIDTextBox;
    private System.Windows.Forms.Label SearchingLabel;
    private System.Windows.Forms.Button SearchBtn;
    private System.Windows.Forms.ComboBox EmployeeListComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.TextBox MessageTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
  }
}