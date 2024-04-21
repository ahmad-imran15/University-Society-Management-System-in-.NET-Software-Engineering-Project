namespace SE_Project
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            textBoxPhonenumber = new TextBox();
            textBoxEmail = new TextBox();
            txtUsername = new TextBox();
            textPassword = new TextBox();
            btnSignUp = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 42);
            label1.TabIndex = 0;
            label1.Text = "SignUp";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(893, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(517, 97);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 185);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 3;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(517, 271);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(517, 361);
            label5.Name = "label5";
            label5.Size = new Size(142, 30);
            label5.TabIndex = 5;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 453);
            label6.Name = "label6";
            label6.Size = new Size(137, 30);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.ForeColor = Color.Gray;
            textBoxName.Location = new Point(517, 140);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Enter Name";
            textBoxName.Size = new Size(315, 31);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPhonenumber
            // 
            textBoxPhonenumber.ForeColor = Color.Gray;
            textBoxPhonenumber.Location = new Point(517, 228);
            textBoxPhonenumber.Name = "textBoxPhonenumber";
            textBoxPhonenumber.PlaceholderText = "Enter Phone Number";
            textBoxPhonenumber.Size = new Size(315, 31);
            textBoxPhonenumber.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.ForeColor = Color.Gray;
            textBoxEmail.Location = new Point(517, 314);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Enter Email";
            textBoxEmail.Size = new Size(315, 31);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(517, 403);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(315, 31);
            txtUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.ForeColor = Color.Gray;
            textPassword.Location = new Point(517, 493);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Enter Password";
            textPassword.Size = new Size(315, 31);
            textPassword.TabIndex = 5;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkCyan;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(539, 592);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(201, 65);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(31, 18);
            button1.Name = "button1";
            button1.Size = new Size(54, 58);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkCyan;
            pictureBox2.Location = new Point(139, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 435);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(44, 628);
            button2.Name = "button2";
            button2.Size = new Size(110, 46);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(893, 240);
            button3.Name = "button3";
            button3.Size = new Size(165, 47);
            button3.TabIndex = 9;
            button3.Text = "Upload Picture";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(btnSignUp);
            Controls.Add(textPassword);
            Controls.Add(txtUsername);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhonenumber);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxPhonenumber;
        private TextBox textBoxEmail;
        private TextBox txtUsername;
        private TextBox textPassword;
        private Button btnSignUp;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
    }
}
