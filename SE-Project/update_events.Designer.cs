namespace SE_Project
{
    partial class update_events
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtSearchItem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtPhonenumber = new TextBox();
            txtfullName = new TextBox();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(680, 646);
            button1.Name = "button1";
            button1.Size = new Size(188, 68);
            button1.TabIndex = 35;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(828, 211);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(818, 132);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "    Search";
            txtSearchItem.Size = new Size(242, 31);
            txtSearchItem.TabIndex = 31;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(827, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 30;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 71);
            label1.Name = "label1";
            label1.Size = new Size(266, 40);
            label1.TabIndex = 28;
            label1.Text = "Update Events";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(680, 411);
            label4.Name = "label4";
            label4.Size = new Size(178, 30);
            label4.TabIndex = 42;
            label4.Text = "Starting Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(680, 495);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 41;
            label6.Text = "Ending Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(680, 528);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 40;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(680, 444);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 39;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(174, 401);
            label7.Name = "label7";
            label7.Size = new Size(164, 30);
            label7.TabIndex = 43;
            label7.Text = "Event Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(174, 494);
            label8.Name = "label8";
            label8.Size = new Size(158, 30);
            label8.TabIndex = 44;
            label8.Text = "Description";
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(174, 527);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.PlaceholderText = "Enter Updated Description";
            txtPhonenumber.Size = new Size(331, 31);
            txtPhonenumber.TabIndex = 33;
            txtPhonenumber.TextChanged += txtPhonenumber_TextChanged;
            // 
            // txtfullName
            // 
            txtfullName.Location = new Point(174, 434);
            txtfullName.Name = "txtfullName";
            txtfullName.PlaceholderText = "Enter Updated Name";
            txtfullName.Size = new Size(331, 31);
            txtfullName.TabIndex = 32;
            txtfullName.TextChanged += txtfullName_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(55, 24);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 45;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(55, 646);
            button2.Name = "button2";
            button2.Size = new Size(110, 46);
            button2.TabIndex = 46;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // update_events
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPhonenumber);
            Controls.Add(txtfullName);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "update_events";
            Text = "update_events";
            Load += update_events_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtSearchItem;
        private Label label2;
        private Label label1;
        private Label label4; 

        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private TextBox txtPhonenumber;
        private TextBox txtfullName;
        private Button button3;
        private Button button2;
    }
}