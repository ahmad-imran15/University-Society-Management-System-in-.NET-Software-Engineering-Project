namespace SE_Project
{
    partial class Update_Societies_Admin
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
            label2 = new Label();
            txtSearchItem = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtName = new TextBox();
            txtPresidentName = new TextBox();
            txtDescription = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 31);
            label1.Name = "label1";
            label1.Size = new Size(275, 40);
            label1.TabIndex = 0;
            label1.Text = "Update Society";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(712, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Search";
            label2.Click += label2_Click;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(703, 124);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "    Search";
            txtSearchItem.Size = new Size(242, 31);
            txtSearchItem.TabIndex = 2;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(828, 211);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(68, 410);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(554, 421);
            label4.Name = "label4";
            label4.Size = new Size(121, 26);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.Location = new Point(68, 502);
            label5.Name = "label5";
            label5.Size = new Size(169, 26);
            label5.TabIndex = 6;
            label5.Text = "President Name";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(581, 615);
            button1.Name = "button1";
            button1.Size = new Size(188, 68);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(23, 630);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 7;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 439);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Name";
            txtName.Size = new Size(331, 31);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPresidentName
            // 
            txtPresidentName.Location = new Point(68, 531);
            txtPresidentName.Name = "txtPresidentName";
            txtPresidentName.PlaceholderText = "Enter President Name";
            txtPresidentName.Size = new Size(331, 31);
            txtPresidentName.TabIndex = 4;
            txtPresidentName.TextChanged += textBox3_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(554, 450);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter Description";
            txtDescription.Size = new Size(310, 92);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(23, 22);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 8;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Update_Societies_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button3);
            Controls.Add(txtDescription);
            Controls.Add(txtPresidentName);
            Controls.Add(txtName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_Societies_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Societies_Admin";
            Load += Update_Societies_Admin_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchItem;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox txtName;
        private TextBox txtPresidentName;
        private TextBox txtDescription;
        private Button button3;
    }
}