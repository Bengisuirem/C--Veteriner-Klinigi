
namespace vet
{
    partial class yonetici
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.yoneticipanel = new System.Windows.Forms.Panel();
            this.yonbutton = new System.Windows.Forms.Button();
            this.yonpar = new System.Windows.Forms.TextBox();
            this.yonad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yoneticipanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::vet.Properties.Resources.bonik;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(85, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 115);
            this.panel1.TabIndex = 0;
            // 
            // yoneticipanel
            // 
            this.yoneticipanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yoneticipanel.Controls.Add(this.yonbutton);
            this.yoneticipanel.Controls.Add(this.yonpar);
            this.yoneticipanel.Controls.Add(this.yonad);
            this.yoneticipanel.Controls.Add(this.label3);
            this.yoneticipanel.Controls.Add(this.label2);
            this.yoneticipanel.Controls.Add(this.label1);
            this.yoneticipanel.Controls.Add(this.panel1);
            this.yoneticipanel.Location = new System.Drawing.Point(23, 23);
            this.yoneticipanel.Name = "yoneticipanel";
            this.yoneticipanel.Size = new System.Drawing.Size(303, 413);
            this.yoneticipanel.TabIndex = 1;
            // 
            // yonbutton
            // 
            this.yonbutton.BackColor = System.Drawing.Color.BurlyWood;
            this.yonbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonbutton.ForeColor = System.Drawing.Color.Black;
            this.yonbutton.Location = new System.Drawing.Point(69, 329);
            this.yonbutton.Name = "yonbutton";
            this.yonbutton.Size = new System.Drawing.Size(142, 45);
            this.yonbutton.TabIndex = 6;
            this.yonbutton.Text = "Giriş Yap";
            this.yonbutton.UseVisualStyleBackColor = false;
            this.yonbutton.Click += new System.EventHandler(this.yonbutton_Click);
            // 
            // yonpar
            // 
            this.yonpar.Location = new System.Drawing.Point(27, 282);
            this.yonpar.Name = "yonpar";
            this.yonpar.Size = new System.Drawing.Size(234, 22);
            this.yonpar.TabIndex = 5;
            this.yonpar.UseSystemPasswordChar = true;
            // 
            // yonad
            // 
            this.yonad.Location = new System.Drawing.Point(27, 207);
            this.yonad.Name = "yonad";
            this.yonad.Size = new System.Drawing.Size(234, 22);
            this.yonad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Girişi";
            // 
            // yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vet.Properties.Resources.fox3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.yoneticipanel);
            this.Name = "yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yonetici";
            this.Load += new System.EventHandler(this.yonetici_Load);
            this.yoneticipanel.ResumeLayout(false);
            this.yoneticipanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel yoneticipanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yonbutton;
        private System.Windows.Forms.TextBox yonpar;
        private System.Windows.Forms.TextBox yonad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}