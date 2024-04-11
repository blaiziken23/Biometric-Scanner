
namespace Biometric_Scanner
{
  partial class UserControlScanner
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.NameLabel = new System.Windows.Forms.Label();
      this.DateTimeLabel = new System.Windows.Forms.Label();
      this.StatusLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.tableLayoutPanel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(10);
      this.panel1.Size = new System.Drawing.Size(900, 500);
      this.panel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 480);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.NameLabel);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(880, 159);
      this.panel2.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.DateTimeLabel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 159);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(880, 159);
      this.panel3.TabIndex = 1;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.StatusLabel);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 318);
      this.panel4.Margin = new System.Windows.Forms.Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(880, 162);
      this.panel4.TabIndex = 2;
      // 
      // NameLabel
      // 
      this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NameLabel.Location = new System.Drawing.Point(0, 0);
      this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(880, 159);
      this.NameLabel.TabIndex = 0;
      this.NameLabel.Text = "Juan Dela Cruz";
      this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DateTimeLabel
      // 
      this.DateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DateTimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DateTimeLabel.Location = new System.Drawing.Point(0, 0);
      this.DateTimeLabel.Margin = new System.Windows.Forms.Padding(0);
      this.DateTimeLabel.Name = "DateTimeLabel";
      this.DateTimeLabel.Size = new System.Drawing.Size(880, 159);
      this.DateTimeLabel.TabIndex = 1;
      this.DateTimeLabel.Text = "Datetime";
      this.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // StatusLabel
      // 
      this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StatusLabel.Location = new System.Drawing.Point(0, 0);
      this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new System.Drawing.Size(880, 162);
      this.StatusLabel.TabIndex = 2;
      this.StatusLabel.Text = "Status";
      this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // UserControlScanner
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "UserControlScanner";
      this.Size = new System.Drawing.Size(900, 500);
      this.Load += new System.EventHandler(this.UserControlScanner_Load);
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label StatusLabel;
    private System.Windows.Forms.Label DateTimeLabel;
    private System.Windows.Forms.Label NameLabel;
  }
}
