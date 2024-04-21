namespace SE_Project
{
    partial class Update_Users
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
            button3 = new Button();
            txtPhonenumber = new TextBox();
            txtfullName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtSearchItem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(3, 1);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 21;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(55, 475);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.PlaceholderText = "Enter Phone number";
            txtPhonenumber.Size = new Size(331, 31);
            txtPhonenumber.TabIndex = 14;
            // 
            // txtfullName
            // 
            txtfullName.Location = new Point(55, 382);
            txtfullName.Name = "txtfullName";
            txtfullName.PlaceholderText = "Enter Name";
            txtfullName.Size = new Size(331, 31);
            txtfullName.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 609);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 20;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(561, 594);
            button1.Name = "button1";
            button1.Size = new Size(188, 68);
            button1.TabIndex = 18;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.Location = new Point(55, 446);
            label5.Name = "label5";
            label5.Size = new Size(159, 26);
            label5.TabIndex = 19;
            label5.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(55, 353);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 15;
            label3.Text = "Full Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(828, 211);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(699, 80);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "    Search";
            txtSearchItem.Size = new Size(242, 31);
            txtSearchItem.TabIndex = 12;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(708, 47);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 11;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 40);
            label1.TabIndex = 9;
            label1.Text = "Update Users";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(561, 475);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(331, 31);
            txtPassword.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(561, 446);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(561, 382);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(331, 31);
            txtEmail.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.Location = new Point(561, 353);
            label7.Name = "label7";
            label7.Size = new Size(68, 26);
            label7.TabIndex = 27;
            label7.Text = "Email";
            // 
            // Update_Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(txtPhonenumber);
            Controls.Add(txtfullName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Users";
            Load += Update_Users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox txtPhonenumber;
        private TextBox txtfullName;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtSearchItem;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label7;
    }
}