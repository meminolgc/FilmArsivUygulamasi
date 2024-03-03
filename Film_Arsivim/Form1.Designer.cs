namespace Film_Arsivim
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.BtnCikis = new System.Windows.Forms.Button();
			this.BtnRenkDegis = new System.Windows.Forms.Button();
			this.BtnHakkımızda = new System.Windows.Forms.Button();
			this.BtnTamEkran = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtLink = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtKategori = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtFilmAd = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.webBrowser2 = new System.Windows.Forms.WebBrowser();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1060, 86);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(154, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(512, 61);
			this.label4.TabIndex = 16;
			this.label4.Text = "Sinema Koltuk Yazılım ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(103, 82);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.BtnKaydet);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.TxtLink);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TxtKategori);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.TxtFilmAd);
			this.groupBox1.Location = new System.Drawing.Point(12, 92);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(181, 391);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Yeni Film ";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.BtnCikis);
			this.groupBox4.Controls.Add(this.BtnRenkDegis);
			this.groupBox4.Controls.Add(this.BtnHakkımızda);
			this.groupBox4.Controls.Add(this.BtnTamEkran);
			this.groupBox4.Location = new System.Drawing.Point(6, 165);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(169, 220);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "İşlemler";
			// 
			// BtnCikis
			// 
			this.BtnCikis.Location = new System.Drawing.Point(17, 123);
			this.BtnCikis.Name = "BtnCikis";
			this.BtnCikis.Size = new System.Drawing.Size(135, 23);
			this.BtnCikis.TabIndex = 14;
			this.BtnCikis.Text = "Çıkış";
			this.BtnCikis.UseVisualStyleBackColor = true;
			this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
			// 
			// BtnRenkDegis
			// 
			this.BtnRenkDegis.Location = new System.Drawing.Point(17, 94);
			this.BtnRenkDegis.Name = "BtnRenkDegis";
			this.BtnRenkDegis.Size = new System.Drawing.Size(135, 23);
			this.BtnRenkDegis.TabIndex = 13;
			this.BtnRenkDegis.Text = "Renk Değiştir";
			this.BtnRenkDegis.UseVisualStyleBackColor = true;
			this.BtnRenkDegis.Click += new System.EventHandler(this.BtnRenkDegis_Click);
			// 
			// BtnHakkımızda
			// 
			this.BtnHakkımızda.Location = new System.Drawing.Point(17, 65);
			this.BtnHakkımızda.Name = "BtnHakkımızda";
			this.BtnHakkımızda.Size = new System.Drawing.Size(135, 23);
			this.BtnHakkımızda.TabIndex = 12;
			this.BtnHakkımızda.Text = "Hakkımızda";
			this.BtnHakkımızda.UseVisualStyleBackColor = true;
			this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
			// 
			// BtnTamEkran
			// 
			this.BtnTamEkran.Location = new System.Drawing.Point(17, 36);
			this.BtnTamEkran.Name = "BtnTamEkran";
			this.BtnTamEkran.Size = new System.Drawing.Size(135, 23);
			this.BtnTamEkran.TabIndex = 11;
			this.BtnTamEkran.Text = "Tam Ekran";
			this.BtnTamEkran.UseVisualStyleBackColor = true;
			this.BtnTamEkran.Click += new System.EventHandler(this.BtnTamEkran_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(100, 101);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
			this.BtnKaydet.TabIndex = 10;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Link:";
			// 
			// TxtLink
			// 
			this.TxtLink.Location = new System.Drawing.Point(56, 75);
			this.TxtLink.Name = "TxtLink";
			this.TxtLink.Size = new System.Drawing.Size(119, 20);
			this.TxtLink.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kategori:";
			// 
			// TxtKategori
			// 
			this.TxtKategori.Location = new System.Drawing.Point(56, 49);
			this.TxtKategori.Name = "TxtKategori";
			this.TxtKategori.Size = new System.Drawing.Size(119, 20);
			this.TxtKategori.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Film Ad:";
			// 
			// TxtFilmAd
			// 
			this.TxtFilmAd.Location = new System.Drawing.Point(56, 23);
			this.TxtFilmAd.Name = "TxtFilmAd";
			this.TxtFilmAd.Size = new System.Drawing.Size(119, 20);
			this.TxtFilmAd.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.webBrowser2);
			this.groupBox2.Controls.Add(this.webBrowser1);
			this.groupBox2.Location = new System.Drawing.Point(389, 92);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(665, 391);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ekran";
			// 
			// webBrowser2
			// 
			this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser2.Location = new System.Drawing.Point(3, 16);
			this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new System.Drawing.Size(659, 372);
			this.webBrowser2.TabIndex = 1;
			//this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
			//this.webBrowser2.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser2_Navigating);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 16);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(659, 372);
			this.webBrowser1.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(199, 92);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 391);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "FilmListesi";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(178, 372);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1066, 495);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button BtnCikis;
		private System.Windows.Forms.Button BtnRenkDegis;
		private System.Windows.Forms.Button BtnHakkımızda;
		private System.Windows.Forms.Button BtnTamEkran;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtLink;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtKategori;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtFilmAd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.WebBrowser webBrowser2;
	}
}

