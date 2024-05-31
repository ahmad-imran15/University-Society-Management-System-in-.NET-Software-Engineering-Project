namespace SE_Project
{
    partial class newformrandom
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
            comboBox1 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            btnsave = new Button();
            txtfeedback = new TextBox();
            txtpurpose = new TextBox();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(412, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 33);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(158, 222);
            label5.Name = "label5";
            label5.Size = new Size(106, 30);
            label5.TabIndex = 47;
            label5.Text = "Society";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(68, 678);
            button2.Name = "button2";
            button2.Size = new Size(110, 46);
            button2.TabIndex = 46;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DarkCyan;
            btnsave.BackgroundImageLayout = ImageLayout.Stretch;
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = SystemColors.ButtonHighlight;
            btnsave.Location = new Point(428, 599);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(201, 65);
            btnsave.TabIndex = 40;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtfeedback
            // 
            txtfeedback.Cursor = Cursors.IBeam;
            txtfeedback.ForeColor = Color.Black;
            txtfeedback.Location = new Point(412, 444);
            txtfeedback.Multiline = true;
            txtfeedback.Name = "txtfeedback";
            txtfeedback.PlaceholderText = "Enter FeedBack";
            txtfeedback.Size = new Size(355, 115);
            txtfeedback.TabIndex = 39;
            txtfeedback.TextChanged += txtfeedback_TextChanged;
            // 
            // txtpurpose
            // 
            txtpurpose.Cursor = Cursors.IBeam;
            txtpurpose.ForeColor = Color.Black;
            txtpurpose.Location = new Point(412, 371);
            txtpurpose.Multiline = true;
            txtpurpose.Name = "txtpurpose";
            txtpurpose.PlaceholderText = "Enter Purpose";
            txtpurpose.Size = new Size(355, 42);
            txtpurpose.TabIndex = 38;
            txtpurpose.TextChanged += txtpurpose_TextChanged;
            // 
            // txtname
            // 
            txtname.Cursor = Cursors.IBeam;
            txtname.ForeColor = Color.Black;
            txtname.Location = new Point(412, 296);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Enter Name";
            txtname.Size = new Size(355, 39);
            txtname.TabIndex = 37;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(158, 444);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 45;
            label4.Text = "FeedBack";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 371);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 44;
            label3.Text = "Purpose";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 296);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 43;
            label2.Text = "Full Name";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(23, 28);
            button6.Name = "button6";
            button6.Size = new Size(54, 58);
            button6.TabIndex = 42;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 99);
            label1.Name = "label1";
            label1.Size = new Size(191, 42);
            label1.TabIndex = 41;
            label1.Text = "Feedback";
            // 
            // newformrandom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 687);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnsave);
            Controls.Add(txtfeedback);
            Controls.Add(txtpurpose);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(label1);
            Name = "newformrandom";
            Text = "newformrandom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label5;
        private Button button2;
        private Button btnsave;
        private TextBox txtfeedback;
        private TextBox txtpurpose;
        private TextBox txtname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button6;
        private Label label1;
    }
}