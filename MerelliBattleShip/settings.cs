using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MerelliBattleShip
{
    public partial class settings : Form
    {
        ColorDialog scelta_colore = new ColorDialog();
        public settings()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void offset_croce_track_Scroll(object sender, EventArgs e)
        {
            offset_croce_Text.Text = offset_croce_track.Value.ToString();
            Properties.Settings.Default.offset_croce = offset_croce_track.Value;
        }

        private void offset_quadrato_track_Scroll(object sender, EventArgs e)
        {
            offset_quadrato_Text.Text = offset_quadrato_track.Value.ToString();
            Properties.Settings.Default.offset_quadrato = offset_quadrato_track.Value;
        }

        private void color1_Click(object sender, EventArgs e)
        {
            if (scelta_colore.ShowDialog() == DialogResult.OK)
            {
                color1.BackColor = scelta_colore.Color;
                Properties.Settings.Default.color1 = scelta_colore.Color;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            if (scelta_colore.ShowDialog() == DialogResult.OK)
            {
                color2.BackColor = scelta_colore.Color;
                Properties.Settings.Default.color2 = scelta_colore.Color;
            }
        }

        private void color3_Click(object sender, EventArgs e)
        {
            if (scelta_colore.ShowDialog() == DialogResult.OK)
            {
                color3.BackColor = scelta_colore.Color;
                Properties.Settings.Default.color3 = scelta_colore.Color;
            }
        }
        
        private void color4_Click(object sender, EventArgs e)
        {
            if (scelta_colore.ShowDialog() == DialogResult.OK)
            {
                color4.BackColor = scelta_colore.Color;
                Properties.Settings.Default.color4 = scelta_colore.Color;
            }
        }

        private void trasparenza_CheckedChanged(object sender, EventArgs e)
        {
            if (trasparenza.Checked)
            {
                Properties.Settings.Default.silder_trasparenza = true;
            }
            else
            {
                Properties.Settings.Default.silder_trasparenza = false;
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            color1.BackColor = Properties.Settings.Default.color1;
            color2.BackColor = Properties.Settings.Default.color2;
            color3.BackColor = Properties.Settings.Default.color3;
            color4.BackColor = Properties.Settings.Default.color4;
            offset_croce_track.Value = Properties.Settings.Default.offset_croce;
            offset_quadrato_track.Value = Properties.Settings.Default.offset_quadrato;
            offset_croce_Text.Text = offset_croce_track.Value.ToString();
            offset_quadrato_Text.Text = offset_quadrato_track.Value.ToString();
            trasparenza.Checked = Properties.Settings.Default.silder_trasparenza;
        }

        int differenceX;
        int differenceY;
        bool mouse_down = false;
        private void settings_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            differenceX = e.X;
            differenceY = e.Y;
        }

        private void settings_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Location = new Point(Location.X + e.X - differenceX, Location.Y + e.Y - differenceY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.color1 = Color.Red;
            Properties.Settings.Default.color2 = Color.MediumBlue;
            Properties.Settings.Default.color3 = Color.Black;
            Properties.Settings.Default.color4 = Color.FromArgb(255, 64, 64, 64);
            Properties.Settings.Default.offset_croce = 5;
            Properties.Settings.Default.offset_quadrato = 2;
            Properties.Settings.Default.silder_trasparenza = false;
            color1.BackColor = Properties.Settings.Default.color1;
            color2.BackColor = Properties.Settings.Default.color2;
            color3.BackColor = Properties.Settings.Default.color3;
            color4.BackColor = Properties.Settings.Default.color4;
            offset_croce_track.Value = Properties.Settings.Default.offset_croce;
            offset_quadrato_track.Value = Properties.Settings.Default.offset_quadrato;
            offset_croce_Text.Text = offset_croce_track.Value.ToString();
            offset_quadrato_Text.Text = offset_quadrato_track.Value.ToString();
            trasparenza.Checked = Properties.Settings.Default.silder_trasparenza;
        }
    }
}
