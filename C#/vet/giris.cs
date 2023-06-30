using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vet
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void personel_Click(object sender, EventArgs e)
        {
            personel pers = new personel();
            pers.ShowDialog();
        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            yonetici yon = new yonetici();
            yon.ShowDialog();
        }

        private void iyilesenler_Click(object sender, EventArgs e)
        {
            iyi iyilesen = new iyi();
            iyilesen.ShowDialog();
        }

        private void bagis_Click(object sender, EventArgs e)
        {
            bagis bag = new bagis();
            bag.ShowDialog();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
