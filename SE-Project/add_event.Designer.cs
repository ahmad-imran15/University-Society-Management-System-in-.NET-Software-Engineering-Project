namespace SE_Project
{
    partial class add_event
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
            dateTimePicker1 = new DateTimePicker();
            textBoxName = new TextBox();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            txtfeedback = new TextBox();
            label4 = new Label();
            btnSignUp = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(423, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(423, 165);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Enter Name";
            textBoxName.Size = new Size(315, 31);
            textBoxName.TabIndex = 14;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(423, 132);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 15;
            label2.Text = "Event Name";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(423, 330);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 16;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(423, 297);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 17;
            label1.Text = "Ending Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(423, 213);
            label3.Name = "label3";
            label3.Size = new Size(178, 30);
            label3.TabIndex = 18;
            label3.Text = "Starting Date";
            label3.Click += label3_Click;
            // 
            // txtfeedback
            // 
            txtfeedback.Cursor = Cursors.IBeam;
            txtfeedback.ForeColor = Color.Black;
            txtfeedback.Location = new Point(423, 441);
            txtfeedback.Multiline = true;
            txtfeedback.Name = "txtfeedback";
            txtfeedback.PlaceholderText = "Enter Description of event...............";
            txtfeedback.Size = new Size(606, 115);
            txtfeedback.TabIndex = 33;
            txtfeedback.TextChanged += txtfeedback_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(423, 408);
            label4.Name = "label4";
            label4.Size = new Size(158, 30);
            label4.TabIndex = 34;
            label4.Text = "Description";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkCyan;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(423, 602);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(201, 65);
            btnSignUp.TabIndex = 35;
            btnSignUp.Text = "Add Event ";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(65, 53);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 36;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(65, 638);
            button2.Name = "button2";
            button2.Size = new Size(110, 46);
            button2.TabIndex = 37;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // add_event
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnSignUp);
            Controls.Add(label4);
            Controls.Add(txtfeedback);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Name = "add_event";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_event";
            Load += add_event_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBoxName;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label3;
        private TextBox txtfeedback;
        private Label label4;
        private Button btnSignUp;
        private Button button3;
        private Button button2;
    }
}