namespace HastaneProjesi
{
    partial class FrmÜyeKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtüyead = new System.Windows.Forms.TextBox();
            this.txtüyesoyad = new System.Windows.Forms.TextBox();
            this.MskdKimlikno = new System.Windows.Forms.MaskedTextBox();
            this.MskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtÜyeSifre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(149, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(104, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(132, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(100, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cinsiyet :";
            // 
            // txtüyead
            // 
            this.txtüyead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtüyead.Location = new System.Drawing.Point(222, 92);
            this.txtüyead.Name = "txtüyead";
            this.txtüyead.Size = new System.Drawing.Size(188, 31);
            this.txtüyead.TabIndex = 1;
            // 
            // txtüyesoyad
            // 
            this.txtüyesoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtüyesoyad.Location = new System.Drawing.Point(222, 137);
            this.txtüyesoyad.Name = "txtüyesoyad";
            this.txtüyesoyad.Size = new System.Drawing.Size(188, 31);
            this.txtüyesoyad.TabIndex = 2;
            // 
            // MskdKimlikno
            // 
            this.MskdKimlikno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskdKimlikno.Location = new System.Drawing.Point(222, 193);
            this.MskdKimlikno.Mask = "00000000000";
            this.MskdKimlikno.Name = "MskdKimlikno";
            this.MskdKimlikno.Size = new System.Drawing.Size(188, 31);
            this.MskdKimlikno.TabIndex = 3;
            this.MskdKimlikno.ValidatingType = typeof(int);
            // 
            // MskdTelefon
            // 
            this.MskdTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskdTelefon.Location = new System.Drawing.Point(222, 249);
            this.MskdTelefon.Mask = "(999) 000-0000";
            this.MskdTelefon.Name = "MskdTelefon";
            this.MskdTelefon.Size = new System.Drawing.Size(188, 31);
            this.MskdTelefon.TabIndex = 4;
            // 
            // txtÜyeSifre
            // 
            this.txtÜyeSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeSifre.Location = new System.Drawing.Point(222, 299);
            this.txtÜyeSifre.Name = "txtÜyeSifre";
            this.txtÜyeSifre.Size = new System.Drawing.Size(188, 31);
            this.txtÜyeSifre.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(222, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnKayitYap.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayitYap.Location = new System.Drawing.Point(222, 438);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(188, 42);
            this.BtnKayitYap.TabIndex = 4;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmÜyeKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(522, 598);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MskdTelefon);
            this.Controls.Add(this.MskdKimlikno);
            this.Controls.Add(this.txtÜyeSifre);
            this.Controls.Add(this.txtüyesoyad);
            this.Controls.Add(this.txtüyead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmÜyeKayit";
            this.Text = "FrmÜyeKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtüyead;
        private System.Windows.Forms.TextBox txtüyesoyad;
        private System.Windows.Forms.MaskedTextBox MskdKimlikno;
        private System.Windows.Forms.MaskedTextBox MskdTelefon;
        private System.Windows.Forms.TextBox txtÜyeSifre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}