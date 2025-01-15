namespace SHT
{
    partial class FrmReserveSans
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
            this.button1 = new System.Windows.Forms.Button();
            this.mainmenu_but = new System.Windows.Forms.Button();
            this.reserve_but = new System.Windows.Forms.Button();
            this.typehall_combo = new System.Windows.Forms.ComboBox();
            this.freetime_combo = new System.Windows.Forms.ComboBox();
            this.availablehall_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(12, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "مشاهده قیمت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // mainmenu_but
            // 
            this.mainmenu_but.BackColor = System.Drawing.Color.Cyan;
            this.mainmenu_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu_but.Location = new System.Drawing.Point(12, 12);
            this.mainmenu_but.Name = "mainmenu_but";
            this.mainmenu_but.Size = new System.Drawing.Size(343, 33);
            this.mainmenu_but.TabIndex = 5;
            this.mainmenu_but.Text = "رفتن به منو اصلی";
            this.mainmenu_but.UseVisualStyleBackColor = false;
            this.mainmenu_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // reserve_but
            // 
            this.reserve_but.BackColor = System.Drawing.Color.Yellow;
            this.reserve_but.Enabled = false;
            this.reserve_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_but.Location = new System.Drawing.Point(12, 282);
            this.reserve_but.Name = "reserve_but";
            this.reserve_but.Size = new System.Drawing.Size(343, 38);
            this.reserve_but.TabIndex = 4;
            this.reserve_but.Text = "رزرو و پرداخت";
            this.reserve_but.UseVisualStyleBackColor = false;
            this.reserve_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // typehall_combo
            // 
            this.typehall_combo.FormattingEnabled = true;
            this.typehall_combo.Location = new System.Drawing.Point(29, 114);
            this.typehall_combo.Name = "typehall_combo";
            this.typehall_combo.Size = new System.Drawing.Size(149, 21);
            this.typehall_combo.TabIndex = 1;
            this.typehall_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // freetime_combo
            // 
            this.freetime_combo.FormattingEnabled = true;
            this.freetime_combo.Location = new System.Drawing.Point(29, 161);
            this.freetime_combo.Name = "freetime_combo";
            this.freetime_combo.Size = new System.Drawing.Size(149, 21);
            this.freetime_combo.TabIndex = 2;
            this.freetime_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // availablehall_combo
            // 
            this.availablehall_combo.FormattingEnabled = true;
            this.availablehall_combo.Location = new System.Drawing.Point(29, 67);
            this.availablehall_combo.Name = "availablehall_combo";
            this.availablehall_combo.Size = new System.Drawing.Size(149, 21);
            this.availablehall_combo.TabIndex = 0;
            this.availablehall_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = ": زمان های آزاد سالن";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.Location = new System.Drawing.Point(105, 226);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(45, 20);
            this.price_lbl.TabIndex = 10;
            this.price_lbl.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = ": قیمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = ": نوع سالن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ": نام سالن های موجود";
            // 
            // FrmReserveSans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(369, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainmenu_but);
            this.Controls.Add(this.reserve_but);
            this.Controls.Add(this.typehall_combo);
            this.Controls.Add(this.freetime_combo);
            this.Controls.Add(this.availablehall_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReserveSans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رزرو سانس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mainmenu_but;
        private System.Windows.Forms.Button reserve_but;
        private System.Windows.Forms.ComboBox typehall_combo;
        private System.Windows.Forms.ComboBox freetime_combo;
        private System.Windows.Forms.ComboBox availablehall_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}