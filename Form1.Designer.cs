namespace CanSıkıntısı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAllis = new System.Windows.Forms.TextBox();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.txtKar = new System.Windows.Forms.TextBox();
            this.kar2 = new System.Windows.Forms.RadioButton();
            this.kar3 = new System.Windows.Forms.RadioButton();
            this.kar4 = new System.Windows.Forms.RadioButton();
            this.kar5 = new System.Windows.Forms.RadioButton();
            this.kar6 = new System.Windows.Forms.RadioButton();
            this.kar7 = new System.Windows.Forms.RadioButton();
            this.kar9 = new System.Windows.Forms.RadioButton();
            this.kar8 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borsa Günlük AlışVeriş Kar Hesaplama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alış Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satış Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(94, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kar :";
            // 
            // txtAllis
            // 
            this.txtAllis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllis.Location = new System.Drawing.Point(162, 150);
            this.txtAllis.Name = "txtAllis";
            this.txtAllis.Size = new System.Drawing.Size(135, 29);
            this.txtAllis.TabIndex = 4;
            // 
            // txtSatis
            // 
            this.txtSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatis.Location = new System.Drawing.Point(162, 191);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(135, 29);
            this.txtSatis.TabIndex = 5;
            // 
            // txtKar
            // 
            this.txtKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKar.Location = new System.Drawing.Point(162, 306);
            this.txtKar.Name = "txtKar";
            this.txtKar.Size = new System.Drawing.Size(135, 29);
            this.txtKar.TabIndex = 6;
            // 
            // kar2
            // 
            this.kar2.AutoSize = true;
            this.kar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar2.Location = new System.Drawing.Point(17, 231);
            this.kar2.Name = "kar2";
            this.kar2.Size = new System.Drawing.Size(84, 24);
            this.kar2.TabIndex = 8;
            this.kar2.TabStop = true;
            this.kar2.Text = "%2 Kar";
            this.kar2.UseVisualStyleBackColor = true;
            this.kar2.Click += new System.EventHandler(this.kar2_Click);
            // 
            // kar3
            // 
            this.kar3.AutoSize = true;
            this.kar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar3.Location = new System.Drawing.Point(17, 261);
            this.kar3.Name = "kar3";
            this.kar3.Size = new System.Drawing.Size(84, 24);
            this.kar3.TabIndex = 9;
            this.kar3.TabStop = true;
            this.kar3.Text = "%3 Kar";
            this.kar3.UseVisualStyleBackColor = true;
            this.kar3.CheckedChanged += new System.EventHandler(this.kar3_CheckedChanged);
            // 
            // kar4
            // 
            this.kar4.AutoSize = true;
            this.kar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar4.Location = new System.Drawing.Point(107, 231);
            this.kar4.Name = "kar4";
            this.kar4.Size = new System.Drawing.Size(84, 24);
            this.kar4.TabIndex = 10;
            this.kar4.TabStop = true;
            this.kar4.Text = "%4 Kar";
            this.kar4.UseVisualStyleBackColor = true;
            this.kar4.CheckedChanged += new System.EventHandler(this.kar4_CheckedChanged);
            // 
            // kar5
            // 
            this.kar5.AutoSize = true;
            this.kar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar5.Location = new System.Drawing.Point(110, 261);
            this.kar5.Name = "kar5";
            this.kar5.Size = new System.Drawing.Size(84, 24);
            this.kar5.TabIndex = 11;
            this.kar5.TabStop = true;
            this.kar5.Text = "%5 Kar";
            this.kar5.UseVisualStyleBackColor = true;
            this.kar5.CheckedChanged += new System.EventHandler(this.kar5_CheckedChanged);
            // 
            // kar6
            // 
            this.kar6.AutoSize = true;
            this.kar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar6.Location = new System.Drawing.Point(197, 231);
            this.kar6.Name = "kar6";
            this.kar6.Size = new System.Drawing.Size(84, 24);
            this.kar6.TabIndex = 12;
            this.kar6.TabStop = true;
            this.kar6.Text = "%6 Kar";
            this.kar6.UseVisualStyleBackColor = true;
            this.kar6.CheckedChanged += new System.EventHandler(this.kar6_CheckedChanged);
            // 
            // kar7
            // 
            this.kar7.AutoSize = true;
            this.kar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar7.Location = new System.Drawing.Point(197, 261);
            this.kar7.Name = "kar7";
            this.kar7.Size = new System.Drawing.Size(84, 24);
            this.kar7.TabIndex = 13;
            this.kar7.TabStop = true;
            this.kar7.Text = "%7 Kar";
            this.kar7.UseVisualStyleBackColor = true;
            this.kar7.CheckedChanged += new System.EventHandler(this.kar7_CheckedChanged);
            // 
            // kar9
            // 
            this.kar9.AutoSize = true;
            this.kar9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar9.Location = new System.Drawing.Point(287, 261);
            this.kar9.Name = "kar9";
            this.kar9.Size = new System.Drawing.Size(84, 24);
            this.kar9.TabIndex = 15;
            this.kar9.TabStop = true;
            this.kar9.Text = "%9 Kar";
            this.kar9.UseVisualStyleBackColor = true;
            this.kar9.CheckedChanged += new System.EventHandler(this.kar9_CheckedChanged);
            // 
            // kar8
            // 
            this.kar8.AutoSize = true;
            this.kar8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kar8.Location = new System.Drawing.Point(287, 231);
            this.kar8.Name = "kar8";
            this.kar8.Size = new System.Drawing.Size(84, 24);
            this.kar8.TabIndex = 14;
            this.kar8.TabStop = true;
            this.kar8.Text = "%8 Kar";
            this.kar8.UseVisualStyleBackColor = true;
            this.kar8.CheckedChanged += new System.EventHandler(this.kar8_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(153, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 67);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hesapla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kar9);
            this.Controls.Add(this.kar8);
            this.Controls.Add(this.kar7);
            this.Controls.Add(this.kar6);
            this.Controls.Add(this.kar5);
            this.Controls.Add(this.kar4);
            this.Controls.Add(this.kar3);
            this.Controls.Add(this.kar2);
            this.Controls.Add(this.txtKar);
            this.Controls.Add(this.txtSatis);
            this.Controls.Add(this.txtAllis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borsa Kar Hesaplama";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAllis;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.TextBox txtKar;
        private System.Windows.Forms.RadioButton kar2;
        private System.Windows.Forms.RadioButton kar3;
        private System.Windows.Forms.RadioButton kar4;
        private System.Windows.Forms.RadioButton kar5;
        private System.Windows.Forms.RadioButton kar6;
        private System.Windows.Forms.RadioButton kar7;
        private System.Windows.Forms.RadioButton kar9;
        private System.Windows.Forms.RadioButton kar8;
        private System.Windows.Forms.Button button1;
    }
}

