
namespace vet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hno = new System.Windows.Forms.TextBox();
            this.tur = new System.Windows.Forms.TextBox();
            this.cins = new System.Windows.Forms.TextBox();
            this.hasta = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eklebutton = new System.Windows.Forms.Button();
            this.guncelbutton = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radiosurec = new System.Windows.Forms.RadioButton();
            this.radiohasta = new System.Windows.Forms.RadioButton();
            this.radioiyi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hayvan No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hastalığı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tedavi Tarihi:";
            // 
            // hno
            // 
            this.hno.Location = new System.Drawing.Point(194, 24);
            this.hno.Name = "hno";
            this.hno.Size = new System.Drawing.Size(271, 24);
            this.hno.TabIndex = 6;
            // 
            // tur
            // 
            this.tur.Location = new System.Drawing.Point(194, 68);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(271, 24);
            this.tur.TabIndex = 7;
            // 
            // cins
            // 
            this.cins.Location = new System.Drawing.Point(193, 113);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(272, 24);
            this.cins.TabIndex = 8;
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(193, 165);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(272, 24);
            this.hasta.TabIndex = 9;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(194, 223);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(272, 24);
            this.tarih.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 340);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // eklebutton
            // 
            this.eklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.eklebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebutton.ForeColor = System.Drawing.Color.Blue;
            this.eklebutton.Location = new System.Drawing.Point(44, 404);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Size = new System.Drawing.Size(149, 40);
            this.eklebutton.TabIndex = 13;
            this.eklebutton.Text = "Ekle";
            this.eklebutton.UseVisualStyleBackColor = false;
            this.eklebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // guncelbutton
            // 
            this.guncelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guncelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelbutton.ForeColor = System.Drawing.Color.Blue;
            this.guncelbutton.Location = new System.Drawing.Point(282, 404);
            this.guncelbutton.Name = "guncelbutton";
            this.guncelbutton.Size = new System.Drawing.Size(149, 40);
            this.guncelbutton.TabIndex = 14;
            this.guncelbutton.Text = "Güncelle";
            this.guncelbutton.UseVisualStyleBackColor = false;
            this.guncelbutton.Click += new System.EventHandler(this.guncelbutton_Click);
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.ForeColor = System.Drawing.Color.Crimson;
            this.silbutton.Location = new System.Drawing.Point(529, 404);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(142, 40);
            this.silbutton.TabIndex = 15;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(490, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ara:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(554, 24);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(245, 24);
            this.txtara.TabIndex = 17;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.Color.Crimson;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.ImageIndex = 0;
            this.exit.ImageList = this.ımageList1;
            this.exit.Location = new System.Drawing.Point(1056, 404);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(139, 40);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "x.jpg");
            // 
            // radiosurec
            // 
            this.radiosurec.AutoSize = true;
            this.radiosurec.BackColor = System.Drawing.Color.Transparent;
            this.radiosurec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiosurec.Location = new System.Drawing.Point(38, 304);
            this.radiosurec.Name = "radiosurec";
            this.radiosurec.Size = new System.Drawing.Size(189, 24);
            this.radiosurec.TabIndex = 20;
            this.radiosurec.TabStop = true;
            this.radiosurec.Text = "İyileşme Sürecinde";
            this.radiosurec.UseVisualStyleBackColor = false;
            // 
            // radiohasta
            // 
            this.radiohasta.AutoSize = true;
            this.radiohasta.BackColor = System.Drawing.Color.Transparent;
            this.radiohasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiohasta.Location = new System.Drawing.Point(38, 364);
            this.radiohasta.Name = "radiohasta";
            this.radiohasta.Size = new System.Drawing.Size(80, 24);
            this.radiohasta.TabIndex = 19;
            this.radiohasta.TabStop = true;
            this.radiohasta.Text = "Hasta";
            this.radiohasta.UseVisualStyleBackColor = false;
            // 
            // radioiyi
            // 
            this.radioiyi.AutoSize = true;
            this.radioiyi.BackColor = System.Drawing.Color.Transparent;
            this.radioiyi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioiyi.Location = new System.Drawing.Point(39, 334);
            this.radioiyi.Name = "radioiyi";
            this.radioiyi.Size = new System.Drawing.Size(85, 24);
            this.radioiyi.TabIndex = 21;
            this.radioiyi.TabStop = true;
            this.radioiyi.Text = "İyileşti";
            this.radioiyi.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Durumu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::vet.Properties.Resources.animals_by_location_hero;
            this.ClientSize = new System.Drawing.Size(1198, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radiohasta);
            this.Controls.Add(this.radioiyi);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.radiosurec);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.guncelbutton);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.hno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalList";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hno;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox cins;
        private System.Windows.Forms.TextBox hasta;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eklebutton;
        private System.Windows.Forms.Button guncelbutton;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.RadioButton radiosurec;
        private System.Windows.Forms.RadioButton radiohasta;
        private System.Windows.Forms.RadioButton radioiyi;
        private System.Windows.Forms.Label label5;
    }
}

