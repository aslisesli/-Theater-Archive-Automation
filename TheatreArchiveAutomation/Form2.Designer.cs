namespace WindowsFormsApplication4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.oyunadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oyuncusayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.erkekoyuncusayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kadinoyuncusayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oynadii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oyuntürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Oyun Adı Yazınız";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Brown;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oyunadi,
            this.yazar,
            this.oyuncusayisi,
            this.erkekoyuncusayisi,
            this.kadinoyuncusayisi,
            this.oynadii,
            this.oyuntürü});
            this.listView1.Location = new System.Drawing.Point(0, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(852, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // oyunadi
            // 
            this.oyunadi.Text = "OYUN ADI";
            this.oyunadi.Width = 150;
            // 
            // yazar
            // 
            this.yazar.Text = "YAZAR";
            this.yazar.Width = 176;
            // 
            // oyuncusayisi
            // 
            this.oyuncusayisi.Text = "OYUNCU SAYISI";
            this.oyuncusayisi.Width = 110;
            // 
            // erkekoyuncusayisi
            // 
            this.erkekoyuncusayisi.Text = "ERKEK OYUNCU SAYISI";
            this.erkekoyuncusayisi.Width = 135;
            // 
            // kadinoyuncusayisi
            // 
            this.kadinoyuncusayisi.Text = "KADIN OYUNCU SAYISI";
            this.kadinoyuncusayisi.Width = 132;
            // 
            // oynadii
            // 
            this.oynadii.Text = "OYNADI";
            this.oynadii.Width = 63;
            // 
            // oyuntürü
            // 
            this.oyuntürü.Text = "OYUN TÜRÜ";
            this.oyuntürü.Width = 80;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 438);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader oyunadi;
        private System.Windows.Forms.ColumnHeader yazar;
        private System.Windows.Forms.ColumnHeader oyuncusayisi;
        private System.Windows.Forms.ColumnHeader erkekoyuncusayisi;
        private System.Windows.Forms.ColumnHeader kadinoyuncusayisi;
        private System.Windows.Forms.ColumnHeader oynadii;
        private System.Windows.Forms.ColumnHeader oyuntürü;
        private System.Windows.Forms.TextBox textBox1;
    }
}