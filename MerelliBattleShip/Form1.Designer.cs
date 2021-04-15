namespace MerelliBattleShip
{
    partial class FirstForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameName = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.JoinBattle = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Ship = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).BeginInit();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.White;
            this.GameName.Location = new System.Drawing.Point(267, 278);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(179, 26);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Merelli\'s BattleShip";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(12, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(114, 58);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "CREA";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // JoinBattle
            // 
            this.JoinBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinBattle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinBattle.ForeColor = System.Drawing.Color.White;
            this.JoinBattle.Location = new System.Drawing.Point(12, 76);
            this.JoinBattle.Name = "JoinBattle";
            this.JoinBattle.Size = new System.Drawing.Size(114, 58);
            this.JoinBattle.TabIndex = 2;
            this.JoinBattle.Text = "PARTECIPA";
            this.JoinBattle.UseVisualStyleBackColor = true;
            this.JoinBattle.Click += new System.EventHandler(this.JoinBattle_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(424, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 36);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "r";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ship
            // 
            this.Ship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ship.Image = global::MerelliBattleShip.Properties.Resources.ship;
            this.Ship.Location = new System.Drawing.Point(12, 12);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(450, 278);
            this.Ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ship.TabIndex = 3;
            this.Ship.TabStop = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(12, 268);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(146, 35);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "IMPOSTAZIONI";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(474, 315);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.JoinBattle);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.Ship);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirstForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirstForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button JoinBattle;
        private System.Windows.Forms.PictureBox Ship;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button settingsBtn;
    }
}

