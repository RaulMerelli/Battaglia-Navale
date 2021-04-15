using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace MerelliBattleShip
{
    public partial class Create : Form
    {
        public DialogResult Status { get; private set; }
        public object SiteUp { get; private set; }

        string HostfileName = @"\Users\Public\Videos\host_gamedata.BS";
        string ClientfileName = @"\Users\Public\Videos\client_gamedata.BS";
        string finalpath;
        public string pathOrIP;
        bool validated = true;

        public Create()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dim.Text = trackBar1.Value.ToString();
        }

        void deleteOldFiles()
        {
            if (File.Exists(pathOrIP + HostfileName))
            {
                File.Delete(pathOrIP + HostfileName);
            }
            if (File.Exists(pathOrIP + ClientfileName))
            {
                File.Delete(pathOrIP + ClientfileName);
            }
            if (File.Exists(pathOrIP + @"\Users\Public\Videos\" + "host_table.BS"))
            {
                File.Delete(pathOrIP + @"\Users\Public\Videos\" + "host_table.BS");
            }
            if (File.Exists(pathOrIP + @"\Users\Public\Videos\" + "client_table.BS"))
            {
                File.Delete(pathOrIP + @"\Users\Public\Videos\" + "client_table.BS");
            }
            if (File.Exists(pathOrIP + @"\Users\Public\Videos\" + "host_colpo.BS"))
            {
                File.Delete(pathOrIP + @"\Users\Public\Videos\" + "host_colpo.BS");
            }
            if (File.Exists(pathOrIP + @"\Users\Public\Videos\" + "client_colpo.BS"))
            {
                File.Delete(pathOrIP + @"\Users\Public\Videos\" + "client_colpo.BS");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            if (radioButton2.Checked)
            {
                IPAddress address;
                if (IPAddress.TryParse(textBox2.Text, out address))
                {
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(address);
                    if (reply.Status != IPStatus.Success)
                    {
                        MessageBox.Show("Indirizzo IP non raggiungibile.");
                        validated = false;
                    }
                    else
                    {
                        finalpath = @"\\" + textBox2.Text + HostfileName;
                        pathOrIP = @"\\" + textBox2.Text;
                        deleteOldFiles();
                        using (FileStream fs = File.Create(@"\\" + textBox2.Text + HostfileName))
                        {
                            byte[] text;
                            text = new UTF8Encoding(true).GetBytes(trackBar1.Value.ToString() + "\n" + textBox1.Text);
                            fs.Write(text, 0, text.Length);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Indirizzo IP non valido.");
                    validated = false;
                }
            }
            else
            {
                finalpath = @"C:" + HostfileName;
                pathOrIP = @"C:";

                deleteOldFiles();
                using (FileStream fs = File.Create(@"C:" + HostfileName))
                {
                    byte[] text;
                    text = new UTF8Encoding(true).GetBytes(trackBar1.Value.ToString() + "\n" + textBox1.Text);
                    fs.Write(text, 0, text.Length);
                }
            }
            if (validated)
            {
                this.Hide();
                Status = game.ShowDialog(this);
                if (Status == DialogResult.OK)
                {
                    this.Show();
                }
            }
            if (Status == DialogResult.Abort)
            {
                if (File.Exists(finalpath))
                {
                    File.Delete(finalpath);
                }
                this.DialogResult = DialogResult.Abort;
                game.Dispose();
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validated = true;
        }
    }
}
