namespace SHT
{
    partial class FrmEnter
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
            this.ShowPassword_Check = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enter_but = new System.Windows.Forms.Button();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.UserName_Txt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowPassword_Check
            // 
            this.ShowPassword_Check.AutoSize = true;
            this.ShowPassword_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword_Check.Location = new System.Drawing.Point(11, 87);
            this.ShowPassword_Check.Name = "ShowPassword_Check";
            this.ShowPassword_Check.Size = new System.Drawing.Size(106, 20);
            this.ShowPassword_Check.TabIndex = 2;
            this.ShowPassword_Check.Text = "نمایش رمز ورود";
            this.ShowPassword_Check.UseVisualStyleBackColor = true;
            this.ShowPassword_Check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowPassword_Check_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "فوتبال",
            "والیبال",
            "هندبال",
            "بسکتبال"});
            this.comboBox1.Location = new System.Drawing.Point(11, 122);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowPassword_Check_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = ": رشته ورزشی ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            // 
            // enter_but
            // 
            this.enter_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enter_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_but.Location = new System.Drawing.Point(41, 166);
            this.enter_but.Margin = new System.Windows.Forms.Padding(2);
            this.enter_but.Name = "enter_but";
            this.enter_but.Size = new System.Drawing.Size(118, 38);
            this.enter_but.TabIndex = 4;
            this.enter_but.Text = "ورود";
            this.enter_but.UseVisualStyleBackColor = false;
            this.enter_but.Click += new System.EventHandler(this.enter_but_Click);
            this.enter_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowPassword_Check_KeyPress);
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(11, 60);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(98, 22);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowPassword_Check_KeyPress);
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Txt.Location = new System.Drawing.Point(11, 11);
            this.UserName_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.Size = new System.Drawing.Size(98, 22);
            this.UserName_Txt.TabIndex = 0;
            this.UserName_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowPassword_Check_KeyPress);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(113, 60);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(57, 16);
            this.password.TabIndex = 6;
            this.password.Text = ": رمز ورود";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(113, 11);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 16);
            this.name.TabIndex = 7;
            this.name.Text = ": نام کاربری";
            // 
            // FrmEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(193, 215);
            this.Controls.Add(this.ShowPassword_Check);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enter_but);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_Txt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "FrmEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEnter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowPassword_Check;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enter_but;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox UserName_Txt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
    }
}