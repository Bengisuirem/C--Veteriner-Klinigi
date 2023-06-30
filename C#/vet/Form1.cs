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
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        string durum;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            build.UserID = "root";
            build.Database = "hayvanlar";
            build.Password = "7777";
            build.Server = "localhost";
            baglanti = new MySqlConnection(build.ToString());
            Liste("SELECT * FROM hayvanlist");
            
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radiosurec.Checked == true)
            {
                durum = "İyilesme Sürecinde";
            }
            else if (radioiyi.Checked == true)
            {
                durum = "İyilesti";
            }
            else
                durum = "Hasta";
            esg("insert into hayvanlist values('" + int.Parse(hno.Text) + "', '" + tur.Text + "', '" + cins.Text + "', '" + hasta.Text + "', '" + durum + "', '" + tarih.Text + "')");
            Liste("select * from hayvanlist");
            hno.Clear();
            tur.Clear();
            cins.Clear();
            hasta.Clear();         
            tarih.Clear();
        }

        private void guncelbutton_Click(object sender, EventArgs e)
        {
            if (radiosurec.Checked == true)
            {
                durum = "İyilesme Sürecinde";
            }
            else if (radioiyi.Checked == true)
            {
                durum = "İyilesti";
            }
            else
                durum = "Hasta";

            esg("update hayvanlist set durum= '" + durum + "' where hno='" + dataGridView1.CurrentRow.Cells["hno"].Value.ToString() + "'");
            Liste("select * from hayvanlist");
            hno.Clear();
            tur.Clear();
            cins.Clear();
            hasta.Clear();
            tarih.Clear();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            esg("delete from hayvanlist where hno= '" +dataGridView1.CurrentRow.Cells ["hno"].Value.ToString() +"'");
            Liste("select * from hayvanlist");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            
            Liste("select * from hayvanlist where hno like '%" + txtara.Text + "%' or tur like '%" + txtara.Text + "%' or cins like '%" + txtara.Text+ "%' or hastalik like '%"+
            txtara.Text+ "%' or durum like '%"+ txtara.Text+ "%' or tarih like '%"+ txtara.Text+ "%'");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void durum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
