namespace TestChuyenDe.View
{
    partial class FrmBackup
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbdatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbvitriluu = new System.Windows.Forms.TextBox();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnhuybackup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // tbdatabase
            // 
            this.tbdatabase.Location = new System.Drawing.Point(235, 83);
            this.tbdatabase.Name = "tbdatabase";
            this.tbdatabase.Size = new System.Drawing.Size(100, 21);
            this.tbdatabase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vị trí lưu";
            // 
            // tbvitriluu
            // 
            this.tbvitriluu.Location = new System.Drawing.Point(235, 155);
            this.tbvitriluu.Name = "tbvitriluu";
            this.tbvitriluu.Size = new System.Drawing.Size(100, 21);
            this.tbvitriluu.TabIndex = 3;
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(133, 270);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(75, 23);
            this.btnbackup.TabIndex = 4;
            this.btnbackup.Text = "BACKUP";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnhuybackup
            // 
            this.btnhuybackup.Location = new System.Drawing.Point(325, 270);
            this.btnhuybackup.Name = "btnhuybackup";
            this.btnhuybackup.Size = new System.Drawing.Size(108, 23);
            this.btnhuybackup.TabIndex = 5;
            this.btnhuybackup.Text = "HỦY BACKUP";
            this.btnhuybackup.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BROWSER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhuybackup);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.tbvitriluu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdatabase);
            this.Controls.Add(this.label1);
            this.Name = "FrmBackup";
            this.Text = "FrmBackup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbvitriluu;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnhuybackup;
        private System.Windows.Forms.Button button1;
    }
}