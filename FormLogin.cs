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

namespace WindowsFormsApp2_DB_MultiForm
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelgender.Visible = false;
            textboxgender.Visible = false;
            labelstatus.Visible = false;
            textboxstatus.Visible = false;
            labelkodejenis.Visible = false;
            textboxkodejenis.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button 2 ini button log in
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=dbd_10_xiboba;user=root;password=");
            con.Open();
            string datasql = "select kodebarista,namabarista from barista where kodebarista='" + textboxuser.Text.ToString() + "' and namabarista = '" + textboxpassw.Text.ToString() + "' and delete_barista = '0'" ;
            MySqlCommand cmd = new MySqlCommand(datasql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            string idbar = "";
            string nmbar = "";
            while (reader.Read())
            {
                idbar = reader.GetString(0);
                nmbar = reader.GetString(1);
            };

            if (idbar != "")
            {
                FormPesanan frmpesan = new FormPesanan();
                frmpesan.Show();
            } else
            {
                MessageBox.Show("User/Password Salah" + "\n" + "atau user tidak aktif");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button add di bwh menu barista
            if (buttonadd.Text == "Add")
            {
                textboxuser.Text = "";
                textboxpassw.Text = "";
                textboxgender.Text = "";
                labelgender.Visible = true;
                textboxgender.Visible = true;
                buttonadd.Text = "Save";
            } else
            {
                if(buttonadd.Text == "Save")
                {
                    tambahBarista();
                    buttonadd.Text = "Add";
                    labelgender.Visible = false;
                    textboxgender.Visible = false;
                    textboxuser.Text = "";
                    textboxpassw.Text = "";
                    textboxgender.Text = "";
                }
            }

        }

       
        // Edit Status Barista
        private void button5_Click(object sender, EventArgs e)
        {
            // button edit di bawah menu barista
            if (buttonedit.Text == "Edit")
            {
                textboxuser.Text = "";
                textboxpassw.Text = "";
                //textBox3.Text = "";
                labelstatus.Visible = true;
                textboxstatus.Visible = true;
                buttonedit.Text = "Save";
            }
            else
            {
                if (buttonedit.Text == "Save")
                {
                    editBarista();
                    buttonedit.Text = "Edit";
                    labelstatus.Visible = false;
                    textboxstatus.Visible = false;
                    textboxuser.Text = "";
                    textboxpassw.Text = "";
                    textboxstatus.Text = "";
                }
            }
        }

        public void tambahBarista()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=dbd_10_xiboba;user=root;password=");
            con.Open();
            string datasql = "insert into barista values('" + textboxuser.Text.ToString() + "','" + textboxpassw.Text.ToString() + "','" + textboxgender.Text.ToString() + "','0')";
            MySqlCommand cmd = new MySqlCommand(datasql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public void editBarista()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=dbd_10_xiboba;user=root;password=");
            con.Open();
            string datasql = "update barista set delete_barista='" + textboxstatus.Text.ToString() + "' where kodebarista='" + textboxuser.Text.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(datasql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public void editJenisBarista()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=dbd_10_xiboba;user=root;password=");
            con.Open();
            string datasql = "update barista_jenis set delete_barista_jenis='" + textboxstatus.Text.ToString() + "' where kodebarista='" + textboxuser.Text.ToString() + "' and kodejenis='" + textboxkodejenis.Text.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(datasql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
        }
        public void tambahJenisBarista()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=dbd_10_xiboba;user=root;password=");
            con.Open();
            string datasql = "insert into barista_jenis values('" + textboxkodejenis.Text.ToString() + "','" + textboxuser.Text.ToString() + "','0')";
            MySqlCommand cmd = new MySqlCommand(datasql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // button add dibwh job barista
            if (buttonadd2.Text == "Add")
            {
                textboxuser.Text = "";
                textboxpassw.Text = "";
                //textBox3.Text = "";
                labelkodejenis.Visible = true;
                textboxkodejenis.Visible = true;
                buttonadd2.Text = "Save";
            }
            else
            {
                if (buttonadd2.Text == "Save")
                {
                    tambahJenisBarista();
                    buttonadd2.Text = "Add";
                    labelkodejenis.Visible = false;
                    textboxkodejenis.Visible = false;
                    textboxuser.Text = "";
                    textboxpassw.Text = "";
                    textboxgender.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //button edit dibwh job barista
            if (buttonedit2.Text == "Edit")
            {
                textboxuser.Text = "";
                //textBox2.Text = "";
                labelstatus.Visible = true;
                textboxstatus.Visible = true;
                textboxstatus.Text = "";
                labelkodejenis.Visible = true;
                textboxkodejenis.Visible = true;
                buttonedit2.Text = "Save";
            }
            else
            {
                if (buttonedit2.Text == "Save")
                {
                    editJenisBarista();
                    buttonedit2.Text = "Edit";
                    labelkodejenis.Visible = false;
                    textboxkodejenis.Visible = false;
                    labelstatus.Visible= false;
                    textboxstatus.Visible= false;
                    textboxuser.Text = "";
                    textboxpassw.Text = "";
                    textboxgender.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
