namespace SE_Project
{
    partial class Admin_MainScreen
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 28);
            label1.Name = "label1";
            label1.Size = new Size(357, 42);
            label1.TabIndex = 1;
            label1.Text = "Admin Main Screen";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 13F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(404, 303);
            button1.Name = "button1";
            button1.Size = new Size(259, 64);
            button1.TabIndex = 3;
            button1.Text = "Register Society";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Arial Rounded MT Bold", 13F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(725, 293);
            button2.Name = "button2";
            button2.Size = new Size(259, 64);
            button2.TabIndex = 4;
            button2.Text = "Update Society";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Arial Rounded MT Bold", 13F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(404, 421);
            button3.Name = "button3";
            button3.Size = new Size(259, 64);
            button3.TabIndex = 5;
            button3.Text = "Delete Society";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.Font = new Font("Arial Rounded MT Bold", 13F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(404, 188);
            button4.Name = "button4";
            button4.Size = new Size(259, 64);
            button4.TabIndex = 1;
            button4.Text = "View Society";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Font = new Font("Arial Rounded MT Bold", 13F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(725, 188);
            button5.Name = "button5";
            button5.Size = new Size(259, 64);
            button5.TabIndex = 2;
            button5.Text = "Add President";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(55, 590);
            button7.Name = "button7";
            button7.Size = new Size(118, 45);
            button7.TabIndex = 20;
            button7.Text = "back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(24, 20);
            button6.Name = "button6";
            button6.Size = new Size(54, 58);
            button6.TabIndex = 6;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkCyan;
            button8.Font = new Font("Arial Rounded MT Bold", 13F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(80, 188);
            button8.Name = "button8";
            button8.Size = new Size(243, 64);
            button8.TabIndex = 21;
            button8.Text = "Update Users";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkCyan;
            button9.Font = new Font("Arial Rounded MT Bold", 13F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(80, 303);
            button9.Name = "button9";
            button9.Size = new Size(243, 64);
            button9.TabIndex = 22;
            button9.Text = "View FeedBack";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Admin_MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Admin_MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_MainScreen";
            Load += Admin_MainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button9;
    }
}