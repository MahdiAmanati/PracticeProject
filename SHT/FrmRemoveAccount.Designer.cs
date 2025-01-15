namespace SHT
{
    partial class FrmRemoveAccount
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
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.UserDelete_Btn = new System.Windows.Forms.Button();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainMenu_Btn
            // 
            this.MainMenu_Btn.BackColor = System.Drawing.Color.Cyan;
            this.MainMenu_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Btn.Location = new System.Drawing.Point(12, 12);
            this.MainMenu_Btn.Name = "MainMenu_Btn";
            this.MainMenu_Btn.Size = new System.Drawing.Size(260, 33);
            this.MainMenu_Btn.TabIndex = 5;
            this.MainMenu_Btn.Text = "رفتن به منو اصلی";
            this.MainMenu_Btn.UseVisualStyleBackColor = false;
            this.MainMenu_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRemoveAccount_KeyPress);
            // 
            // UserDelete_Btn
            // 
            this.UserDelete_Btn.BackColor = System.Drawing.Color.Yellow;
            this.UserDelete_Btn.Location = new System.Drawing.Point(12, 156);
            this.UserDelete_Btn.Margin = new System.Windows.Forms.Padding(6);
            this.UserDelete_Btn.Name = "UserDelete_Btn";
            this.UserDelete_Btn.Size = new System.Drawing.Size(260, 42);
            this.UserDelete_Btn.TabIndex = 4;
            this.UserDelete_Btn.Text = "حذف حساب کاربری";
            this.UserDelete_Btn.UseVisualStyleBackColor = false;
            this.UserDelete_Btn.Click += new System.EventHandler(this.UserDelete_Btn_Click);
            this.UserDelete_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRemoveAccount_KeyPress);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(182, 117);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(28, 13);
            this.password_lbl.TabIndex = 8;
            this.password_lbl.Text = ": رمز";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(182, 69);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(67, 13);
            this.username_lbl.TabIndex = 6;
            this.username_lbl.Text = " : نام کاربری";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 111);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(158, 20);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRemoveAccount_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(12, 63);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(158, 20);
            this.TxtUserName.TabIndex = 0;
            // 
            // FrmRemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(289, 207);
            this.Controls.Add(this.MainMenu_Btn);
            this.Controls.Add(this.UserDelete_Btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Name = "FrmRemoveAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف حساب کاربری";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRemoveAccount_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu_Btn;
        private System.Windows.Forms.Button UserDelete_Btn;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
    }
}