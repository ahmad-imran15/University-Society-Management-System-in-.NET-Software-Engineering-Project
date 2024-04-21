namespace SE_Project
{
    partial class Update_Society_president
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
            txtDescription = new TextBox();
            txtPresidentName = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 18);
            label1.Name = "label1";
            label1.Size = new Size(275, 40);
            label1.TabIndex = 1;
            label1.Text = "Update Society";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(664, 364);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter Description";
            txtDescription.Size = new Size(333, 98);
            txtDescription.TabIndex = 4;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtPresidentName
            // 
            txtPresidentName.Location = new Point(109, 471);
            txtPresidentName.Name = "txtPresidentName";
            txtPresidentName.PlaceholderText = "Enter Batch";
            txtPresidentName.Size = new Size(331, 31);
            txtPresidentName.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 360);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Name";
            txtName.Size = new Size(331, 31);
            txtName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 433);
            label5.Name = "label5";
            label5.Size = new Size(138, 29);
            label5.TabIndex = 14;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(664, 320);
            label4.Name = "label4";
            label4.Size = new Size(135, 29);
            label4.TabIndex = 13;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 320);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(579, 521);
            button1.Name = "button1";
            button1.Size = new Size(190, 66);
            button1.TabIndex = 5;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(50, 603);
            button2.Name = "button2";
            button2.Size = new Size(117, 42);
            button2.TabIndex = 6;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(165, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(743, 146);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(29, 18);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 7;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Update_Society_president
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Controls.Add(txtPresidentName);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Update_Society_president";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Society_president";
            Load += Update_Society_president_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescription;
        private TextBox txtPresidentName;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
    }
}