namespace SHT
{
    partial class FrmSalonLogin
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
            this.Manage_Btn = new System.Windows.Forms.Button();
            this.NewSalonAccount_Btn = new System.Windows.Forms.Button();
            this.MySalonAccount_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Manage_Btn
            // 
            this.Manage_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Manage_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Btn.Location = new System.Drawing.Point(13, 165);
            this.Manage_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Manage_Btn.Name = "Manage_Btn";
            this.Manage_Btn.Size = new System.Drawing.Size(154, 46);
            this.Manage_Btn.TabIndex = 2;
            this.Manage_Btn.Text = "مدیریت";
            this.Manage_Btn.UseVisualStyleBackColor = false;
            this.Manage_Btn.Click += new System.EventHandler(this.Manage_Btn_Click);
            // 
            // NewSalonAccount_Btn
            // 
            this.NewSalonAccount_Btn.BackColor = System.Drawing.Color.Yellow;
            this.NewSalonAccount_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSalonAccount_Btn.Location = new System.Drawing.Point(13, 89);
            this.NewSalonAccount_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.NewSalonAccount_Btn.Name = "NewSalonAccount_Btn";
            this.NewSalonAccount_Btn.Size = new System.Drawing.Size(154, 46);
            this.NewSalonAccount_Btn.TabIndex = 1;
            this.NewSalonAccount_Btn.Text = "ساخت حساب سالن جدید";
            this.NewSalonAccount_Btn.UseVisualStyleBackColor = false;
            this.NewSalonAccount_Btn.Click += new System.EventHandler(this.NewSalonAccount_Btn_Click);
            // 
            // MySalonAccount_Btn
            // 
            this.MySalonAccount_Btn.BackColor = System.Drawing.Color.Yellow;
            this.MySalonAccount_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySalonAccount_Btn.Location = new System.Drawing.Point(13, 13);
            this.MySalonAccount_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.MySalonAccount_Btn.Name = "MySalonAccount_Btn";
            this.MySalonAccount_Btn.Size = new System.Drawing.Size(154, 46);
            this.MySalonAccount_Btn.TabIndex = 0;
            this.MySalonAccount_Btn.Text = "ورود به حساب سالن خودم";
            this.MySalonAccount_Btn.UseVisualStyleBackColor = false;
            this.MySalonAccount_Btn.Click += new System.EventHandler(this.MySalonAccount_Btn_Click);
            // 
            // FrmSalonLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(187, 228);
            this.Controls.Add(this.Manage_Btn);
            this.Controls.Add(this.NewSalonAccount_Btn);
            this.Controls.Add(this.MySalonAccount_Btn);
            this.Name = "FrmSalonLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSalonLogin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Manage_Btn;
        private System.Windows.Forms.Button NewSalonAccount_Btn;
        private System.Windows.Forms.Button MySalonAccount_Btn;
    }
}