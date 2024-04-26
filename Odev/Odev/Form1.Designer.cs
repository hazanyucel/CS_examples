namespace Odev
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
            this.karekok = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.mutlak = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cps = new System.Windows.Forms.Button();
            this.gerial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.çiz = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // karekok
            // 
            this.karekok.BackColor = System.Drawing.Color.RosyBrown;
            this.karekok.Location = new System.Drawing.Point(155, 118);
            this.karekok.Name = "karekok";
            this.karekok.Size = new System.Drawing.Size(75, 41);
            this.karekok.TabIndex = 0;
            this.karekok.Text = "karekök";
            this.karekok.UseVisualStyleBackColor = false;
            this.karekok.Click += new System.EventHandler(this.karekok_Click);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.RosyBrown;
            this.max.Location = new System.Drawing.Point(260, 118);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 41);
            this.max.TabIndex = 1;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // mutlak
            // 
            this.mutlak.BackColor = System.Drawing.Color.RosyBrown;
            this.mutlak.Location = new System.Drawing.Point(54, 118);
            this.mutlak.Name = "mutlak";
            this.mutlak.Size = new System.Drawing.Size(75, 41);
            this.mutlak.TabIndex = 2;
            this.mutlak.Text = "mutlak";
            this.mutlak.UseVisualStyleBackColor = false;
            this.mutlak.Click += new System.EventHandler(this.mutlak_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.RosyBrown;
            this.sin.Location = new System.Drawing.Point(54, 165);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 39);
            this.sin.TabIndex = 3;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cps
            // 
            this.cps.BackColor = System.Drawing.Color.RosyBrown;
            this.cps.Location = new System.Drawing.Point(155, 165);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(75, 39);
            this.cps.TabIndex = 4;
            this.cps.Text = "cos";
            this.cps.UseVisualStyleBackColor = false;
            this.cps.Click += new System.EventHandler(this.cps_Click);
            // 
            // gerial
            // 
            this.gerial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gerial.Location = new System.Drawing.Point(260, 207);
            this.gerial.Name = "gerial";
            this.gerial.Size = new System.Drawing.Size(75, 33);
            this.gerial.TabIndex = 5;
            this.gerial.Text = "Geri Al";
            this.gerial.UseVisualStyleBackColor = false;
            this.gerial.Click += new System.EventHandler(this.gerial_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "cos";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "sin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // çiz
            // 
            this.çiz.BackColor = System.Drawing.Color.DarkKhaki;
            this.çiz.Location = new System.Drawing.Point(149, 70);
            this.çiz.Name = "çiz";
            this.çiz.Size = new System.Drawing.Size(93, 23);
            this.çiz.TabIndex = 10;
            this.çiz.Text = "çiz";
            this.çiz.UseVisualStyleBackColor = false;
            this.çiz.Click += new System.EventHandler(this.çiz_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "bitiş";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Khaki;
            this.textBox3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(54, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 39);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(257, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "*a,b şeklinde giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.çiz);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(54, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÇİZİM";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 122);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(392, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.gerial);
            this.Controls.Add(this.cps);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.mutlak);
            this.Controls.Add(this.max);
            this.Controls.Add(this.karekok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button karekok;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button mutlak;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cps;
        private System.Windows.Forms.Button gerial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button çiz;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

