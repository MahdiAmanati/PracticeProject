namespace SHT
{
    partial class FrmCheangAccount
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
            this.ChVolayball = new System.Windows.Forms.CheckBox();
            this.ChBasketBall = new System.Windows.Forms.CheckBox();
            this.ChHandBall = new System.Windows.Forms.CheckBox();
            this.ChFootBall = new System.Windows.Forms.CheckBox();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.LblOldUserName = new System.Windows.Forms.Label();
            this.TxtOldUserName = new System.Windows.Forms.TextBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblOldPassword = new System.Windows.Forms.Label();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChVolayball
            // 
            this.ChVolayball.AutoSize = true;
            this.ChVolayball.Location = new System.Drawing.Point(181, 392);
            this.ChVolayball.Name = "ChVolayball";
            this.ChVolayball.Size = new System.Drawing.Size(57, 17);
            this.ChVolayball.TabIndex = 15;
            this.ChVolayball.Text = "والیبال";
            this.ChVolayball.UseVisualStyleBackColor = true;
            this.ChVolayball.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // ChBasketBall
            // 
            this.ChBasketBall.AutoSize = true;
            this.ChBasketBall.Location = new System.Drawing.Point(54, 392);
            this.ChBasketBall.Name = "ChBasketBall";
            this.ChBasketBall.Size = new System.Drawing.Size(65, 17);
            this.ChBasketBall.TabIndex = 17;
            this.ChBasketBall.Text = "بسکتبال";
            this.ChBasketBall.UseVisualStyleBackColor = true;
            this.ChBasketBall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // ChHandBall
            // 
            this.ChHandBall.AutoSize = true;
            this.ChHandBall.Location = new System.Drawing.Point(181, 342);
            this.ChHandBall.Name = "ChHandBall";
            this.ChHandBall.Size = new System.Drawing.Size(57, 17);
            this.ChHandBall.TabIndex = 14;
            this.ChHandBall.Text = "هندبال";
            this.ChHandBall.UseVisualStyleBackColor = true;
            this.ChHandBall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // ChFootBall
            // 
            this.ChFootBall.AutoSize = true;
            this.ChFootBall.Location = new System.Drawing.Point(54, 342);
            this.ChFootBall.Name = "ChFootBall";
            this.ChFootBall.Size = new System.Drawing.Size(57, 17);
            this.ChFootBall.TabIndex = 16;
            this.ChFootBall.Text = "فوتبال";
            this.ChFootBall.UseVisualStyleBackColor = true;
            this.ChFootBall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.Color.Cyan;
            this.BtnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 12);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(256, 33);
            this.BtnMainMenu.TabIndex = 7;
            this.BtnMainMenu.Text = "رفتن به منو اصلی";
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // LblOldUserName
            // 
            this.LblOldUserName.AutoSize = true;
            this.LblOldUserName.Location = new System.Drawing.Point(181, 62);
            this.LblOldUserName.Name = "LblOldUserName";
            this.LblOldUserName.Size = new System.Drawing.Size(92, 13);
            this.LblOldUserName.TabIndex = 8;
            this.LblOldUserName.Text = ": نام کاربری فعلی";
            // 
            // TxtOldUserName
            // 
            this.TxtOldUserName.Location = new System.Drawing.Point(12, 61);
            this.TxtOldUserName.Name = "TxtOldUserName";
            this.TxtOldUserName.Size = new System.Drawing.Size(158, 20);
            this.TxtOldUserName.TabIndex = 0;
            this.TxtOldUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.Yellow;
            this.BtnChange.Location = new System.Drawing.Point(12, 439);
            this.BtnChange.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(256, 37);
            this.BtnChange.TabIndex = 6;
            this.BtnChange.Text = "ثبت تغییرات";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.change_btn_Click);
            this.BtnChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(181, 299);
            this.LblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(59, 13);
            this.LblAge.TabIndex = 13;
            this.LblAge.Text = ": تاریخ تولد";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(181, 205);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(28, 13);
            this.LblPassword.TabIndex = 11;
            this.LblPassword.Text = ": رمز";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(181, 252);
            this.LblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(75, 13);
            this.LblPhone.TabIndex = 12;
            this.LblPhone.Text = ": شماره موبایل";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(264, 157);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(32, 13);
            this.LblName.TabIndex = 10;
            this.LblName.Text = ": نام  ";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(181, 120);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(67, 13);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = " : نام کاربری";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(12, 302);
            this.TxtAge.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(158, 20);
            this.TxtAge.TabIndex = 5;
            this.TxtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(12, 249);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(158, 20);
            this.TxtPhone.TabIndex = 4;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 202);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(158, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(12, 154);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(82, 20);
            this.TxtLastName.TabIndex = 2;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(12, 117);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(158, 20);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(178, 154);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtName.Size = new System.Drawing.Size(82, 20);
            this.TxtName.TabIndex = 2;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldUserName_Txt_KeyPress);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(98, 157);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(75, 13);
            this.LblLastName.TabIndex = 10;
            this.LblLastName.Text = ": نام خانوادگی";
            // 
            // LblOldPassword
            // 
            this.LblOldPassword.AutoSize = true;
            this.LblOldPassword.Location = new System.Drawing.Point(181, 91);
            this.LblOldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOldPassword.Name = "LblOldPassword";
            this.LblOldPassword.Size = new System.Drawing.Size(53, 13);
            this.LblOldPassword.TabIndex = 19;
            this.LblOldPassword.Text = ":رمز فعلی";
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.Location = new System.Drawing.Point(12, 88);
            this.TxtOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.Size = new System.Drawing.Size(158, 20);
            this.TxtOldPassword.TabIndex = 18;
            // 
            // FrmCheangAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(293, 489);
            this.Controls.Add(this.LblOldPassword);
            this.Controls.Add(this.TxtOldPassword);
            this.Controls.Add(this.ChVolayball);
            this.Controls.Add(this.ChBasketBall);
            this.Controls.Add(this.ChHandBall);
            this.Controls.Add(this.ChFootBall);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.LblOldUserName);
            this.Controls.Add(this.TxtOldUserName);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtUserName);
            this.Name = "FrmCheangAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییرات اکانت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChVolayball;
        private System.Windows.Forms.CheckBox ChBasketBall;
        private System.Windows.Forms.CheckBox ChHandBall;
        private System.Windows.Forms.CheckBox ChFootBall;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Label LblOldUserName;
        public System.Windows.Forms.TextBox TxtOldUserName;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblOldPassword;
        private System.Windows.Forms.TextBox TxtOldPassword;
    }
}