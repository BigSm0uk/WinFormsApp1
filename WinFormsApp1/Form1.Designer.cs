namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Узел1");
            TreeNode treeNode2 = new TreeNode("Узел2");
            TreeNode treeNode3 = new TreeNode("Узел3");
            TreeNode treeNode4 = new TreeNode("Узел0", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Узел5");
            TreeNode treeNode6 = new TreeNode("Узел6");
            TreeNode treeNode7 = new TreeNode("Узел4", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Узел9");
            TreeNode treeNode9 = new TreeNode("Узел10");
            TreeNode treeNode10 = new TreeNode("Узел7", new TreeNode[] { treeNode8, treeNode9 });
            TreeNode treeNode11 = new TreeNode("Узел8");
            label1 = new Label();
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            appDbContextBindingSource1 = new BindingSource(components);
            appDbContextBindingSource = new BindingSource(components);
            panel1 = new Panel();
            button1 = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 0;
            label1.Text = "Мастер-Монтаж";
            label1.UseMnemonic = false;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            treeView1.HideSelection = false;
            treeView1.Location = new Point(12, 44);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Узел1";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Узел2";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Узел3";
            treeNode4.Name = "Узел0";
            treeNode4.Text = "Узел0";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Узел5";
            treeNode6.Name = "Узел6";
            treeNode6.Text = "Узел6";
            treeNode7.Name = "Узел4";
            treeNode7.Text = "Узел4";
            treeNode8.Name = "Узел9";
            treeNode8.Text = "Узел9";
            treeNode9.Name = "Узел10";
            treeNode9.Text = "Узел10";
            treeNode10.Name = "Узел7";
            treeNode10.Text = "Узел7";
            treeNode11.Name = "Узел8";
            treeNode11.Text = "Узел8";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode10, treeNode11 });
            treeView1.ShowLines = false;
            treeView1.ShowPlusMinus = false;
            treeView1.ShowRootLines = false;
            treeView1.Size = new Size(229, 394);
            treeView1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(247, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(934, 605);
            dataGridView1.TabIndex = 2;
            // 
            // appDbContextBindingSource1
            // 
            appDbContextBindingSource1.DataSource = typeof(DataAccess.AppDbContext);
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(DataAccess.AppDbContext);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(13, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 208);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(22, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Анализ";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 87);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "2024";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "2023";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "2022";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(treeView1);
            Controls.Add(label1);
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TreeView treeView1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private BindingSource appDbContextBindingSource;
        private BindingSource appDbContextBindingSource1;
    }
}
