
namespace vet
{
    partial class personekle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prsad = new System.Windows.Forms.TextBox();
            this.prspar = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prsara = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.prsid = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(547, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Parola:";
            // 
            // prsad
            // 
            this.prsad.Location = new System.Drawing.Point(29, 181);
            this.prsad.Name = "prsad";
            this.prsad.Size = new System.Drawing.Size(267, 22);
            this.prsad.TabIndex = 3;
            // 
            // prspar
            // 
            this.prspar.Location = new System.Drawing.Point(29, 274);
            this.prspar.Name = "prspar";
            this.prspar.Size = new System.Drawing.Size(267, 22);
            this.prspar.TabIndex = 4;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.ekle.Location = new System.Drawing.Point(29, 365);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(267, 51);
            this.ekle.TabIndex = 5;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(536, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ara:";
            // 
            // prsara
            // 
            this.prsara.Location = new System.Drawing.Point(590, 58);
            this.prsara.Name = "prsara";
            this.prsara.Size = new System.Drawing.Size(276, 22);
            this.prsara.TabIndex = 7;
            this.prsara.TextChanged += new System.EventHandler(this.prsara_TextChanged);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.guncelle.Location = new System.Drawing.Point(580, 365);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(173, 51);
            this.guncelle.TabIndex = 8;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.MediumPurple;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.sil.Location = new System.Drawing.Point(804, 365);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(178, 51);
            this.sil.TabIndex = 9;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // prsid
            // 
            this.prsid.AutoSize = true;
            this.prsid.BackColor = System.Drawing.Color.Transparent;
            this.prsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.prsid.ForeColor = System.Drawing.Color.Black;
            this.prsid.Location = new System.Drawing.Point(25, 58);
            this.prsid.Name = "prsid";
            this.prsid.Size = new System.Drawing.Size(124, 24);
            this.prsid.TabIndex = 12;
            this.prsid.Text = "Personel ID:";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(29, 94);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(267, 22);
            this.pid.TabIndex = 13;
            // 
            // personekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vet.Properties.Resources.cute;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.prsid);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.prsara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.prspar);
            this.Controls.Add(this.prsad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "personekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personekle";
            this.Load += new System.EventHandler(this.personekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prsad;
        private System.Windows.Forms.TextBox prspar;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prsara;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label prsid;
        private System.Windows.Forms.TextBox pid;
    }
}