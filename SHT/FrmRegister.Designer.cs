namespace SHT
{
    partial class FrmRegister
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
            this.ChHandball = new System.Windows.Forms.CheckBox();
            this.ChVolayball = new System.Windows.Forms.CheckBox();
            this.ChBasketball = new System.Windows.Forms.CheckBox();
            this.ChFootball = new System.Windows.Forms.CheckBox();
            this.ButRegister = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "رشته های انتخابی";
            // 
            // ChHandball
            // 
            this.ChHandball.AutoSize = true;
            this.ChHandball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChHandball.Location = new System.Drawing.Point(196, 297);
            this.ChHandball.Name = "ChHandball";
            this.ChHandball.Size = new System.Drawing.Size(62, 20);
            this.ChHandball.TabIndex = 7;
            this.ChHandball.Text = "هند بال";
            this.ChHandball.UseVisualStyleBackColor = true;
            this.ChHandball.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // ChVolayball
            // 
            this.ChVolayball.AutoSize = true;
            this.ChVolayball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChVolayball.Location = new System.Drawing.Point(196, 256);
            this.ChVolayball.Name = "ChVolayball";
            this.ChVolayball.Size = new System.Drawing.Size(58, 20);
            this.ChVolayball.TabIndex = 5;
            this.ChVolayball.Text = "والیبال";
            this.ChVolayball.UseVisualStyleBackColor = true;
            this.ChVolayball.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // ChBasketball
            // 
            this.ChBasketball.AutoSize = true;
            this.ChBasketball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBasketball.Location = new System.Drawing.Point(84, 297);
            this.ChBasketball.Name = "ChBasketball";
            this.ChBasketball.Size = new System.Drawing.Size(67, 20);
            this.ChBasketball.TabIndex = 8;
            this.ChBasketball.Text = "بسکتبال";
            this.ChBasketball.UseVisualStyleBackColor = true;
            this.ChBasketball.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // ChFootball
            // 
            this.ChFootball.AutoSize = true;
            this.ChFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChFootball.Location = new System.Drawing.Point(84, 256);
            this.ChFootball.Name = "ChFootball";
            this.ChFootball.Size = new System.Drawing.Size(58, 20);
            this.ChFootball.TabIndex = 6;
            this.ChFootball.Text = "فوتبال";
            this.ChFootball.UseVisualStyleBackColor = true;
            this.ChFootball.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // ButRegister
            // 
            this.ButRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRegister.Location = new System.Drawing.Point(118, 340);
            this.ButRegister.Name = "ButRegister";
            this.ButRegister.Size = new System.Drawing.Size(95, 53);
            this.ButRegister.TabIndex = 9;
            this.ButRegister.Text = "ثبت نام";
            this.ButRegister.UseVisualStyleBackColor = false;
            this.ButRegister.Click += new System.EventHandler(this.register_but_Click);
            this.ButRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(55, 129);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(147, 22);
            this.TxtPhone.TabIndex = 2;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(25, 191);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(75, 22);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(55, 81);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(147, 22);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(217, 183);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(41, 22);
            this.TxtAge.TabIndex = 4;
            this.TxtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(56, 29);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(147, 22);
            this.TxtUserName.TabIndex = 0;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(216, 132);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(80, 16);
            this.LblPhone.TabIndex = 13;
            this.LblPhone.Text = ": شماره موبایل";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(104, 194);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(82, 16);
            this.LblLastName.TabIndex = 10;
            this.LblLastName.Text = ":  نام خانوادگی";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(264, 189);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(59, 13);
            this.LblAge.TabIndex = 12;
            this.LblAge.Text = ": تاریخ تولد";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(216, 81);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 16);
            this.LblPassword.TabIndex = 14;
            this.LblPassword.Text = ": رمز عبور";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(216, 29);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(69, 16);
            this.LblUserName.TabIndex = 15;
            this.LblUserName.Text = ": نام کاربری";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(25, 163);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(75, 22);
            this.TxtName.TabIndex = 3;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(106, 166);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(33, 16);
            this.LblName.TabIndex = 10;
            this.LblName.Text = ":  نام ";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(342, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChHandball);
            this.Controls.Add(this.ChVolayball);
            this.Controls.Add(this.ChBasketball);
            this.Controls.Add(this.ChFootball);
            this.Controls.Add(this.ButRegister);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegister_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRegister_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChHandball;
        private System.Windows.Forms.CheckBox ChVolayball;
        private System.Windows.Forms.CheckBox ChBasketball;
        private System.Windows.Forms.CheckBox ChFootball;
        private System.Windows.Forms.Button ButRegister;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
    }
}