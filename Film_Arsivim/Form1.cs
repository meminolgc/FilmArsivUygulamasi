using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivim
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True;Encrypt=False");

		void filmler()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from TBLFILMLER", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			 filmler();
		}
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLFILMLER (ad, KATEGORI, LINK) values (@P1, @P2, @P3)", baglanti);
			komut.Parameters.AddWithValue("@P1", TxtFilmAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtKategori.Text);
			komut.Parameters.AddWithValue("@P3", TxtLink.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Film listenize eklendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			filmler();
		}
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

			webBrowser2.Navigate(link);
		}
		private void BtnHakkımızda_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bu proje Emin Olgac tarafından 29 Şubat 2024 tarihinde kodlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		private void BtnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void BtnRenkDegis_Click(object sender, EventArgs e)
		{
			//renk değiştir butonuna basınca arkaplanda random renk versin 
			//bir dizi oluştur ve 10 tane renk ata 
			//random sınıfıyla diziden rastgele renk seçtir
			Color[] renkler = {
			Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue,
			Color.Indigo, Color.Violet, Color.Pink, Color.Brown, Color.Gray
			};
			Random random = new Random();
			Color randomRenk = renkler[random.Next(renkler.Length)];
			this.BackColor = randomRenk;
		}
		private void BtnTamEkran_Click(object sender, EventArgs e)
		{
			//tam ekran butonuna tıklandığı zaman web browser'ı yeni forma yönlendir.
			//documentparentcontainer? özelliği true olduğu için bu formdaki aktif film o forma taşınabilir.
			MovieScreen movieScreen = new MovieScreen();
			movieScreen.Show();
			//burası eksik
		}
	


	}
}
