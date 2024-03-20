namespace BlogApp
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountArticlesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Details = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            categoryDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            Delete = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 267);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, amountArticlesDataGridViewTextBoxColumn, Edit, Details, btnDelete });
            dataGridView1.DataSource = categoryDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 242);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên danh mục";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 329;
            // 
            // amountArticlesDataGridViewTextBoxColumn
            // 
            amountArticlesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountArticlesDataGridViewTextBoxColumn.DataPropertyName = "AmountArticles";
            amountArticlesDataGridViewTextBoxColumn.HeaderText = "Số lượng bài viết";
            amountArticlesDataGridViewTextBoxColumn.Name = "amountArticlesDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 50;
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.Text = "Details";
            Details.UseColumnTextForButtonValue = true;
            Details.Width = 50;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 50;
            // 
            // categoryDTOBindingSource
            // 
            categoryDTOBindingSource.DataSource = typeof(DTO.CategoryDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, Delete, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(120, 22);
            toolStripLabel1.Text = "Danh Sách danh mục";
            // 
            // Delete
            // 
            Delete.Alignment = ToolStripItemAlignment.Right;
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageTransparentColor = Color.Magenta;
            Delete.Name = "Delete";
            Delete.Size = new Size(47, 22);
            Delete.Text = "Xóa";
            Delete.Click += Delete_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(46, 22);
            toolStripButton2.Text = "Sửa";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(57, 22);
            toolStripButton3.Text = "Thêm";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 116);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adelle Rg", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(221, 31);
            label1.Name = "label1";
            label1.Size = new Size(229, 26);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ DANH MUC";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton Delete;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private BindingSource categoryDTOBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountArticlesDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn btnDelete;
    }
}