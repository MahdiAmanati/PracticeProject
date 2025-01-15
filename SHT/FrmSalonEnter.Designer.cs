namespace SHT
{
    partial class FrmSalonEnter
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
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.Password_Lbl = new System.Windows.Forms.Label();
            this.SalonName_Lbl = new System.Windows.Forms.Label();
            this.SalonPass_Txt = new System.Windows.Forms.TextBox();
            this.SalonName_Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Enter_Btn.Location = new System.Drawing.Point(40, 110);
            this.Enter_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(130, 36);
            this.Enter_Btn.TabIndex = 2;
            this.Enter_Btn.Text = "ورود";
            this.Enter_Btn.UseVisualStyleBackColor = false;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            this.Enter_Btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Btn_KeyPress);
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.AutoSize = true;
            this.Password_Lbl.Location = new System.Drawing.Point(147, 71);
            this.Password_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Size = new System.Drawing.Size(53, 13);
            this.Password_Lbl.TabIndex = 4;
            this.Password_Lbl.Text = ": رمز ورود";
            // 
            // SalonName_Lbl
            // 
            this.SalonName_Lbl.AutoSize = true;
            this.SalonName_Lbl.Location = new System.Drawing.Point(148, 17);
            this.SalonName_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalonName_Lbl.Name = "SalonName_Lbl";
            this.SalonName_Lbl.Size = new System.Drawing.Size(52, 13);
            this.SalonName_Lbl.TabIndex = 3;
            this.SalonName_Lbl.Text = ": نام سالن";
            // 
            // SalonPass_Txt
            // 
            this.SalonPass_Txt.Location = new System.Drawing.Point(13, 67);
            this.SalonPass_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.SalonPass_Txt.Name = "SalonPass_Txt";
            this.SalonPass_Txt.Size = new System.Drawing.Size(119, 20);
            this.SalonPass_Txt.TabIndex = 1;
            this.SalonPass_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Btn_KeyPress);
            // 
            // SalonName_Txt
            // 
            this.SalonName_Txt.Location = new System.Drawing.Point(13, 13);
            this.SalonName_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.SalonName_Txt.Name = "SalonName_Txt";
            this.SalonName_Txt.Size = new System.Drawing.Size(119, 20);
            this.SalonName_Txt.TabIndex = 0;
            this.SalonName_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Btn_KeyPress);
            // 
            // FrmSalonEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(208, 162);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.Password_Lbl);
            this.Controls.Add(this.SalonName_Lbl);
            this.Controls.Add(this.SalonPass_Txt);
            this.Controls.Add(this.SalonName_Txt);
            this.Name = "FrmSalonEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.Label Password_Lbl;
        private System.Windows.Forms.Label SalonName_Lbl;
        private System.Windows.Forms.TextBox SalonPass_Txt;
        private System.Windows.Forms.TextBox SalonName_Txt;
    }
}