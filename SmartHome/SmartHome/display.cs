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
using System.Data.Sql;
using System.Threading;
using System.IO;

namespace SmartHome
{
    public partial class display : Form
    {
        SQLProcess conn = new SQLProcess();
        byte[] buffer = new byte[2];
        string[] gelen=new string[3];
        string serimesaj;
        string beforestatus, afterstatus, ay, logname, trackbarstatus;
        bool fiskiyehesapla = false, klimahesapla = false;
        int userid = 3,s,perdezaman,sayac=0,sayac2=0;

        DateTime sonsulama, sonklima;

        public display()
        {
            InitializeComponent();
        }

        public void sender(int tool,int mod) { 

        }

        public void barvalue(int number)
        {
            progressbar_status.Value = number;
        }

        public void logwrite() {
            
            if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10) ay = "0" + DateTime.Now.Month.ToString();
            else ay = DateTime.Now.Month.ToString();
            logname = DateTime.Now.Day.ToString() + ay + DateTime.Now.Year.ToString();
            StreamWriter sw = new StreamWriter(logname + ".txt");   

            SqlCommand cmd = new SqlCommand("SELECT MAX(changeid),changetime,changerid,changetoolid,changebeforestatus,changeafterstatus FROM changes Group by changetime,changerid,changetoolid,changebeforestatus,changeafterstatus", conn.connect());
            SqlDataReader data = cmd.ExecuteReader();
            while(data.Read()){
                string log = data["changetime"].ToString() + " " + data["changerid"].ToString() + " " + data["changetoolid"].ToString() + " " + data["changebeforestatus"].ToString() + " " + data["changeafterstatus"].ToString();                           
                sw.WriteLine(log);
            }
            cmd.Dispose();
            data.Close();
            sw.Close();
        }

        public void serialtoolsend(int toolid)
        {
            SqlCommand toolupdate = new SqlCommand("SELECT * FROM tools WHERE toolid="+toolid, conn.connect());
            SqlDataReader data = toolupdate.ExecuteReader();

            while (data.Read()) {
                buffer[0] = Convert.ToByte(data["toolid"].ToString());

                if (data["toolstatus"].ToString() == "Kapalı") buffer[1] = Convert.ToByte(0);
                else buffer[1] = Convert.ToByte(1);
            }

            if (buffer[0] < 10) serimesaj = "0" + toolid.ToString();
            else serimesaj = toolid.ToString();
            serimesaj = serimesaj + buffer[1].ToString();
            serialPort1.Write(serimesaj);
            label28.Text = serimesaj;
        } 

