
namespace Biometric_Scanner
{
  partial class ReaderSelectionForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.SaveBtn = new System.Windows.Forms.Button();
      this.BackBtn = new System.Windows.Forms.Button();
      this.SelectBtn = new System.Windows.Forms.Button();
      this.RefreshBtn = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.ReadersComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(10);
      this.panel1.Size = new System.Drawing.Size(382, 199);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.panel4);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(10, 10);
      this.panel2.Margin = new System.Windows.Forms.Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(362, 179);
      this.panel2.TabIndex = 0;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.panel5);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(0, 75);
      this.panel4.Margin = new System.Windows.Forms.Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(362, 104);
      this.panel4.TabIndex = 1;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.SaveBtn);
      this.panel5.Controls.Add(this.BackBtn);
      this.panel5.Controls.Add(this.SelectBtn);
      this.panel5.Controls.Add(this.RefreshBtn);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(0, 0);
      this.panel5.Margin = new System.Windows.Forms.Padding(0);
      this.panel5.Name = "panel5";
      this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
      this.panel5.Size = new System.Drawing.Size(362, 104);
      this.panel5.TabIndex = 0;
      // 
      // SaveBtn
      // 
      this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.SaveBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_save_24;
      this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SaveBtn.Location = new System.Drawing.Point(202, 50);
      this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.SaveBtn.Size = new System.Drawing.Size(150, 38);
      this.SaveBtn.TabIndex = 1;
      this.SaveBtn.Text = "Save";
      this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.SaveBtn.UseVisualStyleBackColor = false;
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
      // 
      // BackBtn
      // 
      this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BackBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_back_24;
      this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BackBtn.Location = new System.Drawing.Point(10, 50);
      this.BackBtn.Margin = new System.Windows.Forms.Padding(0);
      this.BackBtn.Name = "BackBtn";
      this.BackBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.BackBtn.Size = new System.Drawing.Size(150, 38);
      this.BackBtn.TabIndex = 0;
      this.BackBtn.Text = "Back";
      this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BackBtn.UseVisualStyleBackColor = true;
      this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
      // 
      // SelectBtn
      // 
      this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SelectBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.SelectBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_select_cursor_24;
      this.SelectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SelectBtn.Location = new System.Drawing.Point(202, 12);
      this.SelectBtn.Margin = new System.Windows.Forms.Padding(0);
      this.SelectBtn.Name = "SelectBtn";
      this.SelectBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.SelectBtn.Size = new System.Drawing.Size(150, 38);
      this.SelectBtn.TabIndex = 1;
      this.SelectBtn.Text = "Select";
      this.SelectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SelectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.SelectBtn.UseVisualStyleBackColor = false;
      this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
      // 
      // RefreshBtn
      // 
      this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RefreshBtn.Image = global::Biometric_Scanner.Properties.Resources.icons8_refresh_24;
      this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RefreshBtn.Location = new System.Drawing.Point(10, 12);
      this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0);
      this.RefreshBtn.Name = "RefreshBtn";
      this.RefreshBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.RefreshBtn.Size = new System.Drawing.Size(150, 38);
      this.RefreshBtn.TabIndex = 0;
      this.RefreshBtn.Text = "Refresh";
      this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.RefreshBtn.UseVisualStyleBackColor = true;
      this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.ReadersComboBox);
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(362, 75);
      this.panel3.TabIndex = 0;
      // 
      // ReadersComboBox
      // 
      this.ReadersComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ReadersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ReadersComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ReadersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.ReadersComboBox.FormattingEnabled = true;
      this.ReadersComboBox.Location = new System.Drawing.Point(0, 31);
      this.ReadersComboBox.Margin = new System.Windows.Forms.Padding(0);
      this.ReadersComboBox.Name = "ReadersComboBox";
      this.ReadersComboBox.Size = new System.Drawing.Size(362, 36);
      this.ReadersComboBox.TabIndex = 1;
      this.ReadersComboBox.SelectedIndexChanged += new System.EventHandler(this.ReadersComboBox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "Select Reader:";
      // 
      // ReaderSelectionForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(382, 199);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ReaderSelectionForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Reader Selection";
      this.Load += new System.EventHandler(this.ReaderSelectionForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ComboBox ReadersComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Button SelectBtn;
    private System.Windows.Forms.Button RefreshBtn;
    private System.Windows.Forms.Button SaveBtn;
    private System.Windows.Forms.Button BackBtn;
  }
}