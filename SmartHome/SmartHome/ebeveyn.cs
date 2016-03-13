using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SmartHome
{
    public partial class ebeveyn : Form
    {
        SQLProcess conn = new SQLProcess();
        string pw;
        public ebeveyn()
        {
            InitializeComponent();
        }

        private void ebeveyn_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM staff WHERE id="+lbl_userid.Text, conn.connect());
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                txt_name.Text = data["name"].ToString();
                txt_surname.Text = data["surname"].ToString();
                txt_email.Text = data["email"].ToString();
                txt_telephone.Text = data["telephone"].ToString();
                pw=data["password"].ToString();
            }
            txt_newpwagain.Text = "";
            txt_newpw.Text = "";

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
                if (txt_newpw.Text == txt_newpwagain.Text && txt_pw.Text==pw) {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE staff SET password='" + txt_newpw.Text + "' WHERE id="+lbl_userid.Text, conn.connect());
                        cmd.ExecuteNonQuery();
                        lbl_status.Text = "Şifreniz Değiştirildi.";
                        txt_newpw.Text = "";
                        txt_newpwagain.Text = "";
                        txt_pw.Text = "";
                    }
                    catch (Exception ex) {
                        lbl_status.Text = ex.ToString();
                    }
                }
                else
                {
                    lbl_status.Text = "Şifreler uyuşmuyor.";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand update = new SqlCommand("UPDATE staff SET password=@pw and name=@name and surname=@surname and telephone=@telephone and email=@email WHERE id=" + lbl_userid.Text, conn.connect());
                update.Parameters.AddWithValue("@name", txt_name.Text);
                update.Parameters.AddWithValue("@surname", txt_name.Text);
                update.Parameters.AddWithValue("@telephone", txt_name.Text);
                update.Parameters.AddWithValue("@email", txt_name.Text);
                update.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Bilgileriniz Güncellendi.";
            }
            
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu yeni = new menu();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcılarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok");
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok");
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok");
        }

        private void geçmişGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok");
        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yapim yeni = new yapim();
            yeni.Show();
        }

        private void sorunBildirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yapim yeni = new yapim();
            yeni.Show();
        }
    }
}