        public void imagesupdate(int toolid) {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tools WHERE toolid="+toolid, conn.connect());
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                if (data["toollocation"].ToString() == "Salon" && data["toolname"].ToString() == "Işık")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_salon.Image = imglist.Images[1];
                        btn_salonisik.Text = "Kapalı";
                        btn_salonisik.BackColor = Color.Red;
                    }
                    else
                    {
                        picbox_salon.Image = imglist.Images[0];
                        btn_salonisik.Text = "Açık";
                        btn_salonisik.BackColor = Color.Green;
                    }
                }
                else if (data["toollocation"].ToString() == "Oda" && data["toolname"].ToString() == "Işık")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_oda.Image = imglist.Images[1];
                        btn_odaisik.Text = "Kapalı";
                        btn_odaisik.BackColor = Color.Red;
                    }
                    else
                    {
                        picbox_oda.Image = imglist.Images[0];
                        btn_odaisik.Text = "Açık";
                        btn_odaisik.BackColor = Color.Green;
                    }
                }
                else if (data["toollocation"].ToString() == "Garaj" && data["toolname"].ToString() == "Işık")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_garajisik.Image = imglist.Images[1];
                        btn_garajisik.Text = "Kapalı";
                        btn_garajisik.BackColor = Color.Red;
                    }
                    else
                    {
                        picbox_garajisik.Image = imglist.Images[0];
                        btn_garajisik.Text = "Açık";
                        btn_garajisik.BackColor = Color.Green;
                    }
                }
                else if (data["toollocation"].ToString() == "Bahçe" && data["toolname"].ToString() == "Işık")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_bahce.Image = imglist.Images[1];
                        btn_bahceisik.Text = "Kapalı";
                        btn_bahceisik.BackColor = Color.Red;
                    }
                    else
                    {
                        picbox_bahce.Image = imglist.Images[0];
                        btn_bahceisik.Text = "Açık";
                        btn_bahceisik.BackColor = Color.Green;
                    }
                }
                else if (data["toolname"].ToString() == "Perde")
                {

                    lbl_perde.Text = data["toolstatus"].ToString();
                    if (data["toolstatus"].ToString() == "Kapalı") trackBar1.Value = 0;
                    else if (data["toolstatus"].ToString() == "%50 Açık") trackBar1.Value = 1;
                    else trackBar1.Value = 2;
                }
                else if (data["toolname"].ToString() == "Fıskiye")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        btn_fiskiye.BackColor = Color.Red;
                        btn_fiskiye.Text = "Kapalı";

                    }
                    else
                    {
                        btn_fiskiye.BackColor = Color.Green;
                        btn_fiskiye.Text = "Açık";
                    }
                }
                else if (data["toolname"].ToString() == "Su Vanası")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        btn_suvana.BackColor = Color.Red;
                        btn_suvana.Text = "Kapalı";
                    }
                    else
                    {
                        btn_suvana.BackColor = Color.Green;
                        btn_suvana.Text = "Açık";
                    }
                }
                else if (data["toolname"].ToString() == "Kapı" && data["toollocation"].ToString() == "Garaj")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_garage.Image = imglist.Images[4];
                        btn_garajkapi.BackColor = Color.Red;
                        btn_garajkapi.Text = "Kapalı";
                    }
                    else
                    {
                        picbox_garage.Image = imglist.Images[3];
                        btn_garajkapi.BackColor = Color.Green;
                        btn_garajkapi.Text = "Açık";
                    }
                }
                else if (data["toolname"].ToString() == "Kapı" && data["toollocation"].ToString() == "Ev")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_evkapi.Image = imglist.Images[5];
                        btn_evkapi.BackColor = Color.Red;
                        btn_evkapi.Text = "Kapalı";
                    }
                    else
                    {
                        picbox_evkapi.Image = imglist.Images[6];
                        btn_evkapi.BackColor = Color.Green;
                        btn_evkapi.Text = "Açık";
                    }
                }
                else if (data["toolname"].ToString() == "Güvenlik" && data["toollocation"].ToString() == "Ev")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_guvenlik.Image = imglist.Images[10];
                        lbl_guvenlik.Text = "Güvenlik Mod : Kapalı";
                    }
                    else
                    {
                        picbox_guvenlik.Image = imglist.Images[9];
                        lbl_guvenlik.Text = "Güvenlik Mod : Açık";
                    }
                }
                else if (data["toolname"].ToString() == "Klima")
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        picbox_klima.Image = imglist.Images[8];
                        btn_klima.BackColor = Color.Red;
                        btn_klima.Text = "Kapalı";

                    }
                    else
                    {
                        picbox_klima.Image = imglist.Images[7];
                        btn_klima.BackColor = Color.Green;
                        btn_klima.Text = "Açık";
                    }
                }

            }
            cmd.Dispose();
            data.Close();
            aktivitehesapla(toolid);
        }

        public void aktivitehesapla(int id) {

            SqlCommand cmdsulama = new SqlCommand("SELECT top 1 changes.changetime,tools.toolstatus from changes,tools where changes.changetoolid="+id+" and changes.changetoolid=tools.toolid order by changetime desc", conn.connect());
            SqlDataReader data = cmdsulama.ExecuteReader();
            while (data.Read())
            {
                if (id == 2)
                {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        lbl_sulamaaktivite.Text = "Bahçe en son " + data["changetime"].ToString() + " tarihinde sulandı.";
                        fiskiyehesapla = false;
                    }
                    else
                    {
                        fiskiyehesapla = true;
                        sonsulama = Convert.ToDateTime(data["changetime"]);
                    }
                }
                else if(id==5) {
                    if (data["toolstatus"].ToString() == "Kapalı")
                    {
                        lbl_klimaaktivite.Text = "Klima " + data["changetime"].ToString() + " tarihinden itibaren kapalı.";
                        klimahesapla = false;
                    }
                    else
                    {
                        klimahesapla = true;
                        sonklima = Convert.ToDateTime(data["changetime"]);
                    }
                }
               
            }
            cmdsulama.Dispose();
            data.Close();
            if (lbl_guvenlik.Text == "Güvenlik Mod : Kapalı") lbl_aktiviteguvenlik.Text = "Evinizin güvenliği pasif durumda. Riskli. ";
            else lbl_aktiviteguvenlik.Text = "Evinizin güvenliği aktif durumda. Güvende.";
        }

        public void databaseupdate(int id,string status) {

            try {
                barvalue(20);
                buffer[0] =Convert.ToByte(id);
                if (status == "Kapalı")
                {
                    afterstatus = "Açık";
                    buffer[1] = Convert.ToByte(1);
                }
                else {
                    afterstatus = "Kapalı";
                    buffer[1] = Convert.ToByte(0);
                }

                SqlCommand cmd = new SqlCommand("UPDATE tools SET toolstatus='" + afterstatus + "' WHERE toolid="+id, conn.connect());
                cmd.ExecuteNonQuery();
                barvalue(30);
                string sql = "INSERT INTO changes(changebeforestatus,changeafterstatus,changerid,changetoolid,changetime) VALUES(@beforestatus,@afterstatus,@changerid,@changetoolid,@changetime)";

                SqlCommand cmd2 = new SqlCommand(sql, conn.connect());

                cmd2.Parameters.AddWithValue("@beforestatus", status);
                cmd2.Parameters.AddWithValue("@afterstatus", afterstatus);
                cmd2.Parameters.AddWithValue("@changerid", lbl_userid.Text);
                cmd2.Parameters.AddWithValue("@changetoolid", id);
                cmd2.Parameters.AddWithValue("@changetime", DateTime.Now);

                cmd2.ExecuteNonQuery();

                barvalue(40);
                serialtoolsend(id);
                barvalue(60);
                imagesupdate(id);
                barvalue(80);
                logwrite();
                barvalue(100);
            }
            catch (Exception ex) {
                lbl_errorstate.Text = ex.ToString();
            }
            

        }

        private void display_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Hoşgeldiniz";
            
            try
            {
                serialPort1.Open();
                lbl_connectionstate.Text += " Açık";
                picbox_garajisik.Image = imglist.Images[1];
                picbox_oda3.Image = imglist.Images[1];

                SqlCommand cmd = new SqlCommand("SELECT * FROM tools", conn.connect());
                SqlDataReader data = cmd.ExecuteReader();
                s = 0;
                while (data.Read())
                {
                    s++;
                    barvalue((s * 5) + 40);


                    if (data["toollocation"].ToString() == "Salon" && data["toolname"].ToString() == "Işık")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_salon.Image = imglist.Images[1];
                            btn_salonisik.Text = "Kapalı";
                            btn_salonisik.BackColor = Color.Red;
                        }
                        else
                        {
                            picbox_salon.Image = imglist.Images[0];
                            btn_salonisik.Text = "Açık";
                            btn_salonisik.BackColor = Color.Green;
                        }
                    }
                    else if (data["toolname"].ToString() == "Güvenlik" && data["toollocation"].ToString() == "Ev")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_guvenlik.Image = imglist.Images[10];
                            lbl_guvenlik.Text = "Güvenlik Mod : Kapalı";
                        }
                        else
                        {
                            picbox_guvenlik.Image = imglist.Images[9];
                            lbl_guvenlik.Text = "Güvenlik Mod : Açık";
                        }
                    }
                    else if (data["toollocation"].ToString() == "Oda" && data["toolname"].ToString() == "Işık")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_oda.Image = imglist.Images[1];
                            btn_odaisik.Text = "Kapalı";
                            btn_odaisik.BackColor = Color.Red;
                        }
                        else
                        {
                            picbox_oda.Image = imglist.Images[0];
                            btn_odaisik.Text = "Açık";
                            btn_odaisik.BackColor = Color.Green;
                        }
                    }
                    else if (data["toollocation"].ToString() == "Garaj" && data["toolname"].ToString() == "Işık")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_garajisik.Image = imglist.Images[1];
                            btn_garajisik.Text = "Kapalı";
                            btn_garajisik.BackColor = Color.Red;
                        }
                        else
                        {
                            picbox_garajisik.Image = imglist.Images[0];
                            btn_garajisik.Text = "Açık";
                            btn_garajisik.BackColor = Color.Green;
                        }
                    }
                    else if (data["toollocation"].ToString() == "Bahçe" && data["toolname"].ToString() == "Işık")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_bahce.Image = imglist.Images[1];
                            btn_bahceisik.Text = "Kapalı";
                            btn_bahceisik.BackColor = Color.Red;
                        }
                        else
                        {
                            picbox_bahce.Image = imglist.Images[0];
                            btn_bahceisik.Text = "Açık";
                            btn_bahceisik.BackColor = Color.Green;
                        }
                    }
                    else if (data["toolname"].ToString() == "Perde")
                    {

                        lbl_perde.Text = data["toolstatus"].ToString();
                        if (data["toolstatus"].ToString() == "Kapalı") trackBar1.Value = 0;
                        else if (data["toolstatus"].ToString() == "%50 Açık") trackBar1.Value = 1;
                        else trackBar1.Value = 2;
                    }
                    else if (data["toolname"].ToString() == "Fıskiye")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            btn_fiskiye.BackColor = Color.Red;
                            btn_fiskiye.Text = "Kapalı";
                        }
                        else
                        {
                            btn_fiskiye.BackColor = Color.Green;
                            btn_fiskiye.Text = "Açık";
                        }
                        aktivitehesapla(Convert.ToInt32(data["toolid"]));
                    }
                    else if (data["toolname"].ToString() == "Su Vanası")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            btn_suvana.BackColor = Color.Red;
                            btn_suvana.Text = "Kapalı";
                        }
                        else
                        {
                            btn_suvana.BackColor = Color.Green;
                            btn_suvana.Text = "Açık";
                        }
                    }
                    else if (data["toolname"].ToString() == "Kapı" && data["toollocation"].ToString() == "Garaj")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_garage.Image = imglist.Images[4];
                            btn_garajkapi.BackColor = Color.Red;
                            btn_garajkapi.Text = "Kapalı";
                        }
                        else
                        {
                            picbox_garage.Image = imglist.Images[3];
                            btn_garajkapi.BackColor = Color.Green;
                            btn_garajkapi.Text = "Açık";
                        }
                    }
                    else if (data["toolname"].ToString() == "Kapı" && data["toollocation"].ToString() == "Ev")
                    {
                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_evkapi.Image = imglist.Images[5];
                            btn_evkapi.BackColor = Color.Red;
                            btn_evkapi.Text = "Kapalı";
                        }
                        else
                        {
                            picbox_evkapi.Image = imglist.Images[6];
                            btn_evkapi.BackColor = Color.Green;
                            btn_evkapi.Text = "Açık";
                        }
                    }
                    else if (data["toolname"].ToString() == "Klima")
                    {

                        if (data["toolstatus"].ToString() == "Kapalı")
                        {
                            picbox_klima.Image = imglist.Images[8];
                            btn_klima.BackColor = Color.Red;
                            btn_klima.Text = "Kapalı";
                        }
                        else
                        {
                            picbox_klima.Image = imglist.Images[7];
                            btn_klima.BackColor = Color.Green;
                            btn_klima.Text = "Açık";
                        }
                        aktivitehesapla(Convert.ToInt32(data["toolid"]));
                    }

                }
                cmd.Dispose();
                data.Close();
                serimesaj = "03";
                if (lbl_guvenlik.Text == "Güvenlik Mod : Kapalı") serimesaj = serimesaj + "0";
                else serimesaj = serimesaj + "1";

                serialPort1.Write(serimesaj);


            }
            catch (Exception ex) {
                MessageBox.Show("Hata" + ex);
                lbl_connectionstate.Text += " Kapalı";
            }
            timer1.Start();
            serialPort1.Write("330");
            trackbarstatus = trackBar1.Value.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int intreturnascii = 0;
            char charreturnvalue = (char)intreturnascii;
            int count = serialPort1.BytesToRead;
            string returnmessage = "";

            while (count > 0)
            {
                intreturnascii = serialPort1.ReadByte();
                returnmessage = returnmessage + Convert.ToChar(intreturnascii);
                count--;
            }
            
            lbl_time.Text = DateTime.Now.ToLongTimeString() + "\n" + DateTime.Now.ToLongDateString();
            if (fiskiyehesapla == true)
            {
                TimeSpan zaman = DateTime.Now.Subtract(sonsulama);
                lbl_sulamaaktivite.Text = "Bahçenin sulama sistemi " + Convert.ToString(Convert.ToInt32(zaman.TotalMinutes)) + " dakikadır açık.";
            }
            if (klimahesapla == true)
            {
                TimeSpan zaman = DateTime.Now.Subtract(sonklima);
                lbl_klimaaktivite.Text = "Klima " + Convert.ToString(Convert.ToInt32(zaman.TotalMinutes)) + " dakikadır açık durumda.";
            }



            if (returnmessage == "155")
            {
                try
                {
                    string sql = "INSERT INTO changes(changebeforestatus,changeafterstatus,changerid,changetoolid,changetime) VALUES(@beforestatus,@afterstatus,@changerid,@changetoolid,@changetime)";

                    SqlCommand cmd2 = new SqlCommand(sql, conn.connect());

                    cmd2.Parameters.AddWithValue("@beforestatus", "Hareket");
                    cmd2.Parameters.AddWithValue("@afterstatus", "Aldı");
                    cmd2.Parameters.AddWithValue("@changerid", "1008");
                    cmd2.Parameters.AddWithValue("@changetoolid", "11");
                    cmd2.Parameters.AddWithValue("@changetime", DateTime.Now);

                    cmd2.ExecuteNonQuery();

                    if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10) ay = "0" + DateTime.Now.Month.ToString();
                    else ay = DateTime.Now.Month.ToString();
                    logname = DateTime.Now.Day.ToString() + ay + DateTime.Now.Year.ToString();
                    StreamWriter sw = new StreamWriter(logname + ".txt");

                    SqlCommand cmd = new SqlCommand("SELECT MAX(changeid),changetime,changerid,changetoolid,changebeforestatus,changeafterstatus FROM changes Group by changetime,changerid,changetoolid,changebeforestatus,changeafterstatus", conn.connect());
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        string log = data["changetime"].ToString() + " " + data["changerid"].ToString() + " " + data["changetoolid"].ToString() + " " + data["changebeforestatus"].ToString() + " " + data["changeafterstatus"].ToString();
                        sw.WriteLine(log);
                    }
                    cmd.Dispose();
                    data.Close();
                    sw.Close();

                    lbl_acilgiris.Text = DateTime.Now + " anında beklenmeyen hareket görüldü.";

                }
                catch (Exception ex)
                {
                    lbl_errorstate.Text = ex.Message;
                }
            }

                try
                {
                    if (returnmessage != "1/1")
                    {
                        gelen = returnmessage.Split('/');
                        lbl_sicaklik.Text = "% " + gelen[0].Substring(0, 4);
                        lbl_nem.Text = gelen[1].Substring(0, 4) + " °C";
                    }                                           
                }
                catch (Exception ex) {

                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_salonisik_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(6,btn_salonisik.Text);
        }

        private void btn_odaisik_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(9, btn_odaisik.Text); 
        }  

        private void btn_bahceisik_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(7, btn_bahceisik.Text);
        }

        private void btn_fiskiye_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(2, btn_fiskiye.Text);
        }

        private void btn_suvana_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(8, btn_suvana.Text);
        }

        private void btn_garajkapi_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(4, btn_garajkapi.Text);
        }

        private void btn_evkapi_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(10, btn_evkapi.Text);
        }

        private void btn_klima_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(5, btn_klima.Text);
        }

        private void kullanıcılarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userprocess yeni = new userprocess();
            yeni.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
         

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void trackBar1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void trackBar1_DragOver(object sender, DragEventArgs e)
        {
  
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            
   
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                if (trackBar1.Value == 0) lbl_perde.Text = "Kapalı";
                else if (trackBar1.Value == 1) lbl_perde.Text = "%50 Açık";
                else lbl_perde.Text = "%100 Açık";

                SqlCommand cmdbeforestatus = new SqlCommand("SELECT toolstatus FROM tools WHERE toolname='Perde'", conn.connect());
                SqlDataReader data = cmdbeforestatus.ExecuteReader();
                while (data.Read()) beforestatus = data["toolstatus"].ToString();

                if (beforestatus != lbl_perde.Text)
                {
                    string sql = "INSERT INTO changes(changebeforestatus,changeafterstatus,changerid,changetoolid,changetime) VALUES(@beforestatus,@afterstatus,@changerid,@changetoolid,@changetime)";

                    SqlCommand cmd = new SqlCommand(sql, conn.connect());

                    cmd.Parameters.AddWithValue("@beforestatus", beforestatus);
                    cmd.Parameters.AddWithValue("@afterstatus", lbl_perde.Text);
                    cmd.Parameters.AddWithValue("@changerid", lbl_userid.Text);
                    cmd.Parameters.AddWithValue("@changetoolid", 1);
                    cmd.Parameters.AddWithValue("@changetime", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmdupdate = new SqlCommand("UPDATE tools SET toolstatus='" + lbl_perde.Text + "' WHERE toolname='Perde' ", conn.connect());
                    cmdupdate.ExecuteNonQuery();

                    serimesaj = "01" + trackBar1.Value.ToString();
                    serialPort1.Write(serimesaj);
                    timer2.Start();
                    label28.Text = serimesaj;
                    pnl_display.Enabled = false;

                    imagesupdate(1);

                    data.Close();
                    cmd.Dispose();
                    cmdupdate.Dispose();

                    trackbarstatus = trackBar1.Value.ToString();

                }
           
            }
            catch (Exception ex) {
                lbl_errorstate.Text = ex.ToString();
            }
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {

            trackbarstatus = trackBar1.Value.ToString();

        }      

        private void picbox_kamera_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void bilgilerimiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (lbl_userid.Text != "1002") {
                serialPort1.Close();
                ebeveyn yeni = new ebeveyn();
                yeni.lbl_username.Text = lbl_user.Text;
                yeni.lbl_userid.Text = lbl_userid.Text;
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok. Oturum '" + lbl_user.Text + "' olarak açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_cikis.PerformClick();
        }

        private void kullanıcılarıGörToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (lbl_userid.Text == "2")
            {
                serialPort1.Close();
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok. Oturum '" + lbl_user.Text + "' olarak açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                serialPort1.Close();
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok. Oturum '" + lbl_user.Text + "' olarak açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                serialPort1.Close();
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok. Oturum '"+lbl_user.Text+"' olarak açık","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void geçmişGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_userid.Text == "2")
            {
                serialPort1.Close();
                userprocess yeni = new userprocess();
                yeni.Show();
                this.Hide();
            }
            else MessageBox.Show("Buraya Görme Yetkiniz Yok. Oturum '" + lbl_user.Text + "' olarak açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            menu yeni = new menu();
            yeni.Show();
            this.Hide();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (sayac2 ==20)
            {
                timer2.Stop();
                pnl_display.Enabled = true;
                sayac2 = 0;
            }
            else {
                sayac2++;
                barvalue(sayac2 *5);
            }
            
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

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

        private void picbox_guvenlik_Click(object sender, EventArgs e)
        {
                
            }

        private void picbox_guvenlik_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                barvalue(20);
                if (lbl_guvenlik.Text=="Güvenlik Mod : Kapalı")
                {
                    beforestatus = "Kapalı";
                    afterstatus = "Açık";
                }
                else
                {
                    beforestatus = "Açık";
                    afterstatus = "Kapalı";
                }

                SqlCommand cmd = new SqlCommand("UPDATE tools SET toolstatus='" + afterstatus + "' WHERE toolid=" + 3, conn.connect());
                cmd.ExecuteNonQuery();
                barvalue(30);
                string sql = "INSERT INTO changes(changebeforestatus,changeafterstatus,changerid,changetoolid,changetime) VALUES(@beforestatus,@afterstatus,@changerid,@changetoolid,@changetime)";

                SqlCommand cmd2 = new SqlCommand(sql, conn.connect());

                cmd2.Parameters.AddWithValue("@beforestatus", beforestatus);
                cmd2.Parameters.AddWithValue("@afterstatus", afterstatus);
                cmd2.Parameters.AddWithValue("@changerid", lbl_userid.Text);
                cmd2.Parameters.AddWithValue("@changetoolid", 3);
                cmd2.Parameters.AddWithValue("@changetime", DateTime.Now);

                cmd2.ExecuteNonQuery();

                barvalue(40);
                serimesaj = "03";

                if (afterstatus == "Kapalı") serimesaj = serimesaj + "0";
                else serimesaj = serimesaj + "1";

                serialPort1.Write(serimesaj);
                label28.Text = serimesaj;

                barvalue(60);
                imagesupdate(3);
                barvalue(80);
                logwrite();
                barvalue(100);
                aktivitehesapla(3);
            }
            catch (Exception ex)
            {
                lbl_errorstate.Text = ex.ToString();
            }
        }

        private void btn_garajisik_Click(object sender, EventArgs e)
        {
            barvalue(0);
            databaseupdate(12, btn_garajisik.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pnl_display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == 0){
                serialPort1.Write("330");
            }
            else if(comboBox1.SelectedIndex == 1){
                serialPort1.Write("331");
            }
            else if(comboBox1.SelectedIndex == 2){
                serialPort1.Write("332");
            }
            else if(comboBox1.SelectedIndex == 3){
                serialPort1.Write("333");
            }
            else{
                serialPort1.Write("334");
            }
            
        }


    }
}
