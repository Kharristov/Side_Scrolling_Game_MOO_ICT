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
            label1 = new Label();
            SuspendLayout();
            // 
            // Play_Btn
            // 
            Play_Btn.Location = new Point(80, 150);
            Play_Btn.Name = "Play_Btn";
            Play_Btn.Size = new Size(189, 25);
            Play_Btn.TabIndex = 0;
            Play_Btn.Text = "Играть";
            Play_Btn.UseVisualStyleBackColor = true;
            Play_Btn.Click += Play_Btn_Click;
            // 
            // Help_Btn
            // 
            Help_Btn.Location = new Point(80, 220);
            Help_Btn.Name = "Help_Btn";
            Help_Btn.Size = new Size(189, 25);
            Help_Btn.TabIndex = 1;
            Help_Btn.Text = "Помощь";
            Help_Btn.UseVisualStyleBackColor = true;
            Help_Btn.Click += Help_Btn_Click;
            // 
            // Quit_Btn
            // 
            Quit_Btn.Location = new Point(80, 280);
            Quit_Btn.Name = "Quit_Btn";
            Quit_Btn.Size = new Size(189, 25);
            Quit_Btn.TabIndex = 2;
            Quit_Btn.Text = "Выход";
            Quit_Btn.UseVisualStyleBackColor = true;
            Quit_Btn.Click += Quit_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(label1);
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
        private Label label1;
    }
}