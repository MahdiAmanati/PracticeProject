namespace SHT
{
    partial class FrmRequest
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
            this.targetusername_txt = new System.Windows.Forms.TextBox();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.targetusername_lbl = new System.Windows.Forms.Label();
            this.age_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_combo = new System.Windows.Forms.ListBox();
            this.lastname_combo = new System.Windows.Forms.ListBox();
            this.age_combo = new System.Windows.Forms.ListBox();
            this.accept_but = new System.Windows.Forms.Button();
            this.mainmenu_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targetusername_txt
            // 
            this.targetusername_txt.Location = new System.Drawing.Point(88, 282);
            this.targetusername_txt.Margin = new System.Windows.Forms.Padding(2);
            this.targetusername_txt.Name = "targetusername_txt";
            this.targetusername_txt.Size = new System.Drawing.Size(99, 20);
            this.targetusername_txt.TabIndex = 0;
            this.targetusername_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetusername_txt_KeyPress);
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Location = new System.Drawing.Point(86, 51);
            this.lastname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(69, 13);
            this.lastname_lbl.TabIndex = 8;
            this.lastname_lbl.Text = "نام خانوادگی";
            // 
            // targetusername_lbl
            // 
            this.targetusername_lbl.AutoSize = true;
            this.targetusername_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetusername_lbl.Location = new System.Drawing.Point(85, 252);
            this.targetusername_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetusername_lbl.Name = "targetusername_lbl";
            this.targetusername_lbl.Size = new System.Drawing.Size(111, 17);
            this.targetusername_lbl.TabIndex = 6;
            this.targetusername_lbl.Text = " نام کاربری مورد نظر";
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Location = new System.Drawing.Point(36, 51);
            this.age_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(23, 13);
            this.age_lbl.TabIndex = 9;
            this.age_lbl.Text = "سن";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(155, 51);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(58, 13);
            this.username_lbl.TabIndex = 7;
            this.username_lbl.Text = "نام کاربری";
            // 
            // username_combo
            // 
            this.username_combo.FormattingEnabled = true;
            this.username_combo.Location = new System.Drawing.Point(156, 75);
            this.username_combo.Margin = new System.Windows.Forms.Padding(2);
            this.username_combo.Name = "username_combo";
            this.username_combo.Size = new System.Drawing.Size(43, 160);
            this.username_combo.TabIndex = 3;
            // 
            // lastname_combo
            // 
            this.lastname_combo.FormattingEnabled = true;
            this.lastname_combo.Location = new System.Drawing.Point(90, 75);
            this.lastname_combo.Margin = new System.Windows.Forms.Padding(2);
            this.lastname_combo.Name = "lastname_combo";
            this.lastname_combo.Size = new System.Drawing.Size(43, 160);
            this.lastname_combo.TabIndex = 4;
            // 
            // age_combo
            // 
            this.age_combo.FormattingEnabled = true;
            this.age_combo.Location = new System.Drawing.Point(25, 75);
            this.age_combo.Margin = new System.Windows.Forms.Padding(2);
            this.age_combo.Name = "age_combo";
            this.age_combo.Size = new System.Drawing.Size(43, 160);
            this.age_combo.TabIndex = 5;
            // 
            // accept_but
            // 
            this.accept_but.BackColor = System.Drawing.Color.Yellow;
            this.accept_but.Location = new System.Drawing.Point(17, 252);
            this.accept_but.Margin = new System.Windows.Forms.Padding(2);
            this.accept_but.Name = "accept_but";
            this.accept_but.Size = new System.Drawing.Size(58, 48);
            this.accept_but.TabIndex = 1;
            this.accept_but.Text = "قبول کردن ";
            this.accept_but.UseVisualStyleBackColor = false;
            this.accept_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetusername_txt_KeyPress);
            // 
            // mainmenu_but
            // 
            this.mainmenu_but.BackColor = System.Drawing.Color.Cyan;
            this.mainmenu_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu_but.Location = new System.Drawing.Point(10, 14);
            this.mainmenu_but.Margin = new System.Windows.Forms.Padding(2);
            this.mainmenu_but.Name = "mainmenu_but";
            this.mainmenu_but.Size = new System.Drawing.Size(206, 27);
            this.mainmenu_but.TabIndex = 2;
            this.mainmenu_but.Text = "رفتن به منو اصلی";
            this.mainmenu_but.UseVisualStyleBackColor = false;
            this.mainmenu_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetusername_txt_KeyPress);
            // 
            // FrmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(227, 315);
            this.Controls.Add(this.targetusername_txt);
            this.Controls.Add(this.lastname_lbl);
            this.Controls.Add(this.targetusername_lbl);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_combo);
            this.Controls.Add(this.lastname_combo);
            this.Controls.Add(this.age_combo);
            this.Controls.Add(this.accept_but);
            this.Controls.Add(this.mainmenu_but);
            this.Name = "FrmRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخواست ها";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetusername_txt;
        private System.Windows.Forms.Label lastname_lbl;
        private System.Windows.Forms.Label targetusername_lbl;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.ListBox username_combo;
        private System.Windows.Forms.ListBox lastname_combo;
        private System.Windows.Forms.ListBox age_combo;
        private System.Windows.Forms.Button accept_but;
        private System.Windows.Forms.Button mainmenu_but;
    }
}