namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.txt_fracsayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_expsayi = new System.Windows.Forms.TextBox();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.txtsayi_binary = new System.Windows.Forms.TextBox();
            this.txt_EXP = new System.Windows.Forms.TextBox();
            this.txt_FRAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sign = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Hex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SayiKusur = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt10luk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı:";
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(41, 30);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(68, 20);
            this.txt_sayi.TabIndex = 2;
            this.txt_sayi.TextChanged += new System.EventHandler(this.sayi_TextChanged);
            // 
            // txt_fracsayi
            // 
            this.txt_fracsayi.Location = new System.Drawing.Point(499, 34);
            this.txt_fracsayi.Name = "txt_fracsayi";
            this.txt_fracsayi.Size = new System.Drawing.Size(68, 20);
            this.txt_fracsayi.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Frac sayısı:";
            // 
            // txt_expsayi
            // 
            this.txt_expsayi.Location = new System.Drawing.Point(499, 6);
            this.txt_expsayi.Name = "txt_expsayi";
            this.txt_expsayi.Size = new System.Drawing.Size(68, 20);
            this.txt_expsayi.TabIndex = 9;
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Location = new System.Drawing.Point(437, 9);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(56, 13);
            this.lbl_exp.TabIndex = 8;
            this.lbl_exp.Text = "Exp sayısı:";
            // 
            // txtsayi_binary
            // 
            this.txtsayi_binary.Location = new System.Drawing.Point(202, 30);
            this.txtsayi_binary.Name = "txtsayi_binary";
            this.txtsayi_binary.Size = new System.Drawing.Size(288, 20);
            this.txtsayi_binary.TabIndex = 13;
            // 
            // txt_EXP
            // 
            this.txt_EXP.Location = new System.Drawing.Point(109, 19);
            this.txt_EXP.Name = "txt_EXP";
            this.txt_EXP.Size = new System.Drawing.Size(139, 20);
            this.txt_EXP.TabIndex = 14;
            // 
            // txt_FRAC
            // 
            this.txt_FRAC.Location = new System.Drawing.Point(285, 21);
            this.txt_FRAC.Name = "txt_FRAC";
            this.txt_FRAC.Size = new System.Drawing.Size(209, 20);
            this.txt_FRAC.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Exp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Frac:";
            // 
            // txt_sign
            // 
            this.txt_sign.Location = new System.Drawing.Point(43, 19);
            this.txt_sign.Name = "txt_sign";
            this.txt_sign.Size = new System.Drawing.Size(32, 20);
            this.txt_sign.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sign:";
            // 
            // txt_Hex
            // 
            this.txt_Hex.Location = new System.Drawing.Point(115, 53);
            this.txt_Hex.Name = "txt_Hex";
            this.txt_Hex.Size = new System.Drawing.Size(139, 20);
            this.txt_Hex.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "HEX:";
            // 
            // txt_SayiKusur
            // 
            this.txt_SayiKusur.Location = new System.Drawing.Point(123, 30);
            this.txt_SayiKusur.Name = "txt_SayiKusur";
            this.txt_SayiKusur.Size = new System.Drawing.Size(68, 20);
            this.txt_SayiKusur.TabIndex = 22;
            this.txt_SayiKusur.TextChanged += new System.EventHandler(this.txt_SayiKusur_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 24;
            this.button3.Text = "sonsuz uret";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 25;
            this.button4.Text = "NaN uret";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 37);
            this.button5.TabIndex = 26;
            this.button5.Text = "Denormalize Uret";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt10luk
            // 
            this.txt10luk.Location = new System.Drawing.Point(308, 31);
            this.txt10luk.Name = "txt10luk";
            this.txt10luk.Size = new System.Drawing.Size(72, 20);
            this.txt10luk.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "10\'luk";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(270, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Cevapla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "10.0011";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Çarpım Sonucu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Üslerin Toplamı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsayi_binary);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_sayi);
            this.groupBox2.Controls.Add(this.txt_SayiKusur);
            this.groupBox2.Location = new System.Drawing.Point(30, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 80);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soru Tipi 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt10luk);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(30, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 80);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru Tipi 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(547, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 80);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soru Tipi 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_FRAC);
            this.groupBox4.Controls.Add(this.txt_EXP);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_sign);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_Hex);
            this.groupBox4.Location = new System.Drawing.Point(258, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 100);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HESAPLAYICI";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Location = new System.Drawing.Point(547, 199);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(500, 80);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Soru Tipi 4";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(335, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(70, 20);
            this.textBox8.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "14(x300,x600,4)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "D(Rb, Ri,S)";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(335, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(70, 20);
            this.textBox12.TabIndex = 31;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(174, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(68, 20);
            this.textBox10.TabIndex = 29;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(100, 45);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(68, 20);
            this.textBox9.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(248, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(174, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "14 - 300 - 600 - 4 gibi doldur";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(443, 26);
            this.label13.TabIndex = 42;
            this.label13.Text = "-5 | 4375 gibi doldur, 4375\'in bit gösterimi yapılır ama hesaplayıcıda frac hesab" +
    "ına uğraşılmıyor.\r\nZaten sorularda bariz öne çıktığından anlamsız bir çabaydı ko" +
    "dunu yazmak\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(585, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(302, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Çarpımı yap, sonucunu ve üs toplamını yaz cevapla tuşuna bas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 430);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "HEX hesaplamak istiyosan butona bas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 514);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_fracsayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_expsayi);
            this.Controls.Add(this.lbl_exp);
            this.Name = "Form1";
            this.Text = "Bilgisayar Mimarisi Float Çözücü";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.TextBox txt_fracsayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_expsayi;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.TextBox txtsayi_binary;
        private System.Windows.Forms.TextBox txt_EXP;
        private System.Windows.Forms.TextBox txt_FRAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Hex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SayiKusur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt10luk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

