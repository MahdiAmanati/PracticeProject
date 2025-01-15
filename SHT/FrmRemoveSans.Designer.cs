namespace SHT
{
    partial class FrmRemoveSans
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
            this.mainmenu_but = new System.Windows.Forms.Button();
            this.delete_but = new System.Windows.Forms.Button();
            this.sanstime_txt = new System.Windows.Forms.TextBox();
            this.TypeOfSalon_txt = new System.Windows.Forms.TextBox();
            this.hallname_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mainmenu_but
            // 
            this.mainmenu_but.BackColor = System.Drawing.Color.Cyan;
            this.mainmenu_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu_but.Location = new System.Drawing.Point(13, 12);
            this.mainmenu_but.Name = "mainmenu_but";
            this.mainmenu_but.Size = new System.Drawing.Size(284, 28);
            this.mainmenu_but.TabIndex = 4;
            this.mainmenu_but.Text = "رفتن به منو اصلی";
            this.mainmenu_but.UseVisualStyleBackColor = false;
            this.mainmenu_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmenu_but_KeyPress);
            // 
            // delete_but
            // 
            this.delete_but.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_but.BackColor = System.Drawing.Color.Yellow;
            this.delete_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_but.Location = new System.Drawing.Point(13, 267);
            this.delete_but.Name = "delete_but";
            this.delete_but.Size = new System.Drawing.Size(284, 31);
            this.delete_but.TabIndex = 3;
            this.delete_but.Text = "حذف ";
            this.delete_but.UseVisualStyleBackColor = false;
            this.delete_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmenu_but_KeyPress);
            // 
            // sanstime_txt
            // 
            this.sanstime_txt.Location = new System.Drawing.Point(13, 124);
            this.sanstime_txt.Name = "sanstime_txt";
            this.sanstime_txt.Size = new System.Drawing.Size(173, 20);
            this.sanstime_txt.TabIndex = 2;
            this.sanstime_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmenu_but_KeyPress);
            // 
            // TypeOfSalon_txt
            // 
            this.TypeOfSalon_txt.Location = new System.Drawing.Point(13, 91);
            this.TypeOfSalon_txt.Name = "TypeOfSalon_txt";
            this.TypeOfSalon_txt.Size = new System.Drawing.Size(173, 20);
            this.TypeOfSalon_txt.TabIndex = 1;
            this.TypeOfSalon_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmenu_but_KeyPress);
            // 
            // hallname_txt
            // 
            this.hallname_txt.Location = new System.Drawing.Point(13, 61);
            this.hallname_txt.Name = "hallname_txt";
            this.hallname_txt.Size = new System.Drawing.Size(173, 20);
            this.hallname_txt.TabIndex = 0;
            this.hallname_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmenu_but_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ": زمان سانس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ": نوع سالن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = ": نام سالن";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = ": رمز ورود";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = ": نام کاربری";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "اعضای سانس";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 167);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "مدیر سانس";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmRemoveSans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(313, 302);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mainmenu_but);
            this.Controls.Add(this.delete_but);
            this.Controls.Add(this.sanstime_txt);
            this.Controls.Add(this.TypeOfSalon_txt);
            this.Controls.Add(this.hallname_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRemoveSans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف سانس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainmenu_but;
        private System.Windows.Forms.Button delete_but;
        private System.Windows.Forms.TextBox sanstime_txt;
        private System.Windows.Forms.TextBox TypeOfSalon_txt;
        private System.Windows.Forms.TextBox hallname_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}