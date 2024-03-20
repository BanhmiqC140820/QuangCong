namespace QlCoffee
{
    partial class FormThongKe
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
            dataGridView1 = new DataGridView();
            Ngay = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ngay, TongTien });
            dataGridView1.Location = new Point(37, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(370, 241);
            dataGridView1.TabIndex = 0;
            // 
            // Ngay
            // 
            Ngay.HeaderText = "Ngày";
            Ngay.Name = "Ngay";
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(37, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(273, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 415);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 3;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 108);
            label1.Name = "label1";
            label1.Size = new Size(370, 36);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn TongTien;
        private Button button2;
        private Label label1;
    }
}