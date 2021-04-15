namespace MerelliBattleShip
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.opponentBox = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.GamePhase = new System.Windows.Forms.Label();
            this.track_trasparenza = new System.Windows.Forms.TrackBar();
            this.load_enemy_table = new System.Windows.Forms.Timer(this.components);
            this.AspettaColpo = new System.Windows.Forms.Timer(this.components);
            this.hitStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trasparenza)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 408);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.playerBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.opponentBox);
            this.splitContainer1.Size = new System.Drawing.Size(677, 408);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // playerBox
            // 
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerBox.Location = new System.Drawing.Point(-1, -1);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(319, 406);
            this.playerBox.TabIndex = 0;
            this.playerBox.TabStop = false;
            this.playerBox.MouseLeave += new System.EventHandler(this.playerBox_MouseLeave);
            this.playerBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerBox_MouseMove);
            this.playerBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playerBox_MouseUp);
            // 
            // opponentBox
            // 
            this.opponentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opponentBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opponentBox.Location = new System.Drawing.Point(0, 0);
            this.opponentBox.Name = "opponentBox";
            this.opponentBox.Size = new System.Drawing.Size(349, 406);
            this.opponentBox.TabIndex = 0;
            this.opponentBox.TabStop = false;
            this.opponentBox.MouseLeave += new System.EventHandler(this.opponentBox_MouseLeave);
            this.opponentBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.opponentBox_MouseMove);
            this.opponentBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.opponentBox_MouseUp);
            // 
            // GameName
            // 
            this.GameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GameName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.White;
            this.GameName.Location = new System.Drawing.Point(510, 465);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(179, 26);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Merelli\'s BattleShip";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(651, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 36);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "r";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(607, 12);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(38, 36);
            this.MaxBtn.TabIndex = 8;
            this.MaxBtn.Text = "1";
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(563, 12);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(38, 36);
            this.MinBtn.TabIndex = 9;
            this.MinBtn.Text = "0";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GamePhase
            // 
            this.GamePhase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GamePhase.AutoSize = true;
            this.GamePhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePhase.ForeColor = System.Drawing.Color.White;
            this.GamePhase.Location = new System.Drawing.Point(10, 474);
            this.GamePhase.Name = "GamePhase";
            this.GamePhase.Size = new System.Drawing.Size(179, 16);
            this.GamePhase.TabIndex = 10;
            this.GamePhase.Text = "Fase corrente: Piazza le navi";
            // 
            // track_trasparenza
            // 
            this.track_trasparenza.AutoSize = false;
            this.track_trasparenza.Location = new System.Drawing.Point(13, 13);
            this.track_trasparenza.Maximum = 100;
            this.track_trasparenza.Minimum = 10;
            this.track_trasparenza.Name = "track_trasparenza";
            this.track_trasparenza.Size = new System.Drawing.Size(149, 45);
            this.track_trasparenza.TabIndex = 11;
            this.track_trasparenza.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_trasparenza.Value = 100;
            this.track_trasparenza.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // load_enemy_table
            // 
            this.load_enemy_table.Interval = 200;
            this.load_enemy_table.Tick += new System.EventHandler(this.load_enemy_table_Tick);
            // 
            // AspettaColpo
            // 
            this.AspettaColpo.Tick += new System.EventHandler(this.AspettaColpo_Tick);
            // 
            // hitStatus
            // 
            this.hitStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hitStatus.AutoSize = true;
            this.hitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitStatus.ForeColor = System.Drawing.Color.White;
            this.hitStatus.Location = new System.Drawing.Point(398, 474);
            this.hitStatus.Name = "hitStatus";
            this.hitStatus.Size = new System.Drawing.Size(0, 16);
            this.hitStatus.TabIndex = 12;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(701, 500);
            this.Controls.Add(this.hitStatus);
            this.Controls.Add(this.GamePhase);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.MaxBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.track_trasparenza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Game_MouseUp);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trasparenza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox opponentBox;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Label GamePhase;
        private System.Windows.Forms.TrackBar track_trasparenza;
        private System.Windows.Forms.Timer load_enemy_table;
        private System.Windows.Forms.Timer AspettaColpo;
        private System.Windows.Forms.Label hitStatus;
    }
}