namespace SmartHome
{
    partial class control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(158, 20);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 0;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(158, 46);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(100, 20);
            this.txt_pw.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(80, 23);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Kullanıcı Adı";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(116, 49);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(28, 13);
            this.lblpw.TabIndex = 4;
            this.lblpw.Text = "Şifre";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(115, 101);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::SmartHome.Properties.Resources.go_back_icon;
            this.button2.Location = new System.Drawing.Point(11, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 114);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(277, 134);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "control";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}