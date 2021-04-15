using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MerelliBattleShip
{
    public partial class Game : Form
    {
        int dim;
        bool active = false;
        bool state = false;
        bool clean = true;
        int nave_count = 0;
        int hit_count = 0;
        int internal_hit_count = 0;
        bool mouse_down = false;
        string Path;
        string FileColpoHost;
        string FileColpoClient;
        string opponentname;
        string stringopponentarray = null;
        bool host;

        Bitmap player;
        Bitmap opponent;
        Bitmap playertemp;
        Bitmap opponenttemp;
        Bitmap[] nave = new Bitmap [10];
        int[] nave_size = new int[10];
        bool[,] playerArray = new bool[26, 26];
        bool[,] opponentArray = new bool[26, 26];
        bool[,] hitArray = new bool[26, 26];
        bool flipped;
        
        public Game()
        {
            for (int x=0; x<26; x++)
            {
                for (int y=0; y<26; y++)
                {
                    playerArray[x, y] = false;
                    opponentArray[x, y] = false;
                    hitArray[x, y] = false;
                }
            }
            nave[0] = Properties.Resources.portaerei;
            nave_size[0] = 5;
            nave[1] = Properties.Resources.nave_da_battaglia;
            nave_size[1] = 4;
            nave[2] = Properties.Resources.nave_da_battaglia_2;
            nave_size[2] = 4;
            nave[3] = Properties.Resources.incrociatore;
            nave_size[3] = 3;
            nave[4] = Properties.Resources.cacciatorpediniere;
            nave_size[4] = 3;
            nave[5] = Properties.Resources.submarine;
            nave_size[5] = 3;
            nave[6] = Properties.Resources.submarine2;
            nave_size[6] = 2;
            nave[7] = Properties.Resources.nave_ausiliaria2;
            nave_size[7] = 2;
            nave[8] = Properties.Resources.nave_ausiliaria;
            nave_size[8] = 2;
            nave[9] = Properties.Resources.motoscafo;
            nave_size[9] = 1;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                WindowState = FormWindowState.Maximized;
                state = true;
                MaxBtn.Text = "2";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                state = false;
                MaxBtn.Text = "1";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.silder_trasparenza==false)
            {
                track_trasparenza.Visible = false;
            }
            if (Owner.Text=="Create")
            {
                Create create = (Create)this.Owner;
                Path = create.pathOrIP;
                dim = create.trackBar1.Value;
                host = true;
            }
            else
            {
                Join join = (Join)this.Owner;
                Path = join.IP;
                dim = join.dim;
                opponentname = join.opponentName;
                host = false;
                File.Delete(@"\Users\Public\Videos\host_gamedata.BS");
                File.Delete(@"\Users\Public\Videos\client_gamedata.BS");
            }

            Path += @"\Users\Public\Videos\";
            FileColpoHost = Path + "host_colpo.BS";
            FileColpoClient = Path + "client_colpo.BS";
            player = new Bitmap(Properties.Resources.board2);
            playerBox.BackColor = Properties.Settings.Default.color4;
            opponentBox.BackColor = Properties.Settings.Default.color4;
            playerBox.Height = (dim + 1) * 32;
            playerBox.Width = (dim + 1) * 32;
            opponentBox.Height = (dim + 1) * 32;
            opponentBox.Width = (dim + 1) * 32;
            opponent = new Bitmap(player);

            playerBox.Image = player;
            opponentBox.Image = opponent;

            playertemp = new Bitmap(player);
            opponenttemp = new Bitmap(opponent);
        }

        void cross32(Bitmap Image, int x, int y, Color color)
        {
            int offset = Properties.Settings.Default.offset_croce;
            for (int plus = offset; plus < (32 - offset); plus++)
            {
                Image.SetPixel(((x + 1) * 32) + plus, ((y + 1) * 32) + plus, color);
                Image.SetPixel(((x + 1) * 32) + 31 - plus, ((y + 1) * 32) + plus, color);
            }
        }

        void square32(Bitmap Image, int x, int y, Color color)
        {
            int offset = Properties.Settings.Default.offset_quadrato;
            for (int plus = offset; plus < (32 - offset); plus++)
            {
                Image.SetPixel(((x + 1) * 32) + plus, ((y + 1) * 32) + offset, color);
                Image.SetPixel(((x + 1) * 32) + offset, ((y + 1) * 32) + plus, color);
                Image.SetPixel(((x + 1) * 32) + plus, ((y + 1) * 32) + (31 - offset), color);
                Image.SetPixel(((x + 1) * 32) + (31 - offset), ((y + 1) * 32) + plus, color);
            }
        }

        private void playerBox_MouseUp(object sender, MouseEventArgs e)
        {
            int xCoordinate = (e.X-32)/32;
            int yCoordinate = (e.Y-32)/32;
            if (nave_count < 10)
            {
                GamePhase.Text = "Fase corrente: Piazza le navi";
            }
            if (e.Button == MouseButtons.Left)
            {
                if (nave_count<10 && ((xCoordinate >= 0 && yCoordinate >= 0) && ((flipped && (xCoordinate + nave_size[nave_count] <= dim)) || (!flipped && (yCoordinate + nave_size[nave_count] <= dim)))))
                {
                    drawShip(xCoordinate, yCoordinate);
                    for (int y=0; y < nave_size[nave_count] && !flipped; y++)
                    {
                        if (playerArray[xCoordinate, (y + yCoordinate)]==true)
                        {
                            clean = false;
                        }
                    }

                    for (int x = 0; x < nave_size[nave_count] && flipped; x++)
                    {
                        if (playerArray[(x + xCoordinate), yCoordinate] == true)
                        {
                            clean = false;
                        }
                    }

                    if (clean)
                    {
                        for (int y = 0; y < nave_size[nave_count] && !flipped; y++)
                        {
                            playerArray[xCoordinate, (y + yCoordinate)] = true;
                        }

                        for (int x = 0; x < nave_size[nave_count] && flipped; x++)
                        {
                            playerArray[(x + xCoordinate), yCoordinate] = true;
                        }
                        
                        player = new Bitmap(playertemp);
                        nave[nave_count].Dispose();
                        nave_count++;
                        flipped = false;
                    }
                    else
                    {
                        GamePhase.Text = "Fase corrente: Piazza le navi, impossibile sovrapporre le navi";
                    }
                    clean = true;

                    if (nave_count==10)
                    {
                        GamePhase.Text = "Fase corrente: In attesa dell'avversario";
                        nave_count++;
                        string stringplayerarray = null;
                        for (int y = 0; y < dim; y++)
                        {
                            for (int x = 0; x < dim; x++)
                            {
                                stringplayerarray += Convert.ToInt32(playerArray[x, y]);
                            }
                            stringplayerarray += "\n";
                        }
                        // per visualizzare la matrice testualmente
                        //MessageBox.Show(stringplayerarray);
                        if (host)
                        {
                            crea_file(Path + "host_table.BS", stringplayerarray);
                        }
                        else
                        {
                            crea_file(Path + "client_table.BS", stringplayerarray);
                        }
                        load_enemy_table.Enabled = true;
                    }
                }
                else
                {
                    if (nave_count<10)
                    {
                        GamePhase.Text = "Fase corrente: Piazza le navi, posizione fuori dai limiti di gioco";
                    }
                }
            }
            else
            if (nave_count < 10)
            {
                nave[nave_count].RotateFlip(RotateFlipType.Rotate90FlipNone);
                if (!flipped)
                {
                    flipped = true;
                }
                else
                {
                    flipped = false;
                }
            }
            playerBox.Image = player;
            playerBox.Refresh();
            playertemp.Dispose();
            playertemp = new Bitmap(player);
        }

        private void opponentBox_MouseUp(object sender, MouseEventArgs e)
        {
            int xCoordinate = (e.X - 32) / 32;
            int yCoordinate = (e.Y - 32) / 32;
            if (xCoordinate >= 0 && yCoordinate >= 0 && nave_count >= 10 && active==true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (hitArray[xCoordinate, yCoordinate] == false)
                    {
                        if (host)
                        {
                            crea_file(FileColpoHost, xCoordinate + "\n" + yCoordinate);
                        }
                        else
                        {
                            crea_file(FileColpoClient, xCoordinate + "\n" + yCoordinate);
                        }
                        hitArray[xCoordinate, yCoordinate] = true;
                        if (opponentArray[xCoordinate, yCoordinate] == true)
                        {
                            hit_count++;
                            hitStatus.Text = "Colpito!";
                            cross32(opponent, xCoordinate, yCoordinate, Properties.Settings.Default.color1);
                            if (hit_count==29)
                            {
                                MessageBox.Show("Hai vinto!");
                            }
                        }
                        else
                        {
                            hitStatus.Text = "Mancato!";
                            cross32(opponent, xCoordinate, yCoordinate, Properties.Settings.Default.color2);
                        }

                        opponentBox.Image = opponent;
                        opponentBox.Refresh();
                        tuoturno(false);
                    }
                    else
                    {
                        hitStatus.Text = "Bersaglio già colpito.";
                    }
                }
            }
        }

        void drawShip(int x, int y)
        {
            if (nave_count < 10)
            {
                playertemp = new Bitmap(player.Width, player.Height, PixelFormat.Format32bppArgb);
                var graphics = Graphics.FromImage(playertemp);
                graphics.CompositingMode = CompositingMode.SourceOver;

                graphics.DrawImage(player, 0, 0);
                graphics.DrawImage(new Bitmap(nave[nave_count]), (x + 1) * 32, (y + 1) * 32);
            }
        }

        private void playerBox_MouseMove(object sender, MouseEventArgs e)
        {
            int xCoordinate = (e.X - 32) / 32;
            int yCoordinate = (e.Y - 32) / 32;
            if (xCoordinate>=0 && yCoordinate>=0 && nave_count<10)
            {
                drawShip(xCoordinate, yCoordinate);
                
                playerBox.Image = playertemp;
                playerBox.Refresh();

                playertemp = new Bitmap(player);
            }
            else
            {
                playertemp.Dispose();
            }
        }

        private void opponentBox_MouseMove(object sender, MouseEventArgs e)
        {
            int xCoordinate = (e.X - 32) / 32;
            int yCoordinate = (e.Y - 32) / 32;
            if (xCoordinate >= 0 && yCoordinate >= 0)
            {
                square32(opponenttemp, xCoordinate, yCoordinate, Properties.Settings.Default.color3);

                opponentBox.Image = opponenttemp;
                opponentBox.Refresh();

                opponenttemp = new Bitmap(opponent);
            }
        }

        private void opponentBox_MouseLeave(object sender, EventArgs e)
        {
            opponentBox.Image = opponent;
            opponentBox.Refresh();
        }

        private void playerBox_MouseLeave(object sender, EventArgs e)
        {
            playertemp.Dispose();
            playerBox.Image = player;
            playerBox.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ActiveForm.Opacity = (float)track_trasparenza.Value/100.0;
        }
        
        void read_opponent_table(string path_read)
        {
            int i = 0;
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path_read))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;

                int y = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    for (int x=0; x<dim; x++)
                    {
                        int.TryParse(line[x].ToString(), out i);
                        if (i==1)
                        {
                            opponentArray[x, y] = true;
                        }
                        stringopponentarray += Convert.ToInt32(playerArray[x, y]);
                    }
                    stringopponentarray += "\n";
                    y++;
                }
            }
        }

        void tuoturno(bool status)
        {
            active = status;
            if (!status)
            {
                AspettaColpo.Enabled = true;
                GamePhase.Text = "Fase corrente: In attesa dell'avversario";
            }
            else
            {
                GamePhase.Text = "Fase corrente: Fai la tua mossa";
                hitStatus.Text = "";
            }
        }

        int readX(string path_read)
        {
            int x = 0;
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path_read))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                int line_count = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line_count == 0)
                    {
                        int.TryParse(line, out x);
                    }
                    line_count++;
                }
            }
            return x;
        }

        int readY(string path_read)
        {
            int y = 0;
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path_read))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string line;
                int line_count = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line_count == 1)
                    {
                        int.TryParse(line, out y);
                    }
                    line_count++;
                }
            }
            return y;
        }

        void crea_file(string percorso, string contenuto)
        {
            FileStream fs = File.Create(percorso);
 
            using (fs)
            {
                byte[] text;
                text = new UTF8Encoding(true).GetBytes(contenuto);
                fs.Write(text, 0, text.Length);
            }
        }

        int cnt = 0;
        private void load_enemy_table_Tick(object sender, EventArgs e)
        {
            string FileToWait;
            if (host)
            {
                FileToWait = Path + "client_table.BS";
            }
            else
            {
                FileToWait = Path + "host_table.BS";
            }
            if (File.Exists(FileToWait))
            {
                if (cnt==0)
                {
                    read_opponent_table(FileToWait);
                }
                cnt++;
            }
            if (cnt==5)
            {
                File.Delete(FileToWait);
                if (host)
                {
                    tuoturno(true);
                }
                else
                {
                    tuoturno(false);
                }
                load_enemy_table.Enabled = false;
            }
        }

        private void AspettaColpo_Tick(object sender, EventArgs e)
        {
            string FileColpo;
            if (host)
            {
                FileColpo = FileColpoClient;
            }
            else
            {
                FileColpo = FileColpoHost;
            }
            if (File.Exists(FileColpo))
            {
                int x, y;
                x = readX(FileColpo);
                y = readY(FileColpo);
                try
                {
                    File.Delete(FileColpo);
                }
                catch (UnauthorizedAccessException)
                {
                }
                if (playerArray[x, y] == true)
                {
                    internal_hit_count++;
                    cross32(player, x, y, Properties.Settings.Default.color1);
                    if (internal_hit_count==29)
                    {
                        MessageBox.Show("Hai perso!");
                    }
                }
                else
                {
                    cross32(player, x, y, Properties.Settings.Default.color2);
                }
                playerBox.Image = player;
                playerBox.Refresh();
                tuoturno(true);
                AspettaColpo.Enabled = false;
            }
        }

        int differenceX;
        int differenceY;
        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            differenceX = e.X;
            differenceY = e.Y;
        }

        private void Game_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Location = new Point(Location.X + e.X - differenceX, Location.Y + e.Y - differenceY);
            }
        }
    }
}
