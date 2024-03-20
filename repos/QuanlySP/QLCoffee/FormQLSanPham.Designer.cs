namespace QLCoffee
{
    partial class FormQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSanPham));
            dataGridView1 = new DataGridView();
            coffeDTOBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnADD = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            btnTK = new ToolStripButton();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPHamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xuatXuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            edit = new DataGridViewButtonColumn();
            details = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tenSanPHamDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, xuatXuDataGridViewTextBoxColumn, imageDataGridViewImageColumn, edit, details, delete });
            dataGridView1.DataSource = coffeDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 5;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.Size = new Size(1103, 326);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // coffeDTOBindingSource
            // 
            coffeDTOBindingSource.DataSource = typeof(DTO.CoffeDTO);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Danh mục sản phẩm";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(20, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 351);
            panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnADD, toolStripTextBox1, btnTK });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1103, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            btnADD.Alignment = ToolStripItemAlignment.Right;
            btnADD.Image = (Image)resources.GetObject("btnADD.Image");
            btnADD.ImageTransparentColor = Color.Magenta;
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(51, 22);
            btnADD.Text = "ADD";
            btnADD.Click += btnADD_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(150, 25);
            // 
            // btnTK
            // 
            btnTK.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTK.Image = (Image)resources.GetObject("btnTK.Image");
            btnTK.ImageTransparentColor = Color.Magenta;
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(60, 22);
            btnTK.Text = "Tìm kiếm";
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.Frozen = true;
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            maSanPhamDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenSanPHamDataGridViewTextBoxColumn
            // 
            tenSanPHamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPHam";
            tenSanPHamDataGridViewTextBoxColumn.Frozen = true;
            tenSanPHamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tenSanPHamDataGridViewTextBoxColumn.Name = "tenSanPHamDataGridViewTextBoxColumn";
            tenSanPHamDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            tenSanPHamDataGridViewTextBoxColumn.Width = 225;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.Frozen = true;
            giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.Frozen = true;
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số lương";
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // xuatXuDataGridViewTextBoxColumn
            // 
            xuatXuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            xuatXuDataGridViewTextBoxColumn.DataPropertyName = "XuatXu";
            xuatXuDataGridViewTextBoxColumn.HeaderText = "Xuất xứ";
            xuatXuDataGridViewTextBoxColumn.Name = "xuatXuDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.DataPropertyName = "image";
            imageDataGridViewImageColumn.HeaderText = "image";
            imageDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            imageDataGridViewImageColumn.Width = 196;
            // 
            // edit
            // 
            edit.HeaderText = "edit";
            edit.Name = "edit";
            edit.SortMode = DataGridViewColumnSortMode.Programmatic;
            edit.Text = "edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 50;
            // 
            // details
            // 
            details.DataPropertyName = "details";
            details.HeaderText = "details";
            details.Name = "details";
            details.Text = "details";
            details.UseColumnTextForButtonValue = true;
            details.Width = 50;
            // 
            // delete
            // 
            delete.DataPropertyName = "delete";
            delete.HeaderText = "delete";
            delete.Name = "delete";
            delete.Text = "delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 50;
            // 
            // FormQLSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 549);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "FormQLSanPham";
            Text = "FormQLSanPham";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnADD;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnTK;
        private BindingSource coffeDTOBindingSource;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPHamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xuatXuDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn details;
        private DataGridViewButtonColumn delete;
    }
}