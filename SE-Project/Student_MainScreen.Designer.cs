namespace SE_Project
{
    partial class Student_MainScreen
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
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 40);
            label1.Name = "label1";
            label1.Size = new Size(340, 40);
            label1.TabIndex = 0;
            label1.Text = "Student Main Page";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.Font = new Font("Arial Rounded MT Bold", 13F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(534, 248);
            button4.Name = "button4";
            button4.Size = new Size(272, 72);
            button4.TabIndex = 1;
            button4.Text = "View Society";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(12, 8);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 3;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(90, 569);
            button7.Name = "button7";
            button7.Size = new Size(118, 45);
            button7.TabIndex = 2;
            button7.Text = "back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 110);
            label2.Name = "label2";
            label2.Size = new Size(95, 36);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(868, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 200);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 13F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(145, 248);
            button1.Name = "button1";
            button1.Size = new Size(272, 72);
            button1.TabIndex = 6;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Arial Rounded MT Bold", 13F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(145, 368);
            button2.Name = "button2";
            button2.Size = new Size(272, 72);
            button2.TabIndex = 7;
            button2.Text = "Give FeedBack";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Font = new Font("Arial Rounded MT Bold", 13F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(534, 377);
            button5.Name = "button5";
            button5.Size = new Size(272, 72);
            button5.TabIndex = 8;
            button5.Text = "View Member";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.Font = new Font("Arial Rounded MT Bold", 13F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(145, 491);
            button6.Name = "button6";
            button6.Size = new Size(272, 72);
            button6.TabIndex = 9;
            button6.Text = "View Events";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkCyan;
            button8.Font = new Font("Arial Rounded MT Bold", 13F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(534, 491);
            button8.Name = "button8";
            button8.Size = new Size(272, 72);
            button8.TabIndex = 10;
            button8.Text = "View Announcements";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Student_MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "Student_MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private Button button7;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button8;
    }
}