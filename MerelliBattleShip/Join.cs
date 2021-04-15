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
    public partial class Join : Form
    {
        public DialogResult Status { get; private set; }
        string HostfileName = @"\Users\Public\Videos\host_gamedata.BS";
        string ClientfileName = @"\Users\Public\Videos\client_gamedata.BS";
        public string opponentName;
        public string IP;
        public int dim;

        public Join()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            IPAddress address;
            if (IPAddress.TryParse(textBox1.Text, out address))
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(address);
                if (reply.Status != IPStatus.Success)
                {
                    MessageBox.Show("Indirizzo IP non raggiungibile.");
                }
                else
                {
                    if (File.Exists(@"\\" + textBox1.Text + HostfileName))
                    {
                        using (FileStream fs = File.Create(@"\\" + textBox1.Text + ClientfileName))
                        {
                            byte[] text;
                            text = new UTF8Encoding(true).GetBytes(textBox2.Text);
                            fs.Write(text, 0, text.Length);
                        }
                        const Int32 BufferSize = 128;
                        using (var fileStream = File.OpenRead(@"\\" + textBox1.Text + HostfileName))
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                        {
                            string line;
                            int cnt = 0;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                if (cnt==0)
                                {
                                    int.TryParse(line, out dim);
                                }
                                if (cnt==1)
                                {
                                    opponentName = line;
                                }
                            }
                        }
                        IP = @"\\" + textBox1.Text;
                        Game game = new Game();
                        this.Hide();
                        Status = game.ShowDialog(this);
                        if (Status == DialogResult.OK)
                        {
                            this.Show();
                        }
                        if (Status == DialogResult.Abort)
                        {
                            if (File.Exists(@"\\" + textBox1.Text + ClientfileName))
                            {
                                File.Delete(@"\\" + textBox1.Text + ClientfileName);
                            }
                            this.DialogResult = DialogResult.Abort;
                            game.Dispose();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Server non valido o non raggiungibile.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Indirizzo IP non valido.");
            }
        }
    }
}
