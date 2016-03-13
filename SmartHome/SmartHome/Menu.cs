using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartHome
{
    public partial class menu : Form
    {
        control yeni = new control();
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeni.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display frmdisplay = new display();
            frmdisplay.lbl_userid.Text = "1002";
            frmdisplay.lbl_user.Text = "Ekran";
            frmdisplay.Show();
            this.Hide();
        }
    }
}
