using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;




namespace RemoteManagerv2
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            //Initialize Form
            InitializeComponent();
        }
        static class Global
        {
            //Create hashtables for CSV-Values
            public static Hashtable pcs = new Hashtable(); //id and hostname 
            public static Hashtable pcsInfo = new Hashtable(); //id and infotext
            public static Hashtable pcsURLName = new Hashtable(); //id and URL-Name
            public static Hashtable pcsURL = new Hashtable(); //id and URL
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set loading-status to false
            isLoadingIP(false);
            isLoading(false);
            //resize form to small
            this.Size = new Size(36, 56);
            //Reading computers.csv
            using (var reader = new StreamReader(@"computers.csv"))
            {
                //Create 3 treenodes for each department
                TreeNode tankstellenTree = new TreeNode("Tankstellen");
                TreeNode carpoolTree = new TreeNode("Carpool");
                TreeNode sonstigesTree = new TreeNode("Sonstige");

                //Read each line of csv
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); //split line at semicolon
                    //fill hashtables
                    Global.pcs.Add(values[0], values[1]);
                    Global.pcsInfo.Add(values[0], values[3]);
                    Global.pcsURLName.Add(values[0], values[4]);
                    Global.pcsURL.Add(values[0], values[5]);
                    //Add pcs to appropriate node
                    if (values[2] == "Carpool")
                    {
                        carpoolTree.Nodes.Add(values[0]);
                    }
                    else if (values[2] == "Tankstelle")
                    {
                        tankstellenTree.Nodes.Add(values[0]);
                    }
                    else
                    {
                        sonstigesTree.Nodes.Add(values[0]);
                    }
                }
                //Append treenodes to treeview
                treeView1.Nodes.Add(tankstellenTree);
                treeView1.Nodes.Add(carpoolTree);
                treeView1.Nodes.Add(sonstigesTree);
            }
        }

        private void toggleMenu_Click(object sender, EventArgs e) //handles the open/close functionallity
        {
            if (toggleMenu.Text == "<")
            {
                this.Size = new Size(36, 56);
                toggleMenu.Text = ">";
            }
            else
            {
                this.Size = new Size(900, 670);
                toggleMenu.Text = "<";
            }
        }

        private async void treeView1_AfterSelectAsync(object sender, TreeViewEventArgs e) //handels treeview selection
        {
            if (Global.pcs.ContainsKey(e.Node.Text))
            {
                //fill form with informations
                var dns = (string)Global.pcs[e.Node.Text];
                pcname.Text = e.Node.Text;
                dnsname.Text = dns;
                infoText.Text = (string)Global.pcsInfo[e.Node.Text];
                URL.Text = (string)Global.pcsURLName[e.Node.Text];
                URL.Links.Clear();
                URL.Links.Add(0, 0, Global.pcsURL[e.Node.Text]);
                iplabel.Text = "";

                //set loadingIP state to true
                isLoadingIP(true);

                //load IP
                try
                {
                    iplabel.Text = await getIP(dns);    //async ip loading
                }
                catch
                {
                    iplabel.Text = "IP nicht gefunden!"; //onerror = IP not found
                }
                isLoadingIP(false);

                //Try to ping pc async
                pingstatus.Text = "Ping: ...";
                pingstatus.ForeColor = System.Drawing.Color.Black;
                try
                {
                    var pingstat = await PingAsync(dns);
                    if (pingstat == "Success")
                    {
                        pingstatus.Text = "Ping: " + pingstat;
                        pingstatus.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        pingstatus.Text = "Ping: " + pingstat;
                        pingstatus.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch
                {
                    pingstatus.Text = "Ping: Fehlgeschlagen"; //onerror = ping failed
                    pingstatus.ForeColor = System.Drawing.Color.Red;
                }




            }


        }

        public async Task<String> getIP(String dns) // Load the IP async to avoid UI freezing
        {
            var ip = await Dns.GetHostAddressesAsync(dns);
            return ip[0].ToString();
        }

        public async Task<String> PingAsync(String addressIp, TimeSpan? timeout = null) // PING async to avoid UI freezing
        {
            var ping = new Ping();
            if (timeout.HasValue)
            {
                return await ping.SendPingAsync(addressIp, timeout.Value.Milliseconds)
                    .ContinueWith(pingTask => pingTask.Result.Status.ToString());
            }

            return await ping.SendPingAsync(addressIp)
                .ContinueWith(pingTask => pingTask.Result.Status.ToString());
        }

        public void isLoading(Boolean status) //show/hide isLoading spinner
        {
            pictureBox2.Visible = status;
            okstate.Visible = !status;
            pictureBox2.Refresh();
            okstate.Refresh();
        }

        public void isLoadingIP(Boolean status) //show/hide isLoadingIP spinner
        {
            pictureBox1.Visible = status;
            pictureBox1.Refresh();
        }

        private void autologonOFF_Click(object sender, EventArgs e)
        {
            isLoading(true);
            try
            {
                // Open SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon
                // on a remote computer.
                RegistryKey rekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, dnsname.Text).CreateSubKey
                    ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                if (rekey == null)
                    MessageBox.Show
                    ("Fehler beim Schreiben in die Windows Registry!"); //Show Error
                else
                {
                    //set AutoAdminLogon
                    rekey.SetValue("AutoAdminLogon", "0");
                    MessageBox.Show
                        ("AutoAdminLogon deaktiviert!");
                }
                //close the RegistryKey object
                rekey.Close();
            }
            catch
            {
                MessageBox.Show("Fehler, Netzwerkpfad ungültig oder fehlende Berechtigung!");
            }
            finally
            {
                isLoading(false);
            }
        }

        private void autologonON_Click(object sender, EventArgs e)
        {
            isLoading(true);
            try
            {
                // Open SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon
                // on a remote computer.
                RegistryKey rekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, dnsname.Text).CreateSubKey
                    ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                if (rekey == null)
                    MessageBox.Show
                    ("Fehler beim Schreiben in die Windows Registry!");
                else
                {
                    //set AutoAdminLogon
                    rekey.SetValue("AutoAdminLogon", "1");
                    MessageBox.Show
                        ("AutoAdminLogon aktiviert!");
                }
                //close the RegistryKey object
                rekey.Close();
            }
            catch
            {
                MessageBox.Show("Fehler, Netzwerkpfad ungültig oder fehlende Berechtigung!");
            }
            finally
            {
                isLoading(false);
            }
        }

        private void remote_Click(object sender, EventArgs e)
        {
            isLoading(true);
            try
            {
                // Open SOFTWARE\\Microsoft\\SMS\\Client\\Client Components\\Remote Control 
                // AND SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System
                // on a remote computer.
                RegistryKey rekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, dnsname.Text).CreateSubKey
                    ("SOFTWARE\\Microsoft\\SMS\\Client\\Client Components\\Remote Control");
                RegistryKey rekey2 = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, dnsname.Text).CreateSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                if (rekey == null || rekey2 == null)
                    MessageBox.Show
                    ("Fehler beim Schreiben in die Windows Registry!");
                else
                {
                    //Allow Remote Control of an unattended computer
                    rekey.SetValue("Permission Required", 0);
                    rekey.SetValue("Allow Remote Control of an unattended computer", 1);
                    rekey2.SetValue("SoftwareSASGeneration", 3);
                    MessageBox.Show
                        ("Verbindung wird hergestellt mit " + dnsname.Text + " (" + pcname.Text + "). Bitte mit OK bestätigen.");

                    //TODO REPLACE EXAMPLE URL WITH YOUR URL
                    var proc = Process.Start("\\\\example.com\\NETLOGON\\ARS\\CmRcViewerOld2104.exe", dnsname.Text); //Start external programm for remote connection

                }
                //close the RegistryKey object
                rekey.Close();
            }
            catch
            {
                MessageBox.Show("Fehler, Netzwerkpfad ungültig oder fehlende Berechtigung!");
            }
            finally
            {
                isLoading(false);
            }
        }

        private void explorer_Click(object sender, EventArgs e) //open filesystem (drive C:) of remote pc
        {
            try
            {
                string location = "\\\\" + dnsname.Text + "\\c$";
                Process.Start("explorer.exe", @location);
            }
            catch
            {
                MessageBox.Show("Fehler, Netzwerkpfad ungültig oder fehlende Berechtigung!");
            }
        }

        private void URL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            // If target, navigate to it.
            if (null != target)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Keine URL vorhanden! " + target);
            }
        }

        private void Linksammlung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Link to website
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                //TODO REPLACE EXAMPLE URL WITH YOUR URL
                FileName = "https://example.com",
                UseShellExecute = true
            });
        }
    }
}
