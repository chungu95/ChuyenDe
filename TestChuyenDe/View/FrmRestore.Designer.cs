namespace TestChuyenDe.View
{
    partial class FrmRestore
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnhuyrestore = new System.Windows.Forms.Button();
            this.txbrowser = new System.Windows.Forms.TextBox();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(145, 288);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnhuyrestore
            // 
            this.btnhuyrestore.Location = new System.Drawing.Point(306, 288);
            this.btnhuyrestore.Name = "btnhuyrestore";
            this.btnhuyrestore.Size = new System.Drawing.Size(75, 23);
            this.btnhuyrestore.TabIndex = 1;
            this.btnhuyrestore.Text = "HỦY RESTORE";
            this.btnhuyrestore.UseVisualStyleBackColor = true;
            // 
            // txbrowser
            // 
            this.txbrowser.Location = new System.Drawing.Point(211, 156);
            this.txbrowser.Name = "txbrowser";
            this.txbrowser.Size = new System.Drawing.Size(129, 21);
            this.txbrowser.TabIndex = 2;
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(388, 154);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 3;
            this.btnbrowser.Text = "BROWSER";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // FrmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 397);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.txbrowser);
            this.Controls.Add(this.btnhuyrestore);
            this.Controls.Add(this.btnRestore);
            this.Name = "FrmRestore";
            this.Text = "FrmRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnhuyrestore;
        private System.Windows.Forms.TextBox txbrowser;
        private System.Windows.Forms.Button btnbrowser;
    }
}