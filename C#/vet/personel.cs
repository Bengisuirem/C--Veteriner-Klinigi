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
using System.Data;


namespace vet
{
    public partial class personel : Form
    {

        MySqlConnection baglanti = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=hayvanlar;User Id=root;password='7777'");
        int a;
        public personel()
        {
            InitializeComponent();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            personelpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                persgiris.BackColor = Color.Tomato;
                a = 0;
                baglanti.Open();
                MySqlCommand command = baglanti.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from personel where persad='" + persadtextBox.Text +"' and persparola= '" + perspartextBox.Text + "'";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
                a = Convert.ToInt32(dt.Rows.Count.ToString());
            if (a == 0)
            {
                MessageBox.Show("Hatalı Giriş!");
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            baglanti.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
