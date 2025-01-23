namespace QLBanDT
{
    partial class Order
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label15 = new Label();
            CUSTOMERSGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            unameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CUSTOMERSGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 125);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1032, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 37);
            label6.TabIndex = 1;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 34);
            label1.Name = "label1";
            label1.Size = new Size(427, 47);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 649);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 10);
            panel2.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DeepSkyBlue;
            label15.Location = new Point(75, 141);
            label15.Name = "label15";
            label15.Size = new Size(311, 31);
            label15.TabIndex = 22;
            label15.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // CUSTOMERSGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            CUSTOMERSGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            CUSTOMERSGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            CUSTOMERSGV.ColumnHeadersHeight = 4;
            CUSTOMERSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            CUSTOMERSGV.DefaultCellStyle = dataGridViewCellStyle6;
            CUSTOMERSGV.GridColor = Color.FromArgb(231, 229, 255);
            CUSTOMERSGV.Location = new Point(12, 184);
            CUSTOMERSGV.Name = "CUSTOMERSGV";
            CUSTOMERSGV.RowHeadersVisible = false;
            CUSTOMERSGV.RowHeadersWidth = 51;
            CUSTOMERSGV.Size = new Size(443, 223);
            CUSTOMERSGV.TabIndex = 23;
            CUSTOMERSGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CUSTOMERSGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CUSTOMERSGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CUSTOMERSGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CUSTOMERSGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CUSTOMERSGV.ThemeStyle.BackColor = Color.White;
            CUSTOMERSGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CUSTOMERSGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CUSTOMERSGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CUSTOMERSGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CUSTOMERSGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CUSTOMERSGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CUSTOMERSGV.ThemeStyle.HeaderStyle.Height = 4;
            CUSTOMERSGV.ThemeStyle.ReadOnly = false;
            CUSTOMERSGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CUSTOMERSGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CUSTOMERSGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CUSTOMERSGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CUSTOMERSGV.ThemeStyle.RowsStyle.Height = 29;
            CUSTOMERSGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CUSTOMERSGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(522, 189);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 25;
            label2.Text = "MÃ ĐƠN HÀNG";
            // 
            // unameTb
            // 
            unameTb.BorderRadius = 10;
            unameTb.CustomizableEdges = customizableEdges7;
            unameTb.DefaultText = "";
            unameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            unameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            unameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            unameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            unameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            unameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            unameTb.Location = new Point(715, 184);
            unameTb.Margin = new Padding(5);
            unameTb.Name = "unameTb";
            unameTb.PasswordChar = '\0';
            unameTb.PlaceholderForeColor = Color.DeepSkyBlue;
            unameTb.PlaceholderText = "";
            unameTb.SelectedText = "";
            unameTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            unameTb.Size = new Size(207, 39);
            unameTb.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(522, 233);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 27;
            label3.Text = "MÃ KHÁCH HÀNG";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(715, 229);
            guna2TextBox1.Margin = new Padding(5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.DeepSkyBlue;
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(207, 39);
            guna2TextBox1.TabIndex = 26;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.BackColor = SystemColors.Control;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges11;
            guna2DateTimePicker1.FillColor = Color.DeepSkyBlue;
            guna2DateTimePicker1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DateTimePicker1.ForeColor = Color.White;
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(715, 284);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2DateTimePicker1.Size = new Size(250, 45);
            guna2DateTimePicker1.TabIndex = 28;
            guna2DateTimePicker1.Value = new DateTime(2025, 1, 23, 20, 20, 25, 250);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(522, 291);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 29;
            label4.Text = "NGÀY ĐẶT HÀNG";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 659);
            Controls.Add(label4);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(label3);
            Controls.Add(guna2TextBox1);
            Controls.Add(label2);
            Controls.Add(unameTb);
            Controls.Add(CUSTOMERSGV);
            Controls.Add(label15);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CUSTOMERSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Panel panel2;
        private Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView CUSTOMERSGV;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox unameTb;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Label label4;
    }
}