
namespace Biometric_Scanner
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.ReaderBtn = new System.Windows.Forms.Button();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.SelectBtn = new System.Windows.Forms.Button();
      this.panel4 = new System.Windows.Forms.Panel();
      this.RefreshBtn = new System.Windows.Forms.Button();
      this.ReadersComboBox = new System.Windows.Forms.ComboBox();
      this.ScannerBtn = new System.Windows.Forms.Button();
      this.RegisterBtn = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(432, 383);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel2.Controls.Add(this.ReaderBtn);
      this.panel2.Controls.Add(this.panel5);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(10);
      this.panel2.Size = new System.Drawing.Size(432, 383);
      this.panel2.TabIndex = 0;
      // 
      // ReaderBtn
      // 
      this.ReaderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ReaderBtn.AutoSize = true;
      this.ReaderBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ReaderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ReaderBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ReaderBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_reader_24;
      this.ReaderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ReaderBtn.Location = new System.Drawing.Point(181, 23);
      this.ReaderBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.ReaderBtn.Name = "ReaderBtn";
      this.ReaderBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.ReaderBtn.Size = new System.Drawing.Size(184, 50);
      this.ReaderBtn.TabIndex = 2;
      this.ReaderBtn.TabStop = false;
      this.ReaderBtn.Text = "  READER";
      this.ReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ReaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ReaderBtn.UseVisualStyleBackColor = false;
      this.ReaderBtn.Visible = false;
      this.ReaderBtn.Click += new System.EventHandler(this.ReaderBtn_Click);
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.panel3);
      this.panel5.Controls.Add(this.ScannerBtn);
      this.panel5.Controls.Add(this.RegisterBtn);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(10, 160);
      this.panel5.Margin = new System.Windows.Forms.Padding(0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(412, 213);
      this.panel5.TabIndex = 1;
      this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.tableLayoutPanel1);
      this.panel3.Controls.Add(this.ReadersComboBox);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, 111);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.panel3.Size = new System.Drawing.Size(412, 102);
      this.panel3.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 36);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 66);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.SelectBtn);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel6.Location = new System.Drawing.Point(0, 0);
      this.panel6.Margin = new System.Windows.Forms.Padding(0);
      this.panel6.Name = "panel6";
      this.panel6.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
      this.panel6.Size = new System.Drawing.Size(201, 66);
      this.panel6.TabIndex = 1;
      // 
      // SelectBtn
      // 
      this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SelectBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.SelectBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_select_cursor_24;
      this.SelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SelectBtn.Location = new System.Drawing.Point(51, 5);
      this.SelectBtn.Margin = new System.Windows.Forms.Padding(0);
      this.SelectBtn.Name = "SelectBtn";
      this.SelectBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.SelectBtn.Size = new System.Drawing.Size(145, 38);
      this.SelectBtn.TabIndex = 2;
      this.SelectBtn.Text = "Select";
      this.SelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SelectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.SelectBtn.UseVisualStyleBackColor = false;
      this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.RefreshBtn);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(201, 0);
      this.panel4.Margin = new System.Windows.Forms.Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
      this.panel4.Size = new System.Drawing.Size(201, 66);
      this.panel4.TabIndex = 0;
      // 
      // RefreshBtn
      // 
      this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RefreshBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_refresh_24;
      this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RefreshBtn.Location = new System.Drawing.Point(5, 5);
      this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0);
      this.RefreshBtn.Name = "RefreshBtn";
      this.RefreshBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.RefreshBtn.Size = new System.Drawing.Size(145, 38);
      this.RefreshBtn.TabIndex = 2;
      this.RefreshBtn.Text = "Refresh";
      this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.RefreshBtn.UseVisualStyleBackColor = true;
      this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
      // 
      // ReadersComboBox
      // 
      this.ReadersComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ReadersComboBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.ReadersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ReadersComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ReadersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.ReadersComboBox.FormattingEnabled = true;
      this.ReadersComboBox.Location = new System.Drawing.Point(5, 0);
      this.ReadersComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.ReadersComboBox.Name = "ReadersComboBox";
      this.ReadersComboBox.Size = new System.Drawing.Size(402, 36);
      this.ReadersComboBox.TabIndex = 3;
      // 
      // ScannerBtn
      // 
      this.ScannerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ScannerBtn.AutoSize = true;
      this.ScannerBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ScannerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ScannerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ScannerBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_fingerprint_241;
      this.ScannerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ScannerBtn.Location = new System.Drawing.Point(0, 5);
      this.ScannerBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.ScannerBtn.Name = "ScannerBtn";
      this.ScannerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.ScannerBtn.Size = new System.Drawing.Size(412, 50);
      this.ScannerBtn.TabIndex = 1;
      this.ScannerBtn.TabStop = false;
      this.ScannerBtn.Text = "  SCANNER";
      this.ScannerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ScannerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ScannerBtn.UseVisualStyleBackColor = false;
      this.ScannerBtn.Click += new System.EventHandler(this.ScannerBtn_Click);
      // 
      // RegisterBtn
      // 
      this.RegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.RegisterBtn.AutoSize = true;
      this.RegisterBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RegisterBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_writer_male_24;
      this.RegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RegisterBtn.Location = new System.Drawing.Point(0, 58);
      this.RegisterBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.RegisterBtn.Name = "RegisterBtn";
      this.RegisterBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.RegisterBtn.Size = new System.Drawing.Size(412, 50);
      this.RegisterBtn.TabIndex = 1;
      this.RegisterBtn.TabStop = false;
      this.RegisterBtn.Text = "  REGISTER";
      this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RegisterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.RegisterBtn.UseVisualStyleBackColor = false;
      this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::Biometric_Scanner.Properties.Resources.atomicLogo_removebg_preview;
      this.pictureBox1.Location = new System.Drawing.Point(10, 10);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(412, 150);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.WaitOnLoad = true;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
      this.ClientSize = new System.Drawing.Size(432, 383);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(450, 430);
      this.MinimumSize = new System.Drawing.Size(450, 430);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Atomic Builders OPC Biometric Scanner";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button RegisterBtn;
    private System.Windows.Forms.Button ScannerBtn;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Button ReaderBtn;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button RefreshBtn;
    private System.Windows.Forms.ComboBox ReadersComboBox;
    private System.Windows.Forms.Button SelectBtn;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel4;
  }
}