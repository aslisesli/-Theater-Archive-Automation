namespace WindowsFormsApplication4
{
    partial class Form3
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
            this.oyuntürütxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.oynaditxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kdnoyuncutxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.erkekoyuncutxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oyncusayisitxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yzrtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oyunaditxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(487, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 47;
            this.button1.Text = "OYUN EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oyuntürütxt
            // 
            this.oyuntürütxt.FormattingEnabled = true;
            this.oyuntürütxt.Items.AddRange(new object[] {
            "KOMEDİ",
            "DRAM",
            "TRAJEDİ",
            "MÜZİKAL",
            "PANDOMİM",
            "TULUAT",
            "OPERA",
            "OPERET",
            "BALE",
            "REVÜ"});
            this.oyuntürütxt.Location = new System.Drawing.Point(96, 252);
            this.oyuntürütxt.Name = "oyuntürütxt";
            this.oyuntürütxt.Size = new System.Drawing.Size(162, 21);
            this.oyuntürütxt.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(93, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Oyun Türü";
            // 
            // oynaditxt
            // 
            this.oynaditxt.FormattingEnabled = true;
            this.oynaditxt.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.oynaditxt.Location = new System.Drawing.Point(528, 155);
            this.oynaditxt.Name = "oynaditxt";
            this.oynaditxt.Size = new System.Drawing.Size(162, 21);
            this.oynaditxt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(525, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Oynadı";
            // 
            // kdnoyuncutxt
            // 
            this.kdnoyuncutxt.Location = new System.Drawing.Point(311, 155);
            this.kdnoyuncutxt.Name = "kdnoyuncutxt";
            this.kdnoyuncutxt.Size = new System.Drawing.Size(162, 20);
            this.kdnoyuncutxt.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(308, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Kadın Oyuncu Sayısı";
            // 
            // erkekoyuncutxt
            // 
            this.erkekoyuncutxt.Location = new System.Drawing.Point(96, 155);
            this.erkekoyuncutxt.Name = "erkekoyuncutxt";
            this.erkekoyuncutxt.Size = new System.Drawing.Size(162, 20);
            this.erkekoyuncutxt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(93, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Erkek Oyuncu Sayısı";
            // 
            // oyncusayisitxt
            // 
            this.oyncusayisitxt.Location = new System.Drawing.Point(528, 57);
            this.oyncusayisitxt.Name = "oyncusayisitxt";
            this.oyncusayisitxt.Size = new System.Drawing.Size(162, 20);
            this.oyncusayisitxt.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(525, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Oyuncu Sayısı";
            // 
            // yzrtxt
            // 
            this.yzrtxt.Location = new System.Drawing.Point(311, 57);
            this.yzrtxt.Name = "yzrtxt";
            this.yzrtxt.Size = new System.Drawing.Size(162, 20);
            this.yzrtxt.TabIndex = 35;
            this.yzrtxt.TextChanged += new System.EventHandler(this.yzrtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(93, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Oyun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(308, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Yazar";
            // 
            // oyunaditxt
            // 
            this.oyunaditxt.Location = new System.Drawing.Point(96, 57);
            this.oyunaditxt.Name = "oyunaditxt";
            this.oyunaditxt.Size = new System.Drawing.Size(162, 20);
            this.oyunaditxt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(308, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Yazar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(93, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Oyun Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(525, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Oyuncu Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(93, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "Erkek Oyuncu Sayısı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(308, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Kadın Oyuncu Sayısı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(525, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "Oynadı";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(782, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oyuntürütxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.oynaditxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kdnoyuncutxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.erkekoyuncutxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oyncusayisitxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yzrtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oyunaditxt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox oyuntürütxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox oynaditxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kdnoyuncutxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox erkekoyuncutxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oyncusayisitxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yzrtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oyunaditxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}