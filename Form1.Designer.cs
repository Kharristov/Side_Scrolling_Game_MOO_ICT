namespace Side_Scrolling_Game_MOO_ICT
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
            components = new System.ComponentModel.Container();
            background = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            door = new PictureBox();
            player = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            key = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            txtScore = new Label();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.Image = Properties.Resources.Pixel;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(735, 443);
            background.SizeMode = PictureBoxSizeMode.AutoSize;
            background.TabIndex = 0;
            background.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox1.Location = new Point(0, 360);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox2.Location = new Point(174, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox3.Location = new Point(487, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox5.Location = new Point(635, 307);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox6.Location = new Point(162, 273);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "platform";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox7.Location = new Point(0, 121);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(127, 50);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "platform";
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox8.Location = new Point(603, 121);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(132, 50);
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "platform";
            // 
            // door
            // 
            door.BackgroundImage = Properties.Resources.dver_gr;
            door.Location = new Point(0, 46);
            door.Name = "door";
            door.Size = new Size(45, 79);
            door.SizeMode = PictureBoxSizeMode.AutoSize;
            door.TabIndex = 10;
            door.TabStop = false;
            door.Tag = "door";
            // 
            // player
            // 
            player.BackgroundImage = Properties.Resources.cat;
            player.Location = new Point(35, 307);
            player.Name = "player";
            player.Size = new Size(51, 50);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 11;
            player.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.fih_art;
            pictureBox4.Location = new Point(196, 232);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "coin";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.fih_art;
            pictureBox9.Location = new Point(517, 217);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(33, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.fih_art;
            pictureBox10.Location = new Point(678, 273);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "coin";
            // 
            // key
            // 
            key.Image = Properties.Resources.fih_clu;
            key.Location = new Point(685, 65);
            key.Name = "key";
            key.Size = new Size(50, 50);
            key.SizeMode = PictureBoxSizeMode.AutoSize;
            key.TabIndex = 15;
            key.TabStop = false;
            key.Tag = "key";
            key.UseWaitCursor = true;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimer;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(0, 389);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(63, 21);
            txtScore.TabIndex = 16;
            txtScore.Text = "Счет: 0";
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = Properties.Resources.bloc_gr;
            pictureBox11.Location = new Point(332, 176);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 50);
            pictureBox11.TabIndex = 17;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "platform";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.fih_art;
            pictureBox12.Location = new Point(207, 87);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(33, 28);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 18;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "coin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 404);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(txtScore);
            Controls.Add(key);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox4);
            Controls.Add(player);
            Controls.Add(door);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(background);
            Name = "Form1";
            Text = "Side Scrolling Platform Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)background).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)door).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox background;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox door;
        private PictureBox player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox key;
        private System.Windows.Forms.Timer gameTimer;
        private Label txtScore;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
    }
}