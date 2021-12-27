namespace parkotomasyonn
{
    partial class frmAraçOtoparkÇıkış
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
            this.components = new System.ComponentModel.Container();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeri = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.comboBoxParkYeri = new System.Windows.Forms.ComboBox();
            this.lblToplamTutarr = new System.Windows.Forms.Label();
            this.lblSüree = new System.Windows.Forms.Label();
            this.lblÇıkışTarihii = new System.Windows.Forms.Label();
            this.lblGelişTarihii = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lblÇıkışTarihi = new System.Windows.Forms.Label();
            this.lblGelişTarihi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPlaka
            // 
            this.comboPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(119, 48);
            this.comboPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(117, 25);
            this.comboPlaka.TabIndex = 0;
            this.comboPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPlaka);
            this.groupBox2.Controls.Add(this.comboPlaka);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxParkYeri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxSeri);
            this.groupBox2.Controls.Add(this.textBoxMarka);
            this.groupBox2.Controls.Add(this.textBoxAd);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(274, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç ve Park Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPlaka.Location = new System.Drawing.Point(119, 332);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(117, 23);
            this.textBoxPlaka.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 333);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Plaka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 277);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Park Yeri";
            // 
            // textBoxSeri
            // 
            this.textBoxSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSeri.Location = new System.Drawing.Point(119, 276);
            this.textBoxSeri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSeri.Name = "textBoxSeri";
            this.textBoxSeri.Size = new System.Drawing.Size(117, 23);
            this.textBoxSeri.TabIndex = 6;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMarka.Location = new System.Drawing.Point(119, 220);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(117, 23);
            this.textBoxMarka.TabIndex = 5;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(119, 164);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(117, 23);
            this.textBoxAd.TabIndex = 3;
            this.textBoxAd.TextChanged += new System.EventHandler(this.textBoxAd_TextChanged);
            // 
            // comboBoxParkYeri
            // 
            this.comboBoxParkYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxParkYeri.FormattingEnabled = true;
            this.comboBoxParkYeri.Location = new System.Drawing.Point(119, 106);
            this.comboBoxParkYeri.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParkYeri.Name = "comboBoxParkYeri";
            this.comboBoxParkYeri.Size = new System.Drawing.Size(117, 25);
            this.comboBoxParkYeri.TabIndex = 0;
            this.comboBoxParkYeri.SelectedIndexChanged += new System.EventHandler(this.comboBoxParkYeri_SelectedIndexChanged);
            // 
            // lblToplamTutarr
            // 
            this.lblToplamTutarr.AutoSize = true;
            this.lblToplamTutarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblToplamTutarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamTutarr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamTutarr.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblToplamTutarr.Location = new System.Drawing.Point(250, 292);
            this.lblToplamTutarr.Name = "lblToplamTutarr";
            this.lblToplamTutarr.Size = new System.Drawing.Size(11, 13);
            this.lblToplamTutarr.TabIndex = 11;
            this.lblToplamTutarr.Text = " ";
            // 
            // lblSüree
            // 
            this.lblSüree.AutoSize = true;
            this.lblSüree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSüree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSüree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSüree.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSüree.Location = new System.Drawing.Point(250, 268);
            this.lblSüree.Name = "lblSüree";
            this.lblSüree.Size = new System.Drawing.Size(11, 13);
            this.lblSüree.TabIndex = 10;
            this.lblSüree.Text = " ";
            // 
            // lblÇıkışTarihii
            // 
            this.lblÇıkışTarihii.AutoSize = true;
            this.lblÇıkışTarihii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblÇıkışTarihii.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÇıkışTarihii.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblÇıkışTarihii.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblÇıkışTarihii.Location = new System.Drawing.Point(250, 238);
            this.lblÇıkışTarihii.Name = "lblÇıkışTarihii";
            this.lblÇıkışTarihii.Size = new System.Drawing.Size(11, 13);
            this.lblÇıkışTarihii.TabIndex = 9;
            this.lblÇıkışTarihii.Text = " ";
            this.lblÇıkışTarihii.Click += new System.EventHandler(this.lblÇıkışTarihii_Click);
            // 
            // lblGelişTarihii
            // 
            this.lblGelişTarihii.AutoSize = true;
            this.lblGelişTarihii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblGelişTarihii.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelişTarihii.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGelişTarihii.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblGelişTarihii.Location = new System.Drawing.Point(250, 211);
            this.lblGelişTarihii.Name = "lblGelişTarihii";
            this.lblGelişTarihii.Size = new System.Drawing.Size(11, 13);
            this.lblGelişTarihii.TabIndex = 8;
            this.lblGelişTarihii.Text = " ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.White;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Aqua;
            this.lblToplamTutar.Location = new System.Drawing.Point(249, 285);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 20);
            this.lblToplamTutar.TabIndex = 7;
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.BackColor = System.Drawing.Color.White;
            this.lblSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSüre.ForeColor = System.Drawing.Color.Aqua;
            this.lblSüre.Location = new System.Drawing.Point(249, 259);
            this.lblSüre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(0, 20);
            this.lblSüre.TabIndex = 6;
            // 
            // lblÇıkışTarihi
            // 
            this.lblÇıkışTarihi.AutoSize = true;
            this.lblÇıkışTarihi.BackColor = System.Drawing.Color.White;
            this.lblÇıkışTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇıkışTarihi.ForeColor = System.Drawing.Color.Aqua;
            this.lblÇıkışTarihi.Location = new System.Drawing.Point(249, 233);
            this.lblÇıkışTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblÇıkışTarihi.Name = "lblÇıkışTarihi";
            this.lblÇıkışTarihi.Size = new System.Drawing.Size(0, 20);
            this.lblÇıkışTarihi.TabIndex = 5;
            // 
            // lblGelişTarihi
            // 
            this.lblGelişTarihi.AutoSize = true;
            this.lblGelişTarihi.BackColor = System.Drawing.Color.White;
            this.lblGelişTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelişTarihi.ForeColor = System.Drawing.Color.Aqua;
            this.lblGelişTarihi.Location = new System.Drawing.Point(249, 204);
            this.lblGelişTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGelişTarihi.Name = "lblGelişTarihi";
            this.lblGelişTarihi.Size = new System.Drawing.Size(0, 20);
            this.lblGelişTarihi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(238, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Araç Çıkışı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(378, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::parkotomasyonn.Properties.Resources.park_cikis1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Plaka Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(177, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // frmAraçOtoparkÇıkış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(739, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamTutarr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSüree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblÇıkışTarihii);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblGelişTarihii);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblÇıkışTarihi);
            this.Controls.Add(this.lblGelişTarihi);
            this.Controls.Add(this.lblSüre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAraçOtoparkÇıkış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmAraçOtoparkÇıkış_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboPlaka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeri;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.ComboBox comboBoxParkYeri;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label lblÇıkışTarihi;
        private System.Windows.Forms.Label lblGelişTarihi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGelişTarihii;
        private System.Windows.Forms.Label lblÇıkışTarihii;
        private System.Windows.Forms.Label lblSüree;
        private System.Windows.Forms.Label lblToplamTutarr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}