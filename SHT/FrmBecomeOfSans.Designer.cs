namespace SHT
{
    partial class FrmBecomeOfSans
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
            this.membership_but = new System.Windows.Forms.Button();
            this.membership_combo = new System.Windows.Forms.ComboBox();
            this.search_but = new System.Windows.Forms.Button();
            this.salontype_txt = new System.Windows.Forms.TextBox();
            this.salonname_txt = new System.Windows.Forms.TextBox();
            this.mainmenu_but = new System.Windows.Forms.Button();
            this.salontype_lbl = new System.Windows.Forms.Label();
            this.salonname_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // membership_but
            // 
            this.membership_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.membership_but.BackColor = System.Drawing.Color.Yellow;
            this.membership_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership_but.Location = new System.Drawing.Point(118, 195);
            this.membership_but.Margin = new System.Windows.Forms.Padding(2);
            this.membership_but.Name = "membership_but";
            this.membership_but.Size = new System.Drawing.Size(91, 23);
            this.membership_but.TabIndex = 3;
            this.membership_but.Text = "درخواست عضویت";
            this.membership_but.UseVisualStyleBackColor = false;
            this.membership_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // membership_combo
            // 
            this.membership_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.membership_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership_combo.FormattingEnabled = true;
            this.membership_combo.Location = new System.Drawing.Point(23, 195);
            this.membership_combo.Margin = new System.Windows.Forms.Padding(2);
            this.membership_combo.Name = "membership_combo";
            this.membership_combo.Size = new System.Drawing.Size(92, 24);
            this.membership_combo.TabIndex = 5;
            this.membership_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // search_but
            // 
            this.search_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_but.BackColor = System.Drawing.Color.Yellow;
            this.search_but.Location = new System.Drawing.Point(23, 141);
            this.search_but.Margin = new System.Windows.Forms.Padding(2);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(109, 29);
            this.search_but.TabIndex = 2;
            this.search_but.Text = "جستجو";
            this.search_but.UseVisualStyleBackColor = false;
            this.search_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // salontype_txt
            // 
            this.salontype_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salontype_txt.Location = new System.Drawing.Point(23, 105);
            this.salontype_txt.Margin = new System.Windows.Forms.Padding(2);
            this.salontype_txt.Name = "salontype_txt";
            this.salontype_txt.Size = new System.Drawing.Size(110, 20);
            this.salontype_txt.TabIndex = 1;
            this.salontype_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // salonname_txt
            // 
            this.salonname_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salonname_txt.Location = new System.Drawing.Point(23, 63);
            this.salonname_txt.Margin = new System.Windows.Forms.Padding(2);
            this.salonname_txt.Name = "salonname_txt";
            this.salonname_txt.Size = new System.Drawing.Size(110, 20);
            this.salonname_txt.TabIndex = 0;
            this.salonname_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // mainmenu_but
            // 
            this.mainmenu_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainmenu_but.BackColor = System.Drawing.Color.Cyan;
            this.mainmenu_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu_but.Location = new System.Drawing.Point(16, 22);
            this.mainmenu_but.Margin = new System.Windows.Forms.Padding(2);
            this.mainmenu_but.Name = "mainmenu_but";
            this.mainmenu_but.Size = new System.Drawing.Size(192, 27);
            this.mainmenu_but.TabIndex = 4;
            this.mainmenu_but.Text = "رفتن به منو اصلی";
            this.mainmenu_but.UseVisualStyleBackColor = false;
            this.mainmenu_but.Click += new System.EventHandler(this.mainmenu_but_Click);
            this.mainmenu_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salonname_txt_KeyPress);
            // 
            // salontype_lbl
            // 
            this.salontype_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salontype_lbl.AutoSize = true;
            this.salontype_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salontype_lbl.Location = new System.Drawing.Point(136, 100);
            this.salontype_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salontype_lbl.Name = "salontype_lbl";
            this.salontype_lbl.Size = new System.Drawing.Size(65, 20);
            this.salontype_lbl.TabIndex = 7;
            this.salontype_lbl.Text = ": نوع سالن";
            // 
            // salonname_lbl
            // 
            this.salonname_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salonname_lbl.AutoSize = true;
            this.salonname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonname_lbl.Location = new System.Drawing.Point(136, 60);
            this.salonname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salonname_lbl.Name = "salonname_lbl";
            this.salonname_lbl.Size = new System.Drawing.Size(62, 20);
            this.salonname_lbl.TabIndex = 6;
            this.salonname_lbl.Text = ": نام سالن ";
            // 
            // FrmBecomeOfSans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(229, 236);
            this.Controls.Add(this.membership_but);
            this.Controls.Add(this.membership_combo);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.salontype_txt);
            this.Controls.Add(this.salonname_txt);
            this.Controls.Add(this.mainmenu_but);
            this.Controls.Add(this.salontype_lbl);
            this.Controls.Add(this.salonname_lbl);
            this.Name = "FrmBecomeOfSans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBecomeOfSans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button membership_but;
        private System.Windows.Forms.ComboBox membership_combo;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.TextBox salontype_txt;
        private System.Windows.Forms.TextBox salonname_txt;
        private System.Windows.Forms.Button mainmenu_but;
        private System.Windows.Forms.Label salontype_lbl;
        private System.Windows.Forms.Label salonname_lbl;
    }
}