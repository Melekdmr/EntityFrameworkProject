using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
	public partial class Frmistatistik : Form
	{
		public Frmistatistik()
		{
			InitializeComponent();
		}
		DbEntityUrunEntities db = new DbEntityUrunEntities();
		private void Frmistatistik_Load(object sender, EventArgs e)
		{
			label2.Text = db.TBLKATEGORI.Count().ToString();
			label3.Text = db.TBLURUN.Count().ToString();
			label5.Text = db.TBLMUSTERİ.Count(x => x.DURUM == true).ToString();
			label7.Text = db.TBLMUSTERİ.Count(x => x.DURUM == false).ToString();
			label13.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
			label21.Text = db.TBLSATIS.Sum(y => y.FİYAT).ToString() + "TL";
			label11.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();// burada tolist kullanamayız.
			label9.Text = (from y in db.TBLURUN orderby y.FIYAT ascending select y.URUNAD).FirstOrDefault();  //çünkü bütün değerleri getirir.
			label15.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
			label17.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
			label23.Text = (from z in db.TBLMUSTERİ select z.SEHIR).Distinct().Count().ToString();
			label19.Text = db.MARKAGETIR().FirstOrDefault();

		}
	}
}
