namespace Side_Scrolling_Game_MOO_ICT
{
    partial class Help
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "ДВИЖЕНИЕ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "стрелками";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(243, 60);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "ПРЫЖОК";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 92);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "прыжок";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(136, 316);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "В меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 192, 0);
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(124, 141);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 5;
            label5.Text = "ПРАВИЛО";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(366, 20);
            label6.TabIndex = 6;
            label6.Text = "Собрать монеты.С помощью ключа открыть дверь.";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(382, 415);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Help";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}