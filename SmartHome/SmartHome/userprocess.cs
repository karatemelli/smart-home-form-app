using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SmartHome
{
    public partial class userprocess : Form
    {
        SQLProcess conn2 = new SQLProcess();
        SqlDataAdapter adap;
        SqlCommandBuilder scb;
        DataTable dt;
        DataSet ds;

        public userprocess()
        {
            InitializeComponent();
        }

        private void userprocess_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SLCK\OGUZ;Initial Catalog=smarthome;Integrated Security=True;");
            conn.Open();
            adap = new SqlDataAdapter(@"select id,name as 'İsim' , surname as 'Soyisim',rankid as 'Derece', telephone as 'Telefon',email as 'Email',password as 'Şifre', active as 'Aktif'  from staff ", conn);
            ds = new DataSet();
            dt = new DataTable();
            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


            SqlCommand cmdcount = new SqlCommand(@"select count(*)  from staff", conn2.connect());

            Int32 count = (Int32)cmdcount.ExecuteScalar();
            toolStripStatusLabel1.Text += " " + count.ToString();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try {
                userprocess yeni = new userprocess();

                this.Hide();
                yeni.Show();
            }
            catch(Exception ex){
                MessageBox.Show("Hatalı Giriş Yaptınız !"+ex.ToString());
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (txt_email.Text != "" || txt_name.Text != "" || txt_pw.Text != "")
            {
                try{
                    SqlCommand cmdkontrol=new SqlCommand("SELECT * FROM staff WHERE email='"+txt_email.Text+"'",conn2.connect());
                    SqlDataReader data = cmdkontrol.ExecuteReader();
                    if (data.HasRows)
                    {
                        MessageBox.Show("Böyle bir kayıt bulunmakta");
                    }
                    else {
                        SqlCommand cmd = new SqlCommand("INSERT INTO staff(name,surname,password,rankid,telephone,email) VALUES(@name,@surname,@password,@rankid,@telephone,@email)", conn2.connect());
                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                        cmd.Parameters.AddWithValue("@password", txt_pw.Text);
                        cmd.Parameters.AddWithValue("@rankid", 2);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@telephone", txt_telephone.Text);

                        cmd.ExecuteNonQuery();
                        txt_name.Text="";
                        txt_surname.Text="";
                        txt_pw.Text="";
                        txt_email.Text="";
                        txt_telephone.Text = "";
                    }         
            
                }
                catch(Exception ex){
                    MessageBox.Show("Giriş Bilgilerinde Hata Var");
                }
                scb = new SqlCommandBuilder(adap);
                adap.Update(ds);
                MessageBox.Show("Bilgiler Güncellendi");
            }
            else MessageBox.Show("Bilgileri Kontrol Ediniz");
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            menu yeni = new menu();
            yeni.Show();
            this.Hide();
        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            yapim yeni = new yapim();
            yeni.Show();
        }

        private void sorunBildirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            yapim yeni = new yapim();
            yeni.Show();
        }

        private void eviYönetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            display yeni = new display();
            yeni.Show();
            yeni.lbl_user.Text = "Admin";
            yeni.lbl_userid.Text = "2";
            this.Hide();
        }

        private void geçmişGörToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcılarıGörToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void bilgilerimiDüzenleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ebeveyn yeni = new ebeveyn();
            yeni.lbl_username.Text = "Admin";
            yeni.lbl_userid.Text = "2";
            yeni.Show();
            this.Hide();
        }
    }
}
