using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MerelliBattleShip
{
    public partial class FirstForm : Form
    {
        Point originalposition;
        DialogResult Result;
        public FirstForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            Hide();
            Result = create.ShowDialog(this);
            if (Result == DialogResult.Cancel)
            {
                Show();
            }
            else
            if (Result == DialogResult.Abort)
            {
                create.Dispose();
                Close();
            }
            create.Dispose();
        }

        private void JoinBattle_Click(object sender, EventArgs e)
        {
            Join join = new Join();
            Hide();
            Result = join.ShowDialog(this);
            if (Result == DialogResult.Cancel)
            {
                Show();
            }
            else
            if (Result == DialogResult.Abort)
            {
                join.Dispose();
                Close();
            }
            join.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            settings settings = new settings();
            settings.ShowDialog();
            Show();
        }

        int differenceX;
        int differenceY;
        bool mouse_down = false;
        private void FirstForm_MouseDown(object sender, MouseEventArgs e)
        {
            originalposition = Location;
            mouse_down = true;
            differenceX = e.X;
            differenceY = e.Y;
            //FixPosition.Enabled = false;
        }

        private void FirstForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
            //FixPosition.Enabled = true;
        }

        private void FirstForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Location = new Point(Location.X + e.X - differenceX, Location.Y + e.Y - differenceY);
            }
        }
        /*
        int addX;
        int addY;
        private void FixPosition_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(originalposition.X - Location.X) < 5)
            {
                addX = 1;
            }
            else
            {
                addX = 5;
            }
            if (Math.Abs(originalposition.Y - Location.Y) < 5)
            {
                addY = 1;
            }
            else
            {
                addY = 5;
            }
            if (Location.X < originalposition.X)
            {
                Location = new Point(Location.X + addX, Location.Y);
            }
            else if (Location.X > originalposition.X)
            {
                Location = new Point(Location.X - addX, Location.Y);
            }
            if (Location.Y < originalposition.Y)
            {
                Location = new Point(Location.X, Location.Y + addY);
            }
            else if (Location.Y > originalposition.Y)
            {
                Location = new Point(Location.X , Location.Y - addY);
            }
            if (Location==originalposition)
            {
                FixPosition.Enabled = false;
            }
        }
        */
    }
}
