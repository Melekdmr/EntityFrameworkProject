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
	public partial class FrmGriris : Form
	{
		public FrmGriris()
		{
			InitializeComponent();
		}

		private void FrmGriris_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DbEntityUrunEntities db = new DbEntityUrunEntities();
			var sorgu = from x in db.TBLADMIN
						where x.KULLANICI == textBox1.Text &&
		             	x.SIFRE == textBox2.Text
						select x;
			if (sorgu.Any()) //eğer sorgu  geriye bir şey döndürüyorsa
			{
				FrmAnaForm fr = new FrmAnaForm();
				fr.Show();
				this.Hide();

			}
			else
			{
				MessageBox.Show("Hatalı Giriş Yaptınız!");
			}
		}
	}
}
