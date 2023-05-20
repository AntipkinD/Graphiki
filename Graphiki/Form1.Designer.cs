namespace Graphiki
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(843, 21);
            button1.Name = "button1";
            button1.Size = new Size(120, 60);
            button1.TabIndex = 1;
            button1.Text = "x^2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(969, 21);
            button2.Name = "button2";
            button2.Size = new Size(120, 60);
            button2.TabIndex = 2;
            button2.Text = "k/x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(843, 87);
            button3.Name = "button3";
            button3.Size = new Size(120, 60);
            button3.TabIndex = 3;
            button3.Text = "sin x";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(969, 87);
            button4.Name = "button4";
            button4.Size = new Size(120, 60);
            button4.TabIndex = 4;
            button4.Text = "x^3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(905, 153);
            button5.Name = "button5";
            button5.Size = new Size(120, 60);
            button5.TabIndex = 5;
            button5.Text = "ОЧИСТИТЬ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 615);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(699, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Парабола (x^2)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(843, 256);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 21);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Гипербола (k/x)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(699, 283);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(128, 21);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Синусоида (sin x)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(843, 283);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(193, 21);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Кубическая парабола (x^3)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point(646, 130);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 11;
            label2.Text = "Парабола";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Location = new Point(646, 151);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 12;
            label3.Text = "Гипербола";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LimeGreen;
            label4.Location = new Point(646, 174);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 13;
            label4.Text = "Синусоида";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.BlueViolet;
            label5.Location = new Point(618, 196);
            label5.Name = "label5";
            label5.Size = new Size(140, 17);
            label5.TabIndex = 14;
            label5.Text = "Кубическая парабола";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(618, 340);
            button6.Name = "button6";
            button6.Size = new Size(492, 245);
            button6.TabIndex = 15;
            button6.Text = "GODLEVEL";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1115, 641);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button6;
    }
}