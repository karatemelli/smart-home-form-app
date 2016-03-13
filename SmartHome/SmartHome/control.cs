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
    public partial class control : Form
    {
        public control()
        {
            InitializeComponent();
        }

        private void control_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "admin" && txt_pw.Text == "qwe123")
            {
                admin admine = new admin();
                admine.Show();
                this.Hide();
            }
            else { 
            
                SQLProcess database = new SQLProcess();
                SqlCommand cmd = new SqlCommand("SELECT * FROM staff WHERE email='" + txt_email.Text + "' and password='" + txt_pw.Text + "'", database.connect());
                SqlDataReader oku = cmd.ExecuteReader();

                if (oku.HasRows)
                    while (oku.Read())
                    {
                        if (oku["rankid"].ToString() == "1")
                        {
                            admin frmadmin = new admin();
                            frmadmin.Show();
                            this.Hide();
                        }
                        else if (oku["rankid"].ToString() == "2")
                        {
                            display frmebeveyn = new display();
                            frmebeveyn.lbl_user.Text = oku["name"].ToString();
                            frmebeveyn.lbl_userid.Text = oku["id"].ToString();
                            frmebeveyn.Show();
                            this.Hide();
                        }
                        else
                        {
                            display frmdisplay = new display();
                            frmdisplay.lbl_user.Text = "Ekran";
                            frmdisplay.lbl_userid.Text = "1002";
                            frmdisplay.Show();
                            this.Hide();
                        }
                    }
                else {
                    lblerror.Text = "Kullanıcı adı veya parola yanlış.";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu frmmenu = new menu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
