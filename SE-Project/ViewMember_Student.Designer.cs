namespace SE_Project
{
    partial class ViewMember_Student
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
            txtSearchItem = new TextBox();
            label2 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(766, 159);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "    Search";
            txtSearchItem.Size = new Size(242, 31);
            txtSearchItem.TabIndex = 25;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(775, 126);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 24;
            label2.Text = "Search";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(54, 58);
            button3.TabIndex = 23;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(952, 260);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 41);
            label1.Name = "label1";
            label1.Size = new Size(255, 42);
            label1.TabIndex = 19;
            label1.Text = "View Member";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 596);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 26;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // ViewMember_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 766);
            Controls.Add(button2);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ViewMember_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember_Student";
            Load += ViewMember_Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchItem;
        private Label label2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
    }
}