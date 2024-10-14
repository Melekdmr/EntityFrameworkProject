using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
	public partial class FrmUrun : Form
	{
		public FrmUrun()
		{
			InitializeComponent();
		}
		DbEntityUrunEntities db = new DbEntityUrunEntities();
		private void button1_Click(object sender, EventArgs e)
		{  //listeleme
			dataGridView1.DataSource = (from x in db.TBLURUN
										select new
										{
											x.URUNID,
											x.URUNAD,
											x.MARKA,
											x.STOK,
											x.FIYAT,
											x.TBLKATEGORI.AD,
											x.DURUM
										}).ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{ //ekleme
			TBLURUN t = new TBLURUN();
			t.URUNAD = txtAdı.Text;
			t.MARKA = txtMarka.Text;
			t.STOK = short.Parse(txtStok.Text);
			t.KATEGORI = int.Parse(cmbKategori.SelectedValue.ToString());
			t.FIYAT = decimal.Parse(txtFiyat.Text);
			t.DURUM = true;
			db.TBLURUN.Add(t);
			db.SaveChanges();
			MessageBox.Show("Ürün Siteme EKlenmiştir.");

		}

		private void button3_Click(object sender, EventArgs e)
		{
			//SİLME
			int x = Convert.ToInt32(txtID.Text);
			var urun = db.TBLURUN.Find(x);
			db.TBLURUN.Remove(urun);
			db.SaveChanges();
			MessageBox.Show("Ürün Sİlinmiştir");

		}

		private void button4_Click(object sender, EventArgs e)
		{   //güncelleme
			int x = Convert.ToInt32(txtID.Text);
			var urun = db.TBLURUN.Find(x);
			urun.URUNAD = txtAdı.Text;
			urun.MARKA = txtMarka.Text;
			urun.STOK = short.Parse(txtStok.Text);
			db.SaveChanges();
			MessageBox.Show("Ürün Güncellenmiştir.");


		}

		private void FrmUrun_Load(object sender, EventArgs e)
		{
			//comboboxtan seçilen kategorinin id değerinin atanması
			var kategoriler = (from x in db.TBLKATEGORI
							   select new
							   {
								   x.ID,
								   x.AD
							   }
							   ).ToList();
			cmbKategori.ValueMember = "ID";  //Arka planda çalışan
			cmbKategori.DisplayMember = "AD"; //kullanıcıya (bize) görünen
			cmbKategori.DataSource = kategoriler;
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}
	}
}
