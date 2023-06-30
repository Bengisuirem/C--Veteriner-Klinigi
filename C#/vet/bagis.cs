using MySql.Data.MySqlClient;
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
    public partial class bagis : Form
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        public bagis()
        {
            InitializeComponent();
        }

        private void bagispanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bagis_Load(object sender, EventArgs e)
        {
            build.UserID = "root";
            build.Database = "hayvanlar";
            build.Password = "7777";
            build.Server = "localhost";
            baglanti = new MySqlConnection(build.ToString());
        }

        public void ekle(string sql)
        {
            baglanti.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = baglanti;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            baglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bagisbtn.BackColor = Color.SeaGreen;
            ekle("insert into bagis values('" + bagiscitb.Text + "', '" + bagismiktb.Text + "', '" + kartno.Text + "')");
            bagiscitb.Clear();
            bagismiktb.Clear();
            kartno.Clear();
            MessageBox.Show("Bağışınız İçin Teşekkür Ederiz!");
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
