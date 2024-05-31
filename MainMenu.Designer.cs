namespace Side_Scrolling_Game_MOO_ICT
{
    partial class MainMenu
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
            Play_Btn = new Button();
            Help_Btn = new Button();
            Quit_Btn = new Button();
            Меню = new Label();
            SuspendLayout();
            // 
            // Play_Btn
            // 
            Play_Btn.BackColor = Color.FromArgb(0, 192, 192);
            Play_Btn.Location = new Point(80, 150);
            Play_Btn.Name = "Play_Btn";
            Play_Btn.Size = new Size(189, 25);
            Play_Btn.TabIndex = 0;
            Play_Btn.Text = "Играть";
            Play_Btn.UseVisualStyleBackColor = false;
            Play_Btn.Click += Play_Btn_Click;
            // 
            // Help_Btn
            // 
            Help_Btn.BackColor = Color.Lime;
            Help_Btn.Location = new Point(80, 220);
            Help_Btn.Name = "Help_Btn";
            Help_Btn.Size = new Size(189, 25);
            Help_Btn.TabIndex = 1;
            Help_Btn.Text = "Помощь";
            Help_Btn.UseVisualStyleBackColor = false;
            Help_Btn.Click += Help_Btn_Click;
            // 
            // Quit_Btn
            // 
            Quit_Btn.BackColor = Color.Red;
            Quit_Btn.Location = new Point(80, 280);
            Quit_Btn.Name = "Quit_Btn";
            Quit_Btn.Size = new Size(189, 25);
            Quit_Btn.TabIndex = 2;
            Quit_Btn.Text = "Выход";
            Quit_Btn.UseVisualStyleBackColor = false;
            Quit_Btn.Click += Quit_Btn_Click;
            // 
            // Меню
            // 
            Меню.AutoSize = true;
            Меню.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Меню.Location = new Point(119, 40);
            Меню.Name = "Меню";
            Меню.Size = new Size(116, 45);
            Меню.TabIndex = 3;
            Меню.Text = "Меню";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(334, 411);
            Controls.Add(Меню);
            Controls.Add(Quit_Btn);
            Controls.Add(Help_Btn);
            Controls.Add(Play_Btn);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play_Btn;
        private Button Help_Btn;
        private Button Quit_Btn;
        private Label Меню;
    }
}