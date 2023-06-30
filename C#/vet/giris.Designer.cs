
namespace vet
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iyilesenler = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Button();
            this.personel = new System.Windows.Forms.Button();
            this.bagis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "animals_by_location_hero.jpg");
            this.ımageList1.Images.SetKeyName(1, "pers.png");
            this.ımageList1.Images.SetKeyName(2, "pers2.png");
            // 
            // iyilesenler
            // 
            this.iyilesenler.BackColor = System.Drawing.Color.LightSalmon;
            this.iyilesenler.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iyilesenler.Location = new System.Drawing.Point(28, 129);
            this.iyilesenler.Name = "iyilesenler";
            this.iyilesenler.Size = new System.Drawing.Size(253, 54);
            this.iyilesenler.TabIndex = 0;
            this.iyilesenler.Text = "İyileştirilen Hayvanlar";
            this.iyilesenler.UseVisualStyleBackColor = false;
            this.iyilesenler.Click += new System.EventHandler(this.iyilesenler_Click);
            // 
            // yonetici
            // 
            this.yonetici.BackColor = System.Drawing.Color.LightCoral;
            this.yonetici.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici.Location = new System.Drawing.Point(392, 207);
            this.yonetici.Name = "yonetici";
            this.yonetici.Size = new System.Drawing.Size(244, 54);
            this.yonetici.TabIndex = 1;
            this.yonetici.Text = "Yönetici Girişi";
            this.yonetici.UseVisualStyleBackColor = false;
            this.yonetici.Click += new System.EventHandler(this.yonetici_Click);
            // 
            // personel
            // 
            this.personel.BackColor = System.Drawing.Color.Thistle;
            this.personel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.personel.ImageKey = "pers2.png";
            this.personel.Location = new System.Drawing.Point(737, 129);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(241, 54);
            this.personel.TabIndex = 2;
            this.personel.Text = "Personel Girişi";
            this.personel.UseVisualStyleBackColor = false;
            this.personel.Click += new System.EventHandler(this.personel_Click);
            // 
            // bagis
            // 
            this.bagis.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bagis.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bagis.ForeColor = System.Drawing.Color.DarkRed;
            this.bagis.Location = new System.Drawing.Point(392, 488);
            this.bagis.Name = "bagis";
            this.bagis.Size = new System.Drawing.Size(244, 67);
            this.bagis.TabIndex = 3;
            this.bagis.Text = "Bağışta Bulunun :)";
            this.bagis.UseVisualStyleBackColor = false;
            this.bagis.Click += new System.EventHandler(this.bagis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(181, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bir Hayvanın İyileşmesine Katkıda Bulunmak İster Misiniz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(204, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 92);
            this.label2.TabIndex = 5;
            this.label2.Text = "BONİK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(355, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 92);
            this.label3.TabIndex = 6;
            this.label3.Text = "HAYVAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(548, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 92);
            this.label4.TabIndex = 7;
            this.label4.Text = "KLİNİĞİ";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::vet.Properties.Resources.animals_by_location_hero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bagis);
            this.Controls.Add(this.personel);
            this.Controls.Add(this.yonetici);
            this.Controls.Add(this.iyilesenler);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button iyilesenler;
        private System.Windows.Forms.Button yonetici;
        private System.Windows.Forms.Button personel;
        private System.Windows.Forms.Button bagis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}