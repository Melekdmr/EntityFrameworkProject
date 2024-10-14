namespace EntityFrameworkProject
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_listele = new System.Windows.Forms.Button();
			this.btn_ekle = new System.Windows.Forms.Button();
			this.Btn_sil = new System.Windows.Forms.Button();
			this.btn_guncelle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori ID:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(146, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 30);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(146, 65);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(175, 30);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kategori Adı:";
			// 
			// btn_listele
			// 
			this.btn_listele.Location = new System.Drawing.Point(20, 118);
			this.btn_listele.Name = "btn_listele";
			this.btn_listele.Size = new System.Drawing.Size(128, 40);
			this.btn_listele.TabIndex = 4;
			this.btn_listele.Text = "Listele";
			this.btn_listele.UseVisualStyleBackColor = true;
			this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
			// 
			// btn_ekle
			// 
			this.btn_ekle.Location = new System.Drawing.Point(20, 164);
			this.btn_ekle.Name = "btn_ekle";
			this.btn_ekle.Size = new System.Drawing.Size(128, 40);
			this.btn_ekle.TabIndex = 5;
			this.btn_ekle.Text = "Ekle";
			this.btn_ekle.UseVisualStyleBackColor = true;
			this.btn_ekle.Click += new System.EventHandler(this.button2_Click);
			// 
			// Btn_sil
			// 
			this.Btn_sil.Location = new System.Drawing.Point(193, 118);
			this.Btn_sil.Name = "Btn_sil";
			this.Btn_sil.Size = new System.Drawing.Size(128, 40);
			this.Btn_sil.TabIndex = 6;
			this.Btn_sil.Text = "Sil";
			this.Btn_sil.UseVisualStyleBackColor = true;
			this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
			// 
			// btn_guncelle
			// 
			this.btn_guncelle.Location = new System.Drawing.Point(193, 164);
			this.btn_guncelle.Name = "btn_guncelle";
			this.btn_guncelle.Size = new System.Drawing.Size(128, 40);
			this.btn_guncelle.TabIndex = 7;
			this.btn_guncelle.Text = "Güncelle";
			this.btn_guncelle.UseVisualStyleBackColor = true;
			this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(351, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(609, 178);
			this.dataGridView1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 234);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_guncelle);
			this.Controls.Add(this.Btn_sil);
			this.Controls.Add(this.btn_ekle);
			this.Controls.Add(this.btn_listele);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_listele;
		private System.Windows.Forms.Button btn_ekle;
		private System.Windows.Forms.Button Btn_sil;
		private System.Windows.Forms.Button btn_guncelle;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

