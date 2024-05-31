namespace Side_Scrolling_Game_MOO_ICT
{
    partial class Menu_Selector
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
        private void InitializeComponent() {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(131, 116);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 0;
            button1.Text = "Уровень 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(131, 183);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 1;
            button2.Text = "Уровень 2 ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(131, 252);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(101, 31);
            button3.TabIndex = 2;
            button3.Text = "Уровень 3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 39);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 3;
            label1.Text = "Уровни";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(131, 347);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(101, 31);
            button4.TabIndex = 4;
            button4.Text = "В меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Menu_Selector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(382, 415);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu_Selector";
            Text = "Menu_Selector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}