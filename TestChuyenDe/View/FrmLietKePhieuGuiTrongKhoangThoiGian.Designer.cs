namespace TestChuyenDe.View
{
    partial class FrmLietKePhieuGuiTrongKhoangThoiGian
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
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(252, 112);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacnhan.TabIndex = 18;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đến";
            // 
            // txtNgayketthuc
            // 
            this.txtNgayketthuc.Location = new System.Drawing.Point(357, 65);
            this.txtNgayketthuc.Name = "txtNgayketthuc";
            this.txtNgayketthuc.Size = new System.Drawing.Size(200, 21);
            this.txtNgayketthuc.TabIndex = 14;
            // 
            // txtNgaybatdau
            // 
            this.txtNgaybatdau.Location = new System.Drawing.Point(22, 65);
            this.txtNgaybatdau.Name = "txtNgaybatdau";
            this.txtNgaybatdau.Size = new System.Drawing.Size(200, 21);
            this.txtNgaybatdau.TabIndex = 13;
            // 
            // FrmLietKePhieuGuiTrongKhoangThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 328);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayketthuc);
            this.Controls.Add(this.txtNgaybatdau);
            this.Name = "FrmLietKePhieuGuiTrongKhoangThoiGian";
            this.Text = "FrmLietKePhieuGuiTrongKhoangThoiGian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtNgayketthuc;
        private System.Windows.Forms.DateTimePicker txtNgaybatdau;
    }
}