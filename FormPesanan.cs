using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_DB_MultiForm
{
    public partial class FormPesanan : Form
    {
        public FormPesanan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin muncul = new FormLogin();
            muncul.Show();
        }
    }
}
