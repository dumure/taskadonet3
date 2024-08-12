namespace taskadonet3
{
    partial class Form1
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(274, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(373, 232);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 319);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 2;
            label1.Text = "Author:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 319);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
    }
}
