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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DbEntityUrunEntities db = new DbEntityUrunEntities();
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_listele_Click(object sender, EventArgs e)
		{
			var kategoriler = db.TBLKATEGORI.ToList();
			dataGridView1.DataSource = kategoriler;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//ekleme işlemi
			TBLKATEGORI t = new TBLKATEGORI();
			t.AD = textBox2.Text;
			db.TBLKATEGORI.Add(t);
			db.SaveChanges();
			MessageBox.Show("Kategori Eklendi");
		}

		private void Btn_sil_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			var ktgr = db.TBLKATEGORI.Find(x);
			db.TBLKATEGORI.Remove(ktgr);
			db.SaveChanges();
			MessageBox.Show("Kategori Silindi");
		}

		private void btn_guncelle_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			var ktgr = db.TBLKATEGORI.Find(x);
			ktgr.AD = textBox2.Text;
			db.SaveChanges();
			MessageBox.Show("Kategori Güncellendi");
		}
	}
}
