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
    public partial class admin : Form
    {


        SQLProcess conn = new SQLProcess();
        string ay, sql,logname;
        string[] tarih = new string[4];

        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m)
            {
                ItemColor = c;
                Message = m;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
        }

        public admin()
        {
            InitializeComponent();
        }

        public string months(int a) {
            if (a == 1) return "Ocak";
            else if (a == 2) return "Şubat";
            else if (a == 3) return "Mart";
            else if (a == 4) return "Nisan";
            else if (a == 5) return "Mayıs";
            else if (a == 6) return "Haziran";
            else if (a == 7) return "Temmuz";
            else if (a == 8) return "Ağustos";
            else if (a == 9) return "Eylül";
            else if (a == 10) return "Ekim";
            else if (a == 11) return "Kasım";
            else return "Aralık";
        }
        public string years(int a)
        {
            if (a == 0) return "2014";
            else if (a == 1) return "2015";
            else return "2016";
        }

        public void treebuild()
        {
            int i,k;
            tree_tarih.Nodes.Add("2014");
            tree_tarih.Nodes.Add("2015");
            tree_tarih.Nodes.Add("2016");

            for(k=0;k<3;k++)
                for (i = 1; i < 13; i++) {
                    tree_tarih.Nodes[k].Nodes.Add(months(i));
                    for (int j = 1; j < 32; j++) tree_tarih.Nodes[k].Nodes[i-1].Nodes.Add(j+"/"+i+"/"+years(k) );
                }             
                


            SqlCommand staff = new SqlCommand("select distinct name from staff",conn.connect());
            SqlDataReader staffdata=staff.ExecuteReader();
            i = 0;
            while (staffdata.Read())
            {
                tree_users.Nodes.Add(staffdata["name"].ToString());
            }

            staff.Dispose();
            staffdata.Close();

            SqlCommand tools = new SqlCommand("select toollocation,toolname from tools", conn.connect());
            SqlDataReader toolsdata = tools.ExecuteReader();

            while (toolsdata.Read())
            {
                tree_tools.Nodes.Add(toolsdata["toollocation"].ToString() + " " + toolsdata["toolname"].ToString());
            }
            staff.Dispose();
            toolsdata.Close();
            
        }
           
        public void logload() {
            lstbox_log.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime,changetoolid FROM changes,staff,tools WHERE changes.changerid=staff.rankid AND changes.changetoolid=tools.toolid ORDER BY changeid DESC ", conn.connect());
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                if (data["name"].ToString() == "Acil")
                {
                    lstbox_log.Items.Add(data["changetime"].ToString() + " anında Ev Güvenlik Modundayken sebebi bilinmeyen hareket gözlendi.");
                }
                else {
                    lstbox_log.Items.Add(data["changetime"].ToString() + " anında " + data["name"].ToString() + " tarafından " + data["toollocation"].ToString() + " " + data["toolname"].ToString() + " " + data["changebeforestatus"].ToString() + " durumdan " + data["changeafterstatus"].ToString() + " duruma getirildi.");
                } 
            }           
        }

        public void barvalue(int a) {
            progressbar.Value = a;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10) ay = "0" + DateTime.Now.Month.ToString();
            else ay = DateTime.Now.Month.ToString();
            logname = DateTime.Now.Day.ToString() + ay + DateTime.Now.Year.ToString();
            try
            {
                sr = File.OpenText(logname+".txt");
                sr.Close();
            }
            catch (Exception ex)
            {
                File.CreateText(logname + ".txt");
            }
            treebuild();
        }

        private void bilgilerimiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string[] toolsbol(string a) {
            string[] b = a.Split(' ');
            return b;
        }

        public string komutcek() {


            lbl_filtre.Text += tree_tarih.SelectedNode.Text;

            if (tree_tarih.SelectedNode.Parent.Parent != null)
            {
                tarih[0] = tree_tarih.SelectedNode.Parent.Parent.Text;
                tarih[1] = (tree_tarih.SelectedNode.Parent.Index + 1).ToString();
                tarih[2] = (tree_tarih.SelectedNode.Index + 1).ToString();
                tarih[3] = tarih[2];
            }
            else {
                tarih[0] = tree_tarih.SelectedNode.Parent.Text;
                if ((tree_tarih.SelectedNode.Index + 1) < 10) tarih[1] = "0" + (tree_tarih.SelectedNode.Index + 1).ToString();
                else tarih[1] = (tree_tarih.SelectedNode.Index + 1).ToString();

                tarih[2] = "01";
                tarih[3] = "31";
            }

            if (tree_users.SelectedNode != null)
            {
                if (tree_tools.SelectedNode != null)
                {
                    lbl_filtre.Text += " > " + tree_tools.SelectedNode.Text + " > " + tree_users.SelectedNode.Text;
                    string[] a = tree_tools.SelectedNode.Text.Split(' ');
                    sql = "SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3]+ " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid AND staff.name='" + tree_users.SelectedNode.Text + "' and toollocation='" + a[0] + "' and toolname='" + a[1] + "' ORDER BY changeid DESC";
                }
                else sql = "SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid AND staff.name='" + tree_users.SelectedNode.Text + "' ORDER BY changeid DESC";
            }
            else if (tree_users.SelectedNode == null)
            {
                if (tree_tools.SelectedNode != null)
                {
                    lbl_filtre.Text += " > " + tree_tools.SelectedNode.Text;
                    string[] a = tree_tools.SelectedNode.Text.Split(' ');
                    sql = "SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid and toollocation='" + a[0] + "' and toolname='" + a[1] + "' ORDER BY changeid DESC";
                }
                else sql = "SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid ORDER BY changeid DESC";
            }
            else sql = "SELECT changebeforestatus,changeafterstatus,name,toollocation,toolname,changetime FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid ORDER BY changeid DESC";

            

            return sql;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlCommand cmd2;

            

            lbl_filtre.Text = "Hepsi > ";
            int i=0;
            lstbox_log.Items.Clear();
            if (tree_tarih.SelectedNode == null) MessageBox.Show("Tarih Seçin");
            else if (tree_tarih.SelectedNode.Parent == null) MessageBox.Show("Ay seçiniz");
            else
            {

                cmd = new SqlCommand(komutcek(), conn.connect());
                SqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    if (tree_users.SelectedNode != null) cmd2 = new SqlCommand("SELECT count(changeid) FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid and name='" + tree_users.SelectedNode.Text + "' ", conn.connect());
                    else cmd2 = new SqlCommand("SELECT count(changeid) FROM changes,staff,tools WHERE changetime BETWEEN '" + tarih[0] + "-" + tarih[1] + "-" + tarih[2] + " 00:00:00' AND '" + tarih[0] + "-" + tarih[1] + "-" + tarih[3] + " 23:59:00' AND  changes.changerid=staff.id AND changes.changetoolid=tools.toolid ", conn.connect());

                    Int32 count = (Int32)cmd2.ExecuteScalar();
                    toolStripStatusLabel1.Text = "Kayıt Sayısı " + count.ToString();
                    while (data.Read())
                    {
                   
                        barvalue((i * 100) / count);
                        if (data["name"].ToString() == "Acil")
                        {
                            lstbox_log.Items.Add(data["changetime"].ToString() + " anında Ev Güvenlik Modundayken sebebi bilinmeyen hareket gözlendi.");                            
                        }
                        else{
                            lstbox_log.Items.Add(data["changetime"].ToString() + " anında " + data["name"].ToString() + " tarafından " + data["toollocation"].ToString() + " " + data["toolname"].ToString() + " " + data["changebeforestatus"].ToString() + " durumdan " + data["changeafterstatus"].ToString() + " duruma getirildi.");

                        } 
                        i++; 
                    }
                }
                else
                {
                    lstbox_log.Items.Add("***Kayıt Bulunamadı");
                }
            }
        barvalue(0);           
        }

        private void kullanıcılarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcılarıGörToolStripMenuItem.PerformClick();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcılarıGörToolStripMenuItem.PerformClick();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu yeni = new menu();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcılarıGörToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcıSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void kullanıcıEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void eviYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display yeni = new display();
            yeni.Show();
            yeni.lbl_user.Text = "Admin";
            yeni.lbl_userid.Text = "2";
            this.Hide();
        }

        private void geçmişGörToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bilgilerimiDüzenleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ebeveyn yeni = new ebeveyn();          
            yeni.lbl_username.Text = "Admin";
            yeni.lbl_userid.Text = "2";
            yeni.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tree_tarih.SelectedNode = null;
            tree_tools.SelectedNode = null;
            tree_users.SelectedNode = null;
            btn_showlog.PerformClick();
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
