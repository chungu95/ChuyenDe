namespace TestChuyenDe.View
{
    partial class FrmLaiSuat
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
            this.cbbDichVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.dtngayad = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn dịch vụ muốn đổi ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbDichVu
            // 
            this.cbbDichVu.FormattingEnabled = true;
            this.cbbDichVu.Location = new System.Drawing.Point(135, 75);
            this.cbbDichVu.Name = "cbbDichVu";
            this.cbbDichVu.Size = new System.Drawing.Size(121, 21);
            this.cbbDichVu.TabIndex = 1;
            this.cbbDichVu.SelectedIndexChanged += new System.EventHandler(this.cbbDichVu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày áp dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lãi suất";
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(123, 205);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(100, 21);
            this.txtlaisuat.TabIndex = 5;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(145, 266);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnxacnhan.TabIndex = 6;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // dtngayad
            // 
            this.dtngayad.Enabled = false;
            this.dtngayad.Location = new System.Drawing.Point(123, 150);
            this.dtngayad.Name = "dtngayad";
            this.dtngayad.Size = new System.Drawing.Size(200, 21);
            this.dtngayad.TabIndex = 7;
            // 
            // FrmLaiSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 357);
            this.Controls.Add(this.dtngayad);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDichVu);
            this.Controls.Add(this.label1);
            this.Name = "FrmLaiSuat";
            this.Text = "FrmLaiSuat";
            this.Load += new System.EventHandler(this.FrmLaiSuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.DateTimePicker dtngayad;
    }
}