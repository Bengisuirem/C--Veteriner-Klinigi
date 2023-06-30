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
    public partial class personekle : Form
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        public personekle()
        {
            InitializeComponent();
        }

        private void personekle_Load(object sender, EventArgs e)
        {
            build.UserID = "root";
            build.Database = "hayvanlar";
            build.Password = "7777";
            build.Server = "localhost";
            baglanti = new MySqlConnection(build.ToString());
            Liste("SELECT * FROM personel");

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
        public void esg(string sql)
        {
            baglanti.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = baglanti;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            baglanti.Close();


        }

        private void ekle_Click(object sender, EventArgs e)
        {
            esg("insert into personel values('" + int.Parse(pid.Text) + "', '" + prsad.Text + "', '" + prspar.Text +"')");
            Liste("select * from personel");
            pid.Clear();
            prsad.Clear();
            prspar.Clear();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            esg("update personel set persad= '" + prsad.Text + "',persparola='" + prspar.Text + "' where persid='" + dataGridView1.CurrentRow.Cells["persid"].Value.ToString() + "'");
            Liste("select * from personel");
            pid.Clear();
            prsad.Clear();
            prspar.Clear();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            esg("delete from personel where persid= '" + dataGridView1.CurrentRow.Cells["persid"].Value.ToString() + "'");
            Liste("select * from personel");
        }

        private void prsara_TextChanged(object sender, EventArgs e)
        {
            Liste("select * from personel where persid like '%" + prsara.Text + "%' or persad like '%" + prsara.Text + "%' or persparola like '%" + prsara.Text + "%'");
        }
    }
}
