namespace SHT
{
    partial class FrmLogin
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
            this.label5 = new System.Windows.Forms.Label();
            this.make_but = new System.Windows.Forms.Button();
            this.Salons_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "__________";
            // 
            // make_but
            // 
            this.make_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.make_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_but.Location = new System.Drawing.Point(41, 123);
            this.make_but.Margin = new System.Windows.Forms.Padding(2);
            this.make_but.Name = "make_but";
            this.make_but.Size = new System.Drawing.Size(106, 47);
            this.make_but.TabIndex = 1;
            this.make_but.Text = "ایجاد حساب کاربری جدید";
            this.make_but.UseVisualStyleBackColor = false;
            this.make_but.Click += new System.EventHandler(this.make_but_Click);
            // 
            // Salons_Btn
            // 
            this.Salons_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Salons_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salons_Btn.Location = new System.Drawing.Point(41, 181);
            this.Salons_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Salons_Btn.Name = "Salons_Btn";
            this.Salons_Btn.Size = new System.Drawing.Size(106, 47);
            this.Salons_Btn.TabIndex = 2;
            this.Salons_Btn.Text = "بخش سالن ها";
            this.Salons_Btn.UseVisualStyleBackColor = false;
            this.Salons_Btn.Click += new System.EventHandler(this.Salons_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Zilla Slab", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sport Happy Time";
            // 
            // enter_but
            // 
            this.enter_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enter_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_but.Location = new System.Drawing.Point(41, 65);
            this.enter_but.Margin = new System.Windows.Forms.Padding(2);
            this.enter_but.Name = "enter_but";
            this.enter_but.Size = new System.Drawing.Size(106, 47);
            this.enter_but.TabIndex = 0;
            this.enter_but.Text = "ورود با حساب کاربری خودم";
            this.enter_but.UseVisualStyleBackColor = false;
            this.enter_but.Click += new System.EventHandler(this.enter_but_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "____________________";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(199, 246);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salons_Btn);
            this.Controls.Add(this.make_but);
            this.Controls.Add(this.enter_but);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button make_but;
        private System.Windows.Forms.Button Salons_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_but;
        private System.Windows.Forms.Label label4;
    }
}

