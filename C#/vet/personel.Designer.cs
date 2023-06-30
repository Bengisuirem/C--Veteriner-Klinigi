
namespace vet
{
    partial class personel
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
            this.perspartextBox = new System.Windows.Forms.TextBox();
            this.persadtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personelpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.persgiris = new System.Windows.Forms.Button();
            this.personelpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // perspartextBox
            // 
            this.perspartextBox.Location = new System.Drawing.Point(23, 197);
            this.perspartextBox.Name = "perspartextBox";
            this.perspartextBox.Size = new System.Drawing.Size(214, 22);
            this.perspartextBox.TabIndex = 3;
            this.perspartextBox.UseSystemPasswordChar = true;
            // 
            // persadtextBox
            // 
            this.persadtextBox.Location = new System.Drawing.Point(23, 107);
            this.persadtextBox.Name = "persadtextBox";
            this.persadtextBox.Size = new System.Drawing.Size(214, 22);
            this.persadtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // personelpanel
            // 
            this.personelpanel.BackColor = System.Drawing.Color.Transparent;
            this.personelpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personelpanel.Controls.Add(this.label3);
            this.personelpanel.Controls.Add(this.persgiris);
            this.personelpanel.Controls.Add(this.perspartextBox);
            this.personelpanel.Controls.Add(this.label2);
            this.personelpanel.Controls.Add(this.persadtextBox);
            this.personelpanel.Controls.Add(this.label1);
            this.personelpanel.Location = new System.Drawing.Point(357, 73);
            this.personelpanel.Name = "personelpanel";
            this.personelpanel.Size = new System.Drawing.Size(260, 331);
            this.personelpanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(50, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Girişi";
            // 
            // persgiris
            // 
            this.persgiris.BackColor = System.Drawing.Color.DarkSalmon;
            this.persgiris.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.persgiris.Location = new System.Drawing.Point(56, 247);
            this.persgiris.Name = "persgiris";
            this.persgiris.Size = new System.Drawing.Size(150, 47);
            this.persgiris.TabIndex = 4;
            this.persgiris.Text = "Giriş Yap";
            this.persgiris.UseVisualStyleBackColor = false;
            this.persgiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::vet.Properties.Resources.zürafa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 469);
            this.Controls.Add(this.personelpanel);
            this.DoubleBuffered = true;
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel";
            this.Load += new System.EventHandler(this.personel_Load);
            this.personelpanel.ResumeLayout(false);
            this.personelpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel personelpanel;
        private System.Windows.Forms.Button persgiris;
        private System.Windows.Forms.TextBox perspartextBox;
        private System.Windows.Forms.TextBox persadtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}