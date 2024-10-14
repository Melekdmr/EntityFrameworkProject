namespace EntityFrameworkProject
{
	partial class FrmUrun
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
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtAdı = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMarka = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDurum = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cmbKategori = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(138, 27);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(172, 30);
			this.txtID.TabIndex = 1;
			// 
			// txtAdı
			// 
			this.txtAdı.Location = new System.Drawing.Point(138, 63);
			this.txtAdı.Name = "txtAdı";
			this.txtAdı.Size = new System.Drawing.Size(172, 30);
			this.txtAdı.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ürün Adı:";
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(138, 99);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Size = new System.Drawing.Size(172, 30);
			this.txtMarka.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Marka:";
			// 
			// txtStok
			// 
			this.txtStok.Location = new System.Drawing.Point(138, 135);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(172, 30);
			this.txtStok.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Stok:";
			// 
			// txtFiyat
			// 
			this.txtFiyat.Location = new System.Drawing.Point(138, 171);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(172, 30);
			this.txtFiyat.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(72, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fiyat:";
			// 
			// txtDurum
			// 
			this.txtDurum.Location = new System.Drawing.Point(138, 207);
			this.txtDurum.Name = "txtDurum";
			this.txtDurum.Size = new System.Drawing.Size(172, 30);
			this.txtDurum.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 25);
			this.label6.TabIndex = 10;
			this.label6.Text = "Durum:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(41, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 25);
			this.label7.TabIndex = 12;
			this.label7.Text = "Kategori:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(341, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 49);
			this.button1.TabIndex = 14;
			this.button1.Text = "Listele";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button2.Location = new System.Drawing.Point(341, 76);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 49);
			this.button2.TabIndex = 15;
			this.button2.Text = "Ekle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button3.Location = new System.Drawing.Point(341, 131);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(124, 49);
			this.button3.TabIndex = 16;
			this.button3.Text = "Sil";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button4.Location = new System.Drawing.Point(341, 186);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(124, 49);
			this.button4.TabIndex = 17;
			this.button4.Text = "Güncelle";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button5.Location = new System.Drawing.Point(341, 241);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(124, 49);
			this.button5.TabIndex = 18;
			this.button5.Text = "Temizle";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 296);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(859, 263);
			this.dataGridView1.TabIndex = 19;
			// 
			// cmbKategori
			// 
			this.cmbKategori.FormattingEnabled = true;
			this.cmbKategori.Location = new System.Drawing.Point(139, 243);
			this.cmbKategori.Name = "cmbKategori";
			this.cmbKategori.Size = new System.Drawing.Size(171, 33);
			this.cmbKategori.TabIndex = 20;
			// 
			// FrmUrun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 571);
			this.Controls.Add(this.cmbKategori);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDurum);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtFiyat);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMarka);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAdı);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmUrun";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmUrun";
			this.Load += new System.EventHandler(this.FrmUrun_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtAdı;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMarka;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDurum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cmbKategori;
	}
}