
namespace RemoteManagerv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toggleMenu = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pcname = new System.Windows.Forms.Label();
            this.dnsname = new System.Windows.Forms.Label();
            this.iplabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.infoText = new System.Windows.Forms.Label();
            this.pingstatus = new System.Windows.Forms.Label();
            this.autologonON = new System.Windows.Forms.Button();
            this.autologonOFF = new System.Windows.Forms.Button();
            this.remote = new System.Windows.Forms.Button();
            this.explorer = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.okstate = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.LinkLabel();
            this.Linksammlung = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleMenu
            // 
            this.toggleMenu.BackColor = System.Drawing.Color.DarkRed;
            this.toggleMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.toggleMenu.FlatAppearance.BorderSize = 0;
            this.toggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleMenu.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toggleMenu.ForeColor = System.Drawing.Color.White;
            this.toggleMenu.Location = new System.Drawing.Point(0, 0);
            this.toggleMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.toggleMenu.Name = "toggleMenu";
            this.toggleMenu.Size = new System.Drawing.Size(36, 56);
            this.toggleMenu.TabIndex = 0;
            this.toggleMenu.Text = ">";
            this.toggleMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toggleMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toggleMenu.UseVisualStyleBackColor = false;
            this.toggleMenu.Click += new System.EventHandler(this.toggleMenu_Click);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(0, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(471, 607);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelectAsync);
            // 
            // pcname
            // 
            this.pcname.AutoSize = true;
            this.pcname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcname.Location = new System.Drawing.Point(477, 90);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(116, 32);
            this.pcname.TabIndex = 2;
            this.pcname.Text = "PC-Name";
            this.toolTip1.SetToolTip(this.pcname, "Doppelklick um Wert zu kopieren");
            // 
            // dnsname
            // 
            this.dnsname.AutoSize = true;
            this.dnsname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dnsname.Location = new System.Drawing.Point(477, 122);
            this.dnsname.Name = "dnsname";
            this.dnsname.Size = new System.Drawing.Size(136, 32);
            this.dnsname.TabIndex = 3;
            this.dnsname.Text = "DNS-Name";
            this.toolTip1.SetToolTip(this.dnsname, "Doppelklick um Wert zu kopieren");
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iplabel.Location = new System.Drawing.Point(477, 154);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(126, 32);
            this.iplabel.TabIndex = 4;
            this.iplabel.Text = "IP-Adresse";
            this.toolTip1.SetToolTip(this.iplabel, "Doppelklick um Wert zu kopieren");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(477, 197);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(0, 20);
            this.infoText.TabIndex = 13;
            this.toolTip1.SetToolTip(this.infoText, "Doppelklick um Wert zu kopieren");
            // 
            // pingstatus
            // 
            this.pingstatus.AutoSize = true;
            this.pingstatus.Location = new System.Drawing.Point(477, 247);
            this.pingstatus.Name = "pingstatus";
            this.pingstatus.Size = new System.Drawing.Size(0, 20);
            this.pingstatus.TabIndex = 15;
            this.toolTip1.SetToolTip(this.pingstatus, "Doppelklick um Wert zu kopieren");
            // 
            // autologonON
            // 
            this.autologonON.BackColor = System.Drawing.Color.DarkRed;
            this.autologonON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autologonON.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autologonON.ForeColor = System.Drawing.Color.White;
            this.autologonON.Location = new System.Drawing.Point(487, 406);
            this.autologonON.Name = "autologonON";
            this.autologonON.Size = new System.Drawing.Size(168, 63);
            this.autologonON.TabIndex = 6;
            this.autologonON.Text = "Autologon ON";
            this.autologonON.UseVisualStyleBackColor = false;
            this.autologonON.Click += new System.EventHandler(this.autologonON_Click);
            // 
            // autologonOFF
            // 
            this.autologonOFF.BackColor = System.Drawing.Color.DarkRed;
            this.autologonOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autologonOFF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autologonOFF.ForeColor = System.Drawing.Color.White;
            this.autologonOFF.Location = new System.Drawing.Point(687, 406);
            this.autologonOFF.Name = "autologonOFF";
            this.autologonOFF.Size = new System.Drawing.Size(168, 63);
            this.autologonOFF.TabIndex = 7;
            this.autologonOFF.Text = "Autologon OFF";
            this.autologonOFF.UseVisualStyleBackColor = false;
            this.autologonOFF.Click += new System.EventHandler(this.autologonOFF_Click);
            // 
            // remote
            // 
            this.remote.BackColor = System.Drawing.Color.DarkRed;
            this.remote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remote.ForeColor = System.Drawing.Color.White;
            this.remote.Location = new System.Drawing.Point(487, 495);
            this.remote.Name = "remote";
            this.remote.Size = new System.Drawing.Size(168, 63);
            this.remote.TabIndex = 8;
            this.remote.Text = "Remote- Verbindung";
            this.remote.UseVisualStyleBackColor = false;
            this.remote.Click += new System.EventHandler(this.remote_Click);
            // 
            // explorer
            // 
            this.explorer.BackColor = System.Drawing.Color.DarkRed;
            this.explorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explorer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.explorer.ForeColor = System.Drawing.Color.White;
            this.explorer.Location = new System.Drawing.Point(687, 495);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(168, 63);
            this.explorer.TabIndex = 9;
            this.explorer.Text = "Explorer";
            this.explorer.UseVisualStyleBackColor = false;
            this.explorer.Click += new System.EventHandler(this.explorer_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(487, 370);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(56, 20);
            this.status.TabIndex = 10;
            this.status.Text = "Status: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(538, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // okstate
            // 
            this.okstate.AutoSize = true;
            this.okstate.Location = new System.Drawing.Point(538, 370);
            this.okstate.Name = "okstate";
            this.okstate.Size = new System.Drawing.Size(29, 20);
            this.okstate.TabIndex = 12;
            this.okstate.Text = "OK";
            // 
            // URL
            // 
            this.URL.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.URL.AutoSize = true;
            this.URL.LinkColor = System.Drawing.Color.DarkRed;
            this.URL.Location = new System.Drawing.Point(477, 221);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(0, 20);
            this.URL.TabIndex = 14;
            this.URL.VisitedLinkColor = System.Drawing.Color.DarkRed;
            this.URL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URL_LinkClicked);
            // 
            // Linksammlung
            // 
            this.Linksammlung.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.Linksammlung.AutoSize = true;
            this.Linksammlung.LinkColor = System.Drawing.Color.DarkRed;
            this.Linksammlung.Location = new System.Drawing.Point(624, 575);
            this.Linksammlung.Name = "Linksammlung";
            this.Linksammlung.Size = new System.Drawing.Size(104, 20);
            this.Linksammlung.TabIndex = 16;
            this.Linksammlung.TabStop = true;
            this.Linksammlung.Text = "Linksammlung";
            this.Linksammlung.VisitedLinkColor = System.Drawing.Color.DarkRed;
            this.Linksammlung.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linksammlung_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1206, 768);
            this.ControlBox = false;
            this.Controls.Add(this.Linksammlung);
            this.Controls.Add(this.pingstatus);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.okstate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.explorer);
            this.Controls.Add(this.remote);
            this.Controls.Add(this.autologonOFF);
            this.Controls.Add(this.autologonON);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.dnsname);
            this.Controls.Add(this.pcname);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toggleMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 200);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RemoteManager v2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleMenu;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.Label dnsname;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button autologonON;
        private System.Windows.Forms.Button autologonOFF;
        private System.Windows.Forms.Button remote;
        private System.Windows.Forms.Button explorer;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label okstate;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.LinkLabel URL;
        private System.Windows.Forms.Label pingstatus;
        private System.Windows.Forms.LinkLabel Linksammlung;
    }
}

