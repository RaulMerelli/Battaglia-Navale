namespace MerelliBattleShip
{
    partial class settings
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.offset_croce_track = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.offset_quadrato_track = new System.Windows.Forms.TrackBar();
            this.offset_croce_Text = new System.Windows.Forms.Label();
            this.offset_quadrato_Text = new System.Windows.Forms.Label();
            this.trasparenza = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.color4 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.offset_croce_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset_quadrato_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 267);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 36);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "INDIETRO";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colore per croce quando si colpisce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Colore per croce quando si manca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Colore per quadrato di selezione";
            // 
            // offset_croce_track
            // 
            this.offset_croce_track.Location = new System.Drawing.Point(33, 166);
            this.offset_croce_track.Name = "offset_croce_track";
            this.offset_croce_track.Size = new System.Drawing.Size(104, 45);
            this.offset_croce_track.TabIndex = 13;
            this.offset_croce_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.offset_croce_track.Scroll += new System.EventHandler(this.offset_croce_track_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Offset croce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(143, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Offset quadrato di selezione";
            // 
            // offset_quadrato_track
            // 
            this.offset_quadrato_track.Location = new System.Drawing.Point(33, 196);
            this.offset_quadrato_track.Name = "offset_quadrato_track";
            this.offset_quadrato_track.Size = new System.Drawing.Size(104, 45);
            this.offset_quadrato_track.TabIndex = 15;
            this.offset_quadrato_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.offset_quadrato_track.Scroll += new System.EventHandler(this.offset_quadrato_track_Scroll);
            // 
            // offset_croce_Text
            // 
            this.offset_croce_Text.AutoSize = true;
            this.offset_croce_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offset_croce_Text.ForeColor = System.Drawing.Color.White;
            this.offset_croce_Text.Location = new System.Drawing.Point(12, 165);
            this.offset_croce_Text.Name = "offset_croce_Text";
            this.offset_croce_Text.Size = new System.Drawing.Size(16, 18);
            this.offset_croce_Text.TabIndex = 17;
            this.offset_croce_Text.Text = "0";
            // 
            // offset_quadrato_Text
            // 
            this.offset_quadrato_Text.AutoSize = true;
            this.offset_quadrato_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offset_quadrato_Text.ForeColor = System.Drawing.Color.White;
            this.offset_quadrato_Text.Location = new System.Drawing.Point(12, 196);
            this.offset_quadrato_Text.Name = "offset_quadrato_Text";
            this.offset_quadrato_Text.Size = new System.Drawing.Size(16, 18);
            this.offset_quadrato_Text.TabIndex = 18;
            this.offset_quadrato_Text.Text = "0";
            // 
            // trasparenza
            // 
            this.trasparenza.AutoSize = true;
            this.trasparenza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trasparenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasparenza.ForeColor = System.Drawing.Color.White;
            this.trasparenza.Location = new System.Drawing.Point(12, 221);
            this.trasparenza.Name = "trasparenza";
            this.trasparenza.Size = new System.Drawing.Size(204, 20);
            this.trasparenza.TabIndex = 19;
            this.trasparenza.Text = "Attiva slider per la trasparenza";
            this.trasparenza.UseVisualStyleBackColor = true;
            this.trasparenza.CheckedChanged += new System.EventHandler(this.trasparenza_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Colore sfondo";
            // 
            // color4
            // 
            this.color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color4.Location = new System.Drawing.Point(12, 120);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(29, 30);
            this.color4.TabIndex = 20;
            this.color4.TabStop = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // color3
            // 
            this.color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color3.Location = new System.Drawing.Point(12, 84);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(29, 30);
            this.color3.TabIndex = 11;
            this.color3.TabStop = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color2
            // 
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color2.Location = new System.Drawing.Point(12, 48);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(29, 30);
            this.color2.TabIndex = 9;
            this.color2.TabStop = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color1
            // 
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color1.Location = new System.Drawing.Point(12, 12);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(29, 30);
            this.color1.TabIndex = 7;
            this.color1.TabStop = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "RIPRISTINA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(474, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.trasparenza);
            this.Controls.Add(this.offset_quadrato_Text);
            this.Controls.Add(this.offset_croce_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.offset_quadrato_track);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.offset_croce_track);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.settings_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.offset_croce_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset_quadrato_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.TrackBar offset_croce_track;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar offset_quadrato_track;
        private System.Windows.Forms.Label offset_croce_Text;
        private System.Windows.Forms.Label offset_quadrato_Text;
        private System.Windows.Forms.CheckBox trasparenza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox color4;
        private System.Windows.Forms.Button button1;
    }
}