﻿using System;
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
	public partial class FrmAnaForm : Form
	{
		public FrmAnaForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 fr = new Form1();
			fr.Show();
		}

		private void FrmAnaForm_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmUrun fr = new FrmUrun();
			fr.Show();

		}
	}
}
