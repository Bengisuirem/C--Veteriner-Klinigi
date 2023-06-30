using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vet
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            yoneticipanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void yonbutton_Click(object sender, EventArgs e)
        {
            yonbutton.BackColor = Color.LightCoral;
            if (yonad.Text == "bonik" & yonpar.Text == "bonik")
            {
                personekle prs = new personekle();
                prs.ShowDialog();
            }
            else
                MessageBox.Show("Kullanıcı adı veya parola hatalı!");
            
        }
    }
}
