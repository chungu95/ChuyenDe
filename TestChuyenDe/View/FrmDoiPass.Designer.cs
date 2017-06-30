namespace TestChuyenDe.View
{
    partial class FrmDoiPass
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
            this.lblMaGDV = new System.Windows.Forms.Label();
            this.cbbMaGDV = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtReType = new System.Windows.Forms.TextBox();
            this.lblReType = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblLgName = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMaGDV
            // 
            this.lblMaGDV.AutoSize = true;
            this.lblMaGDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGDV.Location = new System.Drawing.Point(118, 52);
            this.lblMaGDV.Name = "lblMaGDV";
            this.lblMaGDV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaGDV.Size = new System.Drawing.Size(128, 16);
            this.lblMaGDV.TabIndex = 0;
            this.lblMaGDV.Text = "Mã giao dịch viên: ";
            // 
            // cbbMaGDV
            // 
            this.cbbMaGDV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaGDV.FormattingEnabled = true;
            this.cbbMaGDV.Location = new System.Drawing.Point(278, 51);
            this.cbbMaGDV.Name = "cbbMaGDV";
            this.cbbMaGDV.Size = new System.Drawing.Size(145, 21);
            this.cbbMaGDV.TabIndex = 1;
            this.cbbMaGDV.SelectionChangeCommitted += new System.EventHandler(this.cbbMaGDV_SelectionChangeCommitted);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(118, 106);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(76, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(278, 105);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(281, 21);
            this.txtHoten.TabIndex = 3;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(118, 216);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(99, 16);
            this.lblNewPass.TabIndex = 4;
            this.lblNewPass.Text = "Mật khẩu mới:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(278, 215);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(281, 21);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtReType
            // 
            this.txtReType.Location = new System.Drawing.Point(278, 266);
            this.txtReType.Name = "txtReType";
            this.txtReType.PasswordChar = '*';
            this.txtReType.Size = new System.Drawing.Size(281, 21);
            this.txtReType.TabIndex = 6;
            this.txtReType.TextChanged += new System.EventHandler(this.txtReType_TextChanged);
            // 
            // lblReType
            // 
            this.lblReType.AutoSize = true;
            this.lblReType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReType.Location = new System.Drawing.Point(118, 267);
            this.lblReType.Name = "lblReType";
            this.lblReType.Size = new System.Drawing.Size(127, 16);
            this.lblReType.TabIndex = 7;
            this.lblReType.Text = "Nhập lại mật khẩu:";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOk.Location = new System.Drawing.Point(595, 266);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(0, 23);
            this.lblOk.TabIndex = 8;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(169, 345);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(127, 40);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(334, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblLgName
            // 
            this.lblLgName.AutoSize = true;
            this.lblLgName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLgName.ForeColor = System.Drawing.Color.Red;
            this.lblLgName.Location = new System.Drawing.Point(462, 55);
            this.lblLgName.Name = "lblLgName";
            this.lblLgName.Size = new System.Drawing.Size(0, 16);
            this.lblLgName.TabIndex = 11;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(118, 163);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(91, 14);
            this.lblOldPass.TabIndex = 12;
            this.lblOldPass.Text = "Mật khẩu cũ: ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(278, 161);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(281, 21);
            this.txtOldPass.TabIndex = 13;
            // 
            // FrmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 428);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.lblLgName);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblReType);
            this.Controls.Add(this.txtReType);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.cbbMaGDV);
            this.Controls.Add(this.lblMaGDV);
            this.Name = "FrmDoiPass";
            this.Text = "FrmDoiPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGDV;
        private System.Windows.Forms.ComboBox cbbMaGDV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtReType;
        private System.Windows.Forms.Label lblReType;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLgName;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtOldPass;
    }
}