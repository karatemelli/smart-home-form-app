namespace SmartHome
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.label1 = new System.Windows.Forms.Label();
            this.lstbox_log = new System.Windows.Forms.ListBox();
            this.btn_showlog = new System.Windows.Forms.Button();
            this.tree_tarih = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilerimiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eviYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorunBildirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tree_users = new System.Windows.Forms.TreeView();
            this.tree_tools = new System.Windows.Forms.TreeView();
            this.lbl_filtre = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrele : ";
            // 
            // lstbox_log
            // 
            this.lstbox_log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbox_log.FormattingEnabled = true;
            this.lstbox_log.HorizontalScrollbar = true;
            this.lstbox_log.ItemHeight = 14;
            this.lstbox_log.Location = new System.Drawing.Point(166, 79);
            this.lstbox_log.Name = "lstbox_log";
            this.lstbox_log.Size = new System.Drawing.Size(720, 494);
            this.lstbox_log.TabIndex = 3;
            // 
            // btn_showlog
            // 
            this.btn_showlog.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_showlog.FlatAppearance.BorderSize = 0;
            this.btn_showlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showlog.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_showlog.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_showlog.Location = new System.Drawing.Point(12, 550);
            this.btn_showlog.Name = "btn_showlog";
            this.btn_showlog.Size = new System.Drawing.Size(149, 23);
            this.btn_showlog.TabIndex = 4;
            this.btn_showlog.Text = "Listele >>";
            this.btn_showlog.UseVisualStyleBackColor = false;
            this.btn_showlog.Click += new System.EventHandler(this.button1_Click);
            // 
            // tree_tarih
            // 
            this.tree_tarih.Location = new System.Drawing.Point(12, 58);
            this.tree_tarih.Name = "tree_tarih";
            this.tree_tarih.Size = new System.Drawing.Size(149, 171);
            this.tree_tarih.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "Sorgu Sonucu : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(691, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
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
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 7;
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
            // bilgilerimiDüzenleToolStripMenuItem
            // 
            this.bilgilerimiDüzenleToolStripMenuItem.Image = global::SmartHome.Properties.Resources.edit_icon;
            this.bilgilerimiDüzenleToolStripMenuItem.Name = "bilgilerimiDüzenleToolStripMenuItem";
            this.bilgilerimiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bilgilerimiDüzenleToolStripMenuItem.Text = "Bilgilerimi Düzenle";
            this.bilgilerimiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimiDüzenleToolStripMenuItem_Click_1);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = global::SmartHome.Properties.Resources.exit;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
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
            // kullanıcılarıGörToolStripMenuItem
            // 
            this.kullanıcılarıGörToolStripMenuItem.Image = global::SmartHome.Properties.Resources.Search_icon;
            this.kullanıcılarıGörToolStripMenuItem.Name = "kullanıcılarıGörToolStripMenuItem";
            this.kullanıcılarıGörToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcılarıGörToolStripMenuItem.Text = "Kullanıcıları Gör";
            this.kullanıcılarıGörToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıGörToolStripMenuItem_Click_1);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Image = global::SmartHome.Properties.Resources.deleteuser;
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click_1);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Image = global::SmartHome.Properties.Resources.Add_Male_User_icon;
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click_1);
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
            // eviYönetToolStripMenuItem
            // 
            this.eviYönetToolStripMenuItem.Image = global::SmartHome.Properties.Resources.house1;
            this.eviYönetToolStripMenuItem.Name = "eviYönetToolStripMenuItem";
            this.eviYönetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.eviYönetToolStripMenuItem.Text = "Evi Yönet";
            this.eviYönetToolStripMenuItem.Click += new System.EventHandler(this.eviYönetToolStripMenuItem_Click);
            // 
            // geçmişGörToolStripMenuItem
            // 
            this.geçmişGörToolStripMenuItem.Image = global::SmartHome.Properties.Resources.key_icon;
            this.geçmişGörToolStripMenuItem.Name = "geçmişGörToolStripMenuItem";
            this.geçmişGörToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.geçmişGörToolStripMenuItem.Text = "Geçmişi Gör";
            this.geçmişGörToolStripMenuItem.Click += new System.EventHandler(this.geçmişGörToolStripMenuItem_Click);
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
            // tree_users
            // 
            this.tree_users.Location = new System.Drawing.Point(12, 400);
            this.tree_users.Name = "tree_users";
            this.tree_users.Size = new System.Drawing.Size(149, 144);
            this.tree_users.TabIndex = 8;
            // 
            // tree_tools
            // 
            this.tree_tools.Location = new System.Drawing.Point(12, 235);
            this.tree_tools.Name = "tree_tools";
            this.tree_tools.Size = new System.Drawing.Size(149, 159);
            this.tree_tools.TabIndex = 9;
            // 
            // lbl_filtre
            // 
            this.lbl_filtre.AutoSize = true;
            this.lbl_filtre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_filtre.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_filtre.Location = new System.Drawing.Point(169, 58);
            this.lbl_filtre.Name = "lbl_filtre";
            this.lbl_filtre.Size = new System.Drawing.Size(51, 14);
            this.lbl_filtre.TabIndex = 10;
            this.lbl_filtre.Text = "Hepsi > ";
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Snow;
            this.btn_temizle.Location = new System.Drawing.Point(796, 53);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(90, 23);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(898, 611);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lbl_filtre);
            this.Controls.Add(this.tree_tools);
            this.Controls.Add(this.tree_users);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tree_tarih);
            this.Controls.Add(this.btn_showlog);
            this.Controls.Add(this.lstbox_log);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbox_log;
        private System.Windows.Forms.Button btn_showlog;
        private System.Windows.Forms.TreeView tree_tarih;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
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
        private System.Windows.Forms.TreeView tree_users;
        private System.Windows.Forms.TreeView tree_tools;
        private System.Windows.Forms.Label lbl_filtre;
        private System.Windows.Forms.Button btn_temizle;


    }
}