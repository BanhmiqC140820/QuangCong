namespace QLCoffee
{
    partial class FormQLLoaiCoffe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLoaiCoffe));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongSPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            loaiDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 147);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maLoaiDataGridViewTextBoxColumn, tenLoaiDataGridViewTextBoxColumn, soLuongSPDataGridViewTextBoxColumn, edit, Delete });
            dataGridView1.DataSource = loaiDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(402, 122);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            maLoaiDataGridViewTextBoxColumn.Width = 75;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            tenLoaiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // soLuongSPDataGridViewTextBoxColumn
            // 
            soLuongSPDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSP";
            soLuongSPDataGridViewTextBoxColumn.HeaderText = "SoLuongSP";
            soLuongSPDataGridViewTextBoxColumn.Name = "soLuongSPDataGridViewTextBoxColumn";
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.Name = "edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 50;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 50;
            // 
            // loaiDTOBindingSource
            // 
            loaiDTOBindingSource.DataSource = typeof(DTO.LoaiDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(402, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(51, 22);
            toolStripButton1.Text = "ADD";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(88, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 5;
            label1.Text = "Danh mục loại sản phẩm";
            // 
            // FormQLLoaiCoffe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 263);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormQLLoaiCoffe";
            Text = "Quản lý loại sản phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource loaiDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongSPDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn Delete;
        private Label label1;
    }
}