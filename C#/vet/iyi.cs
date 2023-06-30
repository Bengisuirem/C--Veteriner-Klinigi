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
    public partial class iyi : Form
    {

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        
        public iyi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iyi_Load(object sender, EventArgs e)
        {
            build.UserID = "root";
            build.Database = "hayvanlar";
            build.Password = "7777";
            build.Server = "localhost";
            baglanti = new MySqlConnection(build.ToString());
            Liste("SELECT * FROM hayvanlist where durum='"+"İyileşti"+"'");
        }
        public DataTable Liste(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglanti);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }
    }
}
