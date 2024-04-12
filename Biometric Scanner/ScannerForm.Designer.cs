
namespace Biometric_Scanner
{
  partial class ScannerForm
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
      this.panel3 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.StatusLabel = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.TimeLabel = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.NameLabel = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel10 = new System.Windows.Forms.Panel();
      this.CurrentDateLabel = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.CurrentTimeLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel10.SuspendLayout();
      this.panel9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(10);
      this.panel1.Size = new System.Drawing.Size(1148, 592);
      this.panel1.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.tableLayoutPanel2);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(10, 110);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1128, 472);
      this.panel3.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 472);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.panel7);
      this.panel5.Controls.Add(this.panel6);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(0, 141);
      this.panel5.Margin = new System.Windows.Forms.Padding(0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(1128, 331);
      this.panel5.TabIndex = 1;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.StatusLabel);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel7.Location = new System.Drawing.Point(0, 100);
      this.panel7.Margin = new System.Windows.Forms.Padding(0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(1128, 100);
      this.panel7.TabIndex = 3;
      // 
      // StatusLabel
      // 
      this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StatusLabel.ForeColor = System.Drawing.Color.White;
      this.StatusLabel.Location = new System.Drawing.Point(0, 0);
      this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(1128, 100);
      this.StatusLabel.TabIndex = 0;
      this.StatusLabel.Text = "TIME IN";
      this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.TimeLabel);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(0, 0);
      this.panel6.Margin = new System.Windows.Forms.Padding(0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(1128, 100);
      this.panel6.TabIndex = 2;
      // 
      // TimeLabel
      // 
      this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.TimeLabel.Location = new System.Drawing.Point(0, 0);
      this.TimeLabel.Margin = new System.Windows.Forms.Padding(0);
      this.TimeLabel.Name = "TimeLabel";
      this.TimeLabel.Size = new System.Drawing.Size(1128, 100);
      this.TimeLabel.TabIndex = 1;
      this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.NameLabel);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Margin = new System.Windows.Forms.Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(1128, 141);
      this.panel4.TabIndex = 0;
      // 
      // NameLabel
      // 
      this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NameLabel.Location = new System.Drawing.Point(0, 0);
      this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(1128, 141);
      this.NameLabel.TabIndex = 2;
      this.NameLabel.Text = "SCAN FINGERPRINT...";
      this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Transparent;
      this.panel2.Controls.Add(this.tableLayoutPanel1);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(10, 10);
      this.panel2.Margin = new System.Windows.Forms.Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1128, 100);
      this.panel2.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(728, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // panel10
      // 
      this.panel10.Controls.Add(this.CurrentDateLabel);
      this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel10.Location = new System.Drawing.Point(10, 60);
      this.panel10.Margin = new System.Windows.Forms.Padding(0);
      this.panel10.Name = "panel10";
      this.panel10.Size = new System.Drawing.Size(390, 40);
      this.panel10.TabIndex = 1;
      // 
      // CurrentDateLabel
      // 
      this.CurrentDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentDateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CurrentDateLabel.Location = new System.Drawing.Point(0, 0);
      this.CurrentDateLabel.Margin = new System.Windows.Forms.Padding(0);
      this.CurrentDateLabel.Name = "CurrentDateLabel";
      this.CurrentDateLabel.Size = new System.Drawing.Size(390, 40);
      this.CurrentDateLabel.TabIndex = 0;
      this.CurrentDateLabel.Text = "Monday, 01, 2024";
      this.CurrentDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.CurrentTimeLabel);
      this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel9.Location = new System.Drawing.Point(10, 0);
      this.panel9.Margin = new System.Windows.Forms.Padding(0);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(390, 60);
      this.panel9.TabIndex = 0;
      // 
      // CurrentTimeLabel
      // 
      this.CurrentTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CurrentTimeLabel.Location = new System.Drawing.Point(0, 0);
      this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(0);
      this.CurrentTimeLabel.Name = "CurrentTimeLabel";
      this.CurrentTimeLabel.Size = new System.Drawing.Size(390, 60);
      this.CurrentTimeLabel.TabIndex = 0;
      this.CurrentTimeLabel.Text = "00:00:00 AM";
      this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Image = global::Biometric_Scanner.Properties.Resources.atomicLogo_removebg_preview;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(341, 100);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // ScannerForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
      this.ClientSize = new System.Drawing.Size(1148, 592);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ScannerForm";
      this.Text = "Scanner Form";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScannerForm_FormClosed);
      this.Load += new System.EventHandler(this.ScannerForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel10.ResumeLayout(false);
      this.panel9.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel10;
    private System.Windows.Forms.Label CurrentDateLabel;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.Label CurrentTimeLabel;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.Label TimeLabel;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Label StatusLabel;
    private System.Windows.Forms.Panel panel6;
  }
}