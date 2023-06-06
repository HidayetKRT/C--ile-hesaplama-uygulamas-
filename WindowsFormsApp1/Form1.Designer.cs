namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.uygulamakapat = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbskgHesaplama = new System.Windows.Forms.Button();
            this.alanhesaplama = new System.Windows.Forms.Button();
            this.anasayfa = new System.Windows.Forms.Button();
            this.yagoranıhesaplama = new System.Windows.Forms.Button();
            this.sayıtabanDönüşümüHesaplama = new System.Windows.Forms.Button();
            this.standartsapma = new System.Windows.Forms.Button();
            this.hacimHesaplama = new System.Windows.Forms.Button();
            this.kmmilHesaplama = new System.Windows.Forms.Button();
            this.cmincdönüşümü = new System.Windows.Forms.Button();
            this.EbobEkokHesaplama = new System.Windows.Forms.Button();
            this.asalçarpanhesaplama = new System.Windows.Forms.Button();
            this.desihesaplama = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.menubtn);
            this.panel1.Controls.Add(this.uygulamakapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // uygulamakapat
            // 
            this.uygulamakapat.Location = new System.Drawing.Point(635, 7);
            this.uygulamakapat.Name = "uygulamakapat";
            this.uygulamakapat.Size = new System.Drawing.Size(32, 23);
            this.uygulamakapat.TabIndex = 1;
            this.uygulamakapat.Text = "X";
            this.uygulamakapat.UseVisualStyleBackColor = true;
            this.uygulamakapat.Click += new System.EventHandler(this.uygulamakapat_Click);
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.Silver;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menubtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menubtn.Location = new System.Drawing.Point(14, -7);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(41, 41);
            this.menubtn.TabIndex = 0;
            this.menubtn.Text = "⁝";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(2, 80);
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(2, 80);
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.lbskgHesaplama);
            this.panel2.Controls.Add(this.alanhesaplama);
            this.panel2.Controls.Add(this.anasayfa);
            this.panel2.Controls.Add(this.yagoranıhesaplama);
            this.panel2.Controls.Add(this.sayıtabanDönüşümüHesaplama);
            this.panel2.Controls.Add(this.standartsapma);
            this.panel2.Controls.Add(this.hacimHesaplama);
            this.panel2.Controls.Add(this.kmmilHesaplama);
            this.panel2.Controls.Add(this.cmincdönüşümü);
            this.panel2.Controls.Add(this.EbobEkokHesaplama);
            this.panel2.Controls.Add(this.asalçarpanhesaplama);
            this.panel2.Controls.Add(this.desihesaplama);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 428);
            this.panel2.TabIndex = 1;
            // 
            // lbskgHesaplama
            // 
            this.lbskgHesaplama.BackColor = System.Drawing.Color.OrangeRed;
            this.lbskgHesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbskgHesaplama.Location = new System.Drawing.Point(23, 502);
            this.lbskgHesaplama.Name = "lbskgHesaplama";
            this.lbskgHesaplama.Size = new System.Drawing.Size(101, 38);
            this.lbskgHesaplama.TabIndex = 13;
            this.lbskgHesaplama.Text = "lbs kg Hesaplama";
            this.lbskgHesaplama.UseVisualStyleBackColor = false;
            this.lbskgHesaplama.Click += new System.EventHandler(this.lbskgHesaplama_Click);
            // 
            // alanhesaplama
            // 
            this.alanhesaplama.BackColor = System.Drawing.Color.DarkCyan;
            this.alanhesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alanhesaplama.Location = new System.Drawing.Point(23, 55);
            this.alanhesaplama.Name = "alanhesaplama";
            this.alanhesaplama.Size = new System.Drawing.Size(100, 36);
            this.alanhesaplama.TabIndex = 3;
            this.alanhesaplama.Text = "Alan hesaplama";
            this.alanhesaplama.UseVisualStyleBackColor = false;
            this.alanhesaplama.Click += new System.EventHandler(this.alanhesaplama_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Gray;
            this.anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfa.Location = new System.Drawing.Point(23, 11);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(100, 33);
            this.anasayfa.TabIndex = 12;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // yagoranıhesaplama
            // 
            this.yagoranıhesaplama.BackColor = System.Drawing.Color.Sienna;
            this.yagoranıhesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yagoranıhesaplama.Location = new System.Drawing.Point(22, 458);
            this.yagoranıhesaplama.Name = "yagoranıhesaplama";
            this.yagoranıhesaplama.Size = new System.Drawing.Size(101, 38);
            this.yagoranıhesaplama.TabIndex = 11;
            this.yagoranıhesaplama.Text = "Yağ Oranı Hesaplama";
            this.yagoranıhesaplama.UseVisualStyleBackColor = false;
            this.yagoranıhesaplama.Click += new System.EventHandler(this.yagoranıhesaplama_Click);
            // 
            // sayıtabanDönüşümüHesaplama
            // 
            this.sayıtabanDönüşümüHesaplama.BackColor = System.Drawing.Color.Peru;
            this.sayıtabanDönüşümüHesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sayıtabanDönüşümüHesaplama.Location = new System.Drawing.Point(23, 365);
            this.sayıtabanDönüşümüHesaplama.Name = "sayıtabanDönüşümüHesaplama";
            this.sayıtabanDönüşümüHesaplama.Size = new System.Drawing.Size(100, 39);
            this.sayıtabanDönüşümüHesaplama.TabIndex = 9;
            this.sayıtabanDönüşümüHesaplama.Text = "Taban Dönüşümü Hesaplama ";
            this.sayıtabanDönüşümüHesaplama.UseVisualStyleBackColor = false;
            this.sayıtabanDönüşümüHesaplama.Click += new System.EventHandler(this.sayıtabanDönüşümüHesaplama_Click);
            // 
            // standartsapma
            // 
            this.standartsapma.BackColor = System.Drawing.Color.Coral;
            this.standartsapma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standartsapma.Location = new System.Drawing.Point(22, 413);
            this.standartsapma.Name = "standartsapma";
            this.standartsapma.Size = new System.Drawing.Size(101, 36);
            this.standartsapma.TabIndex = 10;
            this.standartsapma.Text = "Standart Sapma Hesaplama";
            this.standartsapma.UseVisualStyleBackColor = false;
            this.standartsapma.Click += new System.EventHandler(this.standartsapma_Click);
            // 
            // hacimHesaplama
            // 
            this.hacimHesaplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(79)))));
            this.hacimHesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hacimHesaplama.Location = new System.Drawing.Point(23, 323);
            this.hacimHesaplama.Name = "hacimHesaplama";
            this.hacimHesaplama.Size = new System.Drawing.Size(100, 36);
            this.hacimHesaplama.TabIndex = 8;
            this.hacimHesaplama.Text = "Hacim Hesaplama";
            this.hacimHesaplama.UseVisualStyleBackColor = false;
            this.hacimHesaplama.Click += new System.EventHandler(this.hacimHesaplama_Click);
            // 
            // kmmilHesaplama
            // 
            this.kmmilHesaplama.BackColor = System.Drawing.Color.LimeGreen;
            this.kmmilHesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kmmilHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kmmilHesaplama.Location = new System.Drawing.Point(23, 281);
            this.kmmilHesaplama.Name = "kmmilHesaplama";
            this.kmmilHesaplama.Size = new System.Drawing.Size(100, 36);
            this.kmmilHesaplama.TabIndex = 7;
            this.kmmilHesaplama.Text = "km - mil Hesaplama";
            this.kmmilHesaplama.UseVisualStyleBackColor = false;
            this.kmmilHesaplama.Click += new System.EventHandler(this.kmmilHesaplama_Click);
            // 
            // cmincdönüşümü
            // 
            this.cmincdönüşümü.BackColor = System.Drawing.Color.SpringGreen;
            this.cmincdönüşümü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmincdönüşümü.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmincdönüşümü.Location = new System.Drawing.Point(23, 235);
            this.cmincdönüşümü.Name = "cmincdönüşümü";
            this.cmincdönüşümü.Size = new System.Drawing.Size(100, 36);
            this.cmincdönüşümü.TabIndex = 6;
            this.cmincdönüşümü.Text = "cm -inç Hesaplama";
            this.cmincdönüşümü.UseVisualStyleBackColor = false;
            this.cmincdönüşümü.Click += new System.EventHandler(this.cmincdönüşümü_Click);
            // 
            // EbobEkokHesaplama
            // 
            this.EbobEkokHesaplama.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.EbobEkokHesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EbobEkokHesaplama.Location = new System.Drawing.Point(23, 189);
            this.EbobEkokHesaplama.Name = "EbobEkokHesaplama";
            this.EbobEkokHesaplama.Size = new System.Drawing.Size(100, 36);
            this.EbobEkokHesaplama.TabIndex = 5;
            this.EbobEkokHesaplama.Text = "EBOB EKOK hesaplama";
            this.EbobEkokHesaplama.UseVisualStyleBackColor = false;
            this.EbobEkokHesaplama.Click += new System.EventHandler(this.EbobEkokHesaplama_Click);
            // 
            // asalçarpanhesaplama
            // 
            this.asalçarpanhesaplama.BackColor = System.Drawing.Color.Aqua;
            this.asalçarpanhesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asalçarpanhesaplama.Location = new System.Drawing.Point(23, 143);
            this.asalçarpanhesaplama.Name = "asalçarpanhesaplama";
            this.asalçarpanhesaplama.Size = new System.Drawing.Size(100, 36);
            this.asalçarpanhesaplama.TabIndex = 4;
            this.asalçarpanhesaplama.Text = "Asal Çarpan Hesaplama";
            this.asalçarpanhesaplama.UseVisualStyleBackColor = false;
            this.asalçarpanhesaplama.Click += new System.EventHandler(this.asalçarpanhesaplama_Click);
            // 
            // desihesaplama
            // 
            this.desihesaplama.BackColor = System.Drawing.Color.LightSeaGreen;
            this.desihesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desihesaplama.Location = new System.Drawing.Point(23, 97);
            this.desihesaplama.Name = "desihesaplama";
            this.desihesaplama.Size = new System.Drawing.Size(100, 36);
            this.desihesaplama.TabIndex = 2;
            this.desihesaplama.Text = "Desi Hesaplama";
            this.desihesaplama.UseVisualStyleBackColor = false;
            this.desihesaplama.Click += new System.EventHandler(this.desihesaplama_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(157, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 428);
            this.panel3.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(673, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button yagoranıhesaplama;
        private System.Windows.Forms.Button sayıtabanDönüşümüHesaplama;
        private System.Windows.Forms.Button standartsapma;
        private System.Windows.Forms.Button hacimHesaplama;
        private System.Windows.Forms.Button kmmilHesaplama;
        private System.Windows.Forms.Button cmincdönüşümü;
        private System.Windows.Forms.Button EbobEkokHesaplama;
        private System.Windows.Forms.Button asalçarpanhesaplama;
        private System.Windows.Forms.Button alanhesaplama;
        private System.Windows.Forms.Button desihesaplama;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button uygulamakapat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button lbskgHesaplama;
    }
}

