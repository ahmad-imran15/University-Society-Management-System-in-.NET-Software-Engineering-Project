namespace SE_Project
{
    partial class Add_Announcement
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
            txtDescription = new TextBox();
            button1 = new Button();
            button7 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft Sans Serif", 11F);
            txtDescription.Location = new Point(305, 237);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Announce something to users.....";
            txtDescription.Size = new Size(579, 109);
            txtDescription.TabIndex = 7;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(696, 453);
            button1.Name = "button1";
            button1.Size = new Size(188, 68);
            button1.TabIndex = 36;
            button1.Text = "Announce";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(65, 566);
            button7.Name = "button7";
            button7.Size = new Size(118, 45);
            button7.TabIndex = 37;
            button7.Text = "back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(65, 88);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 38;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Add_Announcement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Name = "Add_Announcement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Announcement";
            Load += Add_Announcement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Button button1;
        private Button button7;
        private Button button3;
    }
}