namespace SHT
{
    partial class FrmSalonRequest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Check_Btn = new System.Windows.Forms.Button();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.Request_Btn = new System.Windows.Forms.Button();
            this.Password_Lbl = new System.Windows.Forms.Label();
            this.Location_Lbl = new System.Windows.Forms.Label();
            this.Price_Lbl = new System.Windows.Forms.Label();
            this.Address_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeOfSalon_Lbl = new System.Windows.Forms.Label();
            this.SalonName_Lbl = new System.Windows.Forms.Label();
            this.Password_Txt = new System.Windows.Forms.TextBox();
            this.Price_Txt = new System.Windows.Forms.TextBox();
            this.Address_Txt = new System.Windows.Forms.TextBox();
            this.TypeOfSalon_Txt = new System.Windows.Forms.TextBox();
            this.SalonName_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 132);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Check_Btn
            // 
            this.Check_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Check_Btn.Enabled = false;
            this.Check_Btn.Location = new System.Drawing.Point(16, 430);
            this.Check_Btn.Name = "Check_Btn";
            this.Check_Btn.Size = new System.Drawing.Size(130, 37);
            this.Check_Btn.TabIndex = 6;
            this.Check_Btn.Text = "چک کردن";
            this.Check_Btn.UseVisualStyleBackColor = false;
            this.Check_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // Register_Btn
            // 
            this.Register_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Register_Btn.Enabled = false;
            this.Register_Btn.Location = new System.Drawing.Point(16, 477);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(263, 37);
            this.Register_Btn.TabIndex = 7;
            this.Register_Btn.Text = "ایجاد حساب";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // Request_Btn
            // 
            this.Request_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Request_Btn.Location = new System.Drawing.Point(149, 430);
            this.Request_Btn.Name = "Request_Btn";
            this.Request_Btn.Size = new System.Drawing.Size(130, 37);
            this.Request_Btn.TabIndex = 5;
            this.Request_Btn.Text = "درخواست ایجاد حساب";
            this.Request_Btn.UseVisualStyleBackColor = false;
            this.Request_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.AutoSize = true;
            this.Password_Lbl.Location = new System.Drawing.Point(208, 226);
            this.Password_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_Lbl.TabIndex = 12;
            this.Password_Lbl.Text = ": رمز ورود";
            // 
            // Location_Lbl
            // 
            this.Location_Lbl.AutoSize = true;
            this.Location_Lbl.Location = new System.Drawing.Point(208, 332);
            this.Location_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Location_Lbl.Name = "Location_Lbl";
            this.Location_Lbl.Size = new System.Drawing.Size(49, 13);
            this.Location_Lbl.TabIndex = 13;
            this.Location_Lbl.Text = ": لوکیشن";
            // 
            // Price_Lbl
            // 
            this.Price_Lbl.AutoSize = true;
            this.Price_Lbl.Location = new System.Drawing.Point(208, 177);
            this.Price_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price_Lbl.Name = "Price_Lbl";
            this.Price_Lbl.Size = new System.Drawing.Size(36, 13);
            this.Price_Lbl.TabIndex = 11;
            this.Price_Lbl.Text = ": قیمت";
            // 
            // Address_Lbl
            // 
            this.Address_Lbl.AutoSize = true;
            this.Address_Lbl.Location = new System.Drawing.Point(208, 127);
            this.Address_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_Lbl.Name = "Address_Lbl";
            this.Address_Lbl.Size = new System.Drawing.Size(36, 13);
            this.Address_Lbl.TabIndex = 10;
            this.Address_Lbl.Text = ": آدرس";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "مانند : سالن ، چمن ، ساحلی";
            // 
            // TypeOfSalon_Lbl
            // 
            this.TypeOfSalon_Lbl.AutoSize = true;
            this.TypeOfSalon_Lbl.Location = new System.Drawing.Point(208, 61);
            this.TypeOfSalon_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeOfSalon_Lbl.Name = "TypeOfSalon_Lbl";
            this.TypeOfSalon_Lbl.Size = new System.Drawing.Size(56, 13);
            this.TypeOfSalon_Lbl.TabIndex = 9;
            this.TypeOfSalon_Lbl.Text = ": نوع سالن";
            // 
            // SalonName_Lbl
            // 
            this.SalonName_Lbl.AutoSize = true;
            this.SalonName_Lbl.Location = new System.Drawing.Point(208, 12);
            this.SalonName_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalonName_Lbl.Name = "SalonName_Lbl";
            this.SalonName_Lbl.Size = new System.Drawing.Size(52, 13);
            this.SalonName_Lbl.TabIndex = 8;
            this.SalonName_Lbl.Text = ": نام سالن";
            // 
            // Password_Txt
            // 
            this.Password_Txt.Location = new System.Drawing.Point(13, 223);
            this.Password_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Size = new System.Drawing.Size(177, 20);
            this.Password_Txt.TabIndex = 4;
            this.Password_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // Price_Txt
            // 
            this.Price_Txt.Location = new System.Drawing.Point(13, 174);
            this.Price_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Price_Txt.Name = "Price_Txt";
            this.Price_Txt.Size = new System.Drawing.Size(177, 20);
            this.Price_Txt.TabIndex = 3;
            this.Price_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // Address_Txt
            // 
            this.Address_Txt.Location = new System.Drawing.Point(13, 124);
            this.Address_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Address_Txt.Name = "Address_Txt";
            this.Address_Txt.Size = new System.Drawing.Size(177, 20);
            this.Address_Txt.TabIndex = 2;
            this.Address_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // TypeOfSalon_Txt
            // 
            this.TypeOfSalon_Txt.Location = new System.Drawing.Point(13, 58);
            this.TypeOfSalon_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.TypeOfSalon_Txt.Name = "TypeOfSalon_Txt";
            this.TypeOfSalon_Txt.Size = new System.Drawing.Size(177, 20);
            this.TypeOfSalon_Txt.TabIndex = 1;
            this.TypeOfSalon_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // SalonName_Txt
            // 
            this.SalonName_Txt.Location = new System.Drawing.Point(13, 9);
            this.SalonName_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.SalonName_Txt.Name = "SalonName_Txt";
            this.SalonName_Txt.Size = new System.Drawing.Size(177, 20);
            this.SalonName_Txt.TabIndex = 0;
            this.SalonName_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeOfSalon_Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = ": شهر";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 19;
            // 
            // FrmSalonRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(290, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Check_Btn);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.Request_Btn);
            this.Controls.Add(this.Password_Lbl);
            this.Controls.Add(this.Location_Lbl);
            this.Controls.Add(this.Price_Lbl);
            this.Controls.Add(this.Address_Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfSalon_Lbl);
            this.Controls.Add(this.SalonName_Lbl);
            this.Controls.Add(this.Password_Txt);
            this.Controls.Add(this.Price_Txt);
            this.Controls.Add(this.Address_Txt);
            this.Controls.Add(this.TypeOfSalon_Txt);
            this.Controls.Add(this.SalonName_Txt);
            this.Name = "FrmSalonRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخواست دادن";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Check_Btn;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Button Request_Btn;
        private System.Windows.Forms.Label Password_Lbl;
        private System.Windows.Forms.Label Location_Lbl;
        private System.Windows.Forms.Label Price_Lbl;
        private System.Windows.Forms.Label Address_Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TypeOfSalon_Lbl;
        private System.Windows.Forms.Label SalonName_Lbl;
        private System.Windows.Forms.TextBox Password_Txt;
        private System.Windows.Forms.TextBox Price_Txt;
        private System.Windows.Forms.TextBox Address_Txt;
        private System.Windows.Forms.TextBox TypeOfSalon_Txt;
        private System.Windows.Forms.TextBox SalonName_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}