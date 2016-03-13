namespace SmartHome
{
    partial class userprocess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userprocess));
            this.smarthomeDataSet = new SmartHome.smarthomeDataSet();
            this.smarthomeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bilgilerimiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eviYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorunBildirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.smarthomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smarthomeDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smarthomeDataSet
            // 
            this.smarthomeDataSet.DataSetName = "smarthomeDataSet";
            this.smarthomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smarthomeDataSetBindingSource
            // 
            this.smarthomeDataSetBindingSource.DataSource = this.smarthomeDataSet;
            this.smarthomeDataSetBindingSource.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.evToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerimiDüzenleToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.hesapToolStripMenuItem.Text = "HESAP";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarıGörToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem,
            this.kullanıcıEkleToolStripMenuItem});
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.kullanıcılarToolStripMenuItem.Text = "KULLANICILAR";
            // 
            // evToolStripMenuItem
            // 
            this.evToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eviYönetToolStripMenuItem,
            this.geçmişGörToolStripMenuItem});
            this.evToolStripMenuItem.Name = "evToolStripMenuItem";
            this.evToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.evToolStripMenuItem.Text = "EV";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasılKullanılırToolStripMenuItem,
            this.sorunBildirToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yardımToolStripMenuItem.Text = "YARDIM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 229);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Kayıt Sayısı : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(602, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(17, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 8;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_surname.Location = new System.Drawing.Point(143, 74);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 22);
            this.txt_surname.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(274, 74);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 10;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telephone.Location = new System.Drawing.Point(406, 74);
            this.txt_telephone.MaxLength = 11;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(100, 22);
            this.txt_telephone.TabIndex = 11;
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pw.Location = new System.Drawing.Point(541, 74);
            this.txt_pw.MaxLength = 10;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(100, 22);
            this.txt_pw.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "İsim: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyisim : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(271, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(403, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(538, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Şifre : ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Image = global::SmartHome.Properties.Resources.add___Kopya;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(665, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 44);
            this.button3.TabIndex = 13;
            this.button3.Text = "Kaydet";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Image = global::SmartHome.Properties.Resources.refresh__freeiconsweb_net__99261;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(665, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Güncelle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bilgilerimiDüzenleToolStripMenuItem
            // 
            this.bilgilerimiDüzenleToolStripMenuItem.Image = global::SmartHome.Properties.Resources.edit_icon;
            this.bilgilerimiDüzenleToolStripMenuItem.Name = "bilgilerimiDüzenleToolStripMenuItem";
            this.bilgilerimiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bilgilerimiDüzenleToolStripMenuItem.Text = "Bilgilerimi Düzenle";
            this.bilgilerimiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimiDüzenleToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = global::SmartHome.Properties.Resources.exit;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // kullanıcılarıGörToolStripMenuItem
            // 
            this.kullanıcılarıGörToolStripMenuItem.Image = global::SmartHome.Properties.Resources.Search_icon;
            this.kullanıcılarıGörToolStripMenuItem.Name = "kullanıcılarıGörToolStripMenuItem";
            this.kullanıcılarıGörToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcılarıGörToolStripMenuItem.Text = "Kullanıcıları Gör";
            this.kullanıcılarıGörToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıGörToolStripMenuItem_Click);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Image = global::SmartHome.Properties.Resources.deleteuser;
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Image = global::SmartHome.Properties.Resources.Add_Male_User_icon;
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            // 
            // eviYönetToolStripMenuItem
            // 
            this.eviYönetToolStripMenuItem.Image = global::SmartHome.Properties.Resources.house1;
            this.eviYönetToolStripMenuItem.Name = "eviYönetToolStripMenuItem";
            this.eviYönetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eviYönetToolStripMenuItem.Text = "Evi Yönet";
            this.eviYönetToolStripMenuItem.Click += new System.EventHandler(this.eviYönetToolStripMenuItem_Click);
            // 
            // geçmişGörToolStripMenuItem
            // 
            this.geçmişGörToolStripMenuItem.Image = global::SmartHome.Properties.Resources.key_icon;
            this.geçmişGörToolStripMenuItem.Name = "geçmişGörToolStripMenuItem";
            this.geçmişGörToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.geçmişGörToolStripMenuItem.Text = "Geçmişi Gör";
            this.geçmişGörToolStripMenuItem.Click += new System.EventHandler(this.geçmişGörToolStripMenuItem_Click);
            // 
            // nasılKullanılırToolStripMenuItem
            // 
            this.nasılKullanılırToolStripMenuItem.Image = global::SmartHome.Properties.Resources.Question_Mark;
            this.nasılKullanılırToolStripMenuItem.Name = "nasılKullanılırToolStripMenuItem";
            this.nasılKullanılırToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nasılKullanılırToolStripMenuItem.Text = "Nasıl Kullanılır ?";
            this.nasılKullanılırToolStripMenuItem.Click += new System.EventHandler(this.nasılKullanılırToolStripMenuItem_Click);
            // 
            // sorunBildirToolStripMenuItem
            // 
            this.sorunBildirToolStripMenuItem.Image = global::SmartHome.Properties.Resources.ProblemReporterIconX;
            this.sorunBildirToolStripMenuItem.Name = "sorunBildirToolStripMenuItem";
            this.sorunBildirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sorunBildirToolStripMenuItem.Text = "Sorun Bildir";
            this.sorunBildirToolStripMenuItem.Click += new System.EventHandler(this.sorunBildirToolStripMenuItem_Click);
            // 
            // userprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(793, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userprocess";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.userprocess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smarthomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smarthomeDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private smarthomeDataSet smarthomeDataSet;
        private System.Windows.Forms.BindingSource smarthomeDataSetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimiDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarıGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eviYönetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasılKullanılırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorunBildirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}