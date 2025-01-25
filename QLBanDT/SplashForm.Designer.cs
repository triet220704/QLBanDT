namespace QLBanDT
{
    partial class SplashForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(638, 41);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 2;
            label2.Text = "Phiên Bản 1.0";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(281, 42);
            label3.Name = "label3";
            label3.Size = new Size(237, 18);
            label3.TabIndex = 3;
            label3.Text = "Phát Triển Bằng Không Gian Mã";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(176, 3);
            label4.Name = "label4";
            label4.Size = new Size(456, 38);
            label4.TabIndex = 4;
            label4.Text = "HỆ THỐNG QUẢN LÍ TỒN KHO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LavenderBlush;
            label5.Location = new Point(281, 423);
            label5.Name = "label5";
            label5.Size = new Size(237, 18);
            label5.TabIndex = 3;
            label5.Text = "Phát Triển Bằng Không Gian Mã";
            label5.Click += label3_Click;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.BackColor = Color.Transparent;
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.FillThickness = 10;
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(305, 121);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.DodgerBlue;
            guna2CircleProgressBar1.ProgressColor2 = Color.Empty;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(213, 213);
            guna2CircleProgressBar1.TabIndex = 5;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
    }
}