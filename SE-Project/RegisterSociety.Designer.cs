namespace SE_Project
{
    partial class RegisterSociety
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtPresidentName = new TextBox();
            txtDepartment = new TextBox();
            txtBatch = new TextBox();
            txtDescription = new TextBox();
            btnRegister = new Button();
            button1 = new Button();
            button2 = new Button();
            txtcurrent_time = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkCyan;
            pictureBox1.Location = new Point(135, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 508);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 33);
            label1.Name = "label1";
            label1.Size = new Size(312, 50);
            label1.TabIndex = 1;
            label1.Text = "Register Society";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 150);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 370);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 3;
            label3.Text = "Batch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 296);
            label4.Name = "label4";
            label4.Size = new Size(157, 30);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(176, 223);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 5;
            label5.Text = "President Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(176, 439);
            label6.Name = "label6";
            label6.Size = new Size(194, 30);
            label6.TabIndex = 6;
            label6.Text = "Date and Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(176, 505);
            label7.Name = "label7";
            label7.Size = new Size(153, 30);
            label7.TabIndex = 7;
            label7.Text = "Description";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(527, 150);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Name";
            txtName.Size = new Size(434, 42);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPresidentName
            // 
            txtPresidentName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPresidentName.Location = new Point(527, 225);
            txtPresidentName.Multiline = true;
            txtPresidentName.Name = "txtPresidentName";
            txtPresidentName.PlaceholderText = "Enter President Name";
            txtPresidentName.Size = new Size(434, 42);
            txtPresidentName.TabIndex = 2;
            txtPresidentName.TextChanged += txtPresidentName_TextChanged;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(527, 298);
            txtDepartment.Multiline = true;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Enter Department Name";
            txtDepartment.Size = new Size(434, 42);
            txtDepartment.TabIndex = 3;
            // 
            // txtBatch
            // 
            txtBatch.Font = new Font("Microsoft Sans Serif", 11F);
            txtBatch.Location = new Point(527, 372);
            txtBatch.Multiline = true;
            txtBatch.Name = "txtBatch";
            txtBatch.PlaceholderText = "Enter You Batch";
            txtBatch.Size = new Size(434, 42);
            txtBatch.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft Sans Serif", 11F);
            txtDescription.Location = new Point(527, 507);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Give a short Description about your society";
            txtDescription.Size = new Size(579, 109);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkCyan;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(559, 650);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(236, 62);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register Society";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(79, 677);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(27, 12);
            button2.Name = "button2";
            button2.Size = new Size(54, 58);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtcurrent_time
            // 
            txtcurrent_time.Font = new Font("Microsoft Sans Serif", 11F);
            txtcurrent_time.Location = new Point(527, 440);
            txtcurrent_time.Multiline = true;
            txtcurrent_time.Name = "txtcurrent_time";
            txtcurrent_time.PlaceholderText = "Enter You Batch";
            txtcurrent_time.Size = new Size(434, 42);
            txtcurrent_time.TabIndex = 10;
            txtcurrent_time.TextChanged += txtcurrent_time_TextChanged;
            // 
            // RegisterSociety
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            ClientSize = new Size(1182, 766);
            Controls.Add(txtcurrent_time);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(txtDescription);
            Controls.Add(txtBatch);
            Controls.Add(txtDepartment);
            Controls.Add(txtPresidentName);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterSociety";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterSociety";
            Load += RegisterSociety_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtPresidentName;
        private TextBox txtDepartment;
        private TextBox txtBatch;
        private TextBox txtDescription;
        private Button btnRegister;
        private Button button1;
        private Button button2;
        private TextBox txtcurrent_time;
    }
}