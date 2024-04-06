namespace Ortak_Kod_Yazma_Uygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.malzeme = new System.Windows.Forms.TextBox();
            this.birim = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.bayi = new System.Windows.Forms.CheckBox();
            this.kdv = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gida = new System.Windows.Forms.RadioButton();
            this.kirtasiye = new System.Windows.Forms.RadioButton();
            this.beyazesya = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MALZEME ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BİRİM FİYATI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADET :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "KDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "TUTAR";
            // 
            // malzeme
            // 
            this.malzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzeme.Location = new System.Drawing.Point(201, 15);
            this.malzeme.Name = "malzeme";
            this.malzeme.Size = new System.Drawing.Size(186, 35);
            this.malzeme.TabIndex = 5;
            // 
            // birim
            // 
            this.birim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birim.Location = new System.Drawing.Point(201, 56);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(186, 35);
            this.birim.TabIndex = 5;
            this.birim.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // adet
            // 
            this.adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adet.Location = new System.Drawing.Point(201, 102);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(186, 35);
            this.adet.TabIndex = 5;
            this.adet.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // bayi
            // 
            this.bayi.AutoSize = true;
            this.bayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bayi.Location = new System.Drawing.Point(201, 186);
            this.bayi.Name = "bayi";
            this.bayi.Size = new System.Drawing.Size(85, 33);
            this.bayi.TabIndex = 6;
            this.bayi.Text = "BAYİ";
            this.bayi.UseVisualStyleBackColor = true;
            this.bayi.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // kdv
            // 
            this.kdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdv.Location = new System.Drawing.Point(201, 265);
            this.kdv.Name = "kdv";
            this.kdv.Size = new System.Drawing.Size(186, 35);
            this.kdv.TabIndex = 7;
            // 
            // tutar
            // 
            this.tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutar.Location = new System.Drawing.Point(201, 314);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(186, 35);
            this.tutar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gida);
            this.groupBox1.Controls.Add(this.kirtasiye);
            this.groupBox1.Controls.Add(this.beyazesya);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(441, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEME CİNSİ";
            // 
            // gida
            // 
            this.gida.AutoSize = true;
            this.gida.Location = new System.Drawing.Point(6, 121);
            this.gida.Name = "gida";
            this.gida.Size = new System.Drawing.Size(87, 33);
            this.gida.TabIndex = 2;
            this.gida.TabStop = true;
            this.gida.Text = "GIDA";
            this.gida.UseVisualStyleBackColor = true;
            this.gida.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // kirtasiye
            // 
            this.kirtasiye.AutoSize = true;
            this.kirtasiye.Location = new System.Drawing.Point(6, 76);
            this.kirtasiye.Name = "kirtasiye";
            this.kirtasiye.Size = new System.Drawing.Size(155, 33);
            this.kirtasiye.TabIndex = 1;
            this.kirtasiye.TabStop = true;
            this.kirtasiye.Text = "KIRTASİYE";
            this.kirtasiye.UseVisualStyleBackColor = true;
            this.kirtasiye.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // beyazesya
            // 
            this.beyazesya.AutoSize = true;
            this.beyazesya.Location = new System.Drawing.Point(6, 37);
            this.beyazesya.Name = "beyazesya";
            this.beyazesya.Size = new System.Drawing.Size(177, 33);
            this.beyazesya.TabIndex = 0;
            this.beyazesya.TabStop = true;
            this.beyazesya.Text = "BEYAZ EŞYA";
            this.beyazesya.UseVisualStyleBackColor = true;
            this.beyazesya.TextChanged += new System.EventHandler(this.birim_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.kdv);
            this.Controls.Add(this.bayi);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.malzeme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox malzeme;
        private System.Windows.Forms.TextBox birim;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.CheckBox bayi;
        private System.Windows.Forms.TextBox kdv;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gida;
        private System.Windows.Forms.RadioButton kirtasiye;
        private System.Windows.Forms.RadioButton beyazesya;
    }
}

