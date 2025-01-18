﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace QLBanDT
{
    public partial class Splash : Form
    {
        // Đặt biến connectionstring bên trong lớp Splash
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        public Splash()
        {
            InitializeComponent();
        }
        void populate()
        {
            try
            {
                // Khai báo và khởi tạo đối tượng SqlConnection
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Mở kết nối
                    con.Open();

                    // Câu lệnh SQL để lấy dữ liệu
                    string myquery = "SELECT * FROM NguoiDung";

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo đối tượng SqlCommandBuilder
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    // Tạo DataSet để chứa dữ liệu
                    DataSet ds = new DataSet();

                    // Điền dữ liệu vào DataSet
                    da.Fill(ds);

                    // Gán DataSource cho DataGridView
                    DsUser.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để thêm người dùng
                    string query = "INSERT INTO NguoiDung (Username, HoTen, Pass, sdt) VALUES (@Username, @HoTen, @Pass, @sdt)";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Username", unameTb.Text);  // unameTb là textbox cho tên đăng nhập
                    cmd.Parameters.AddWithValue("@HoTen", FnameTb.Text);     // FnameTb là textbox cho họ tên
                    cmd.Parameters.AddWithValue("@Pass", PasswordTb.Text);   // PasswordTb là textbox cho mật khẩu
                    cmd.Parameters.AddWithValue("@sdt", PhoneTb.Text);       // PhoneTb là textbox cho số điện thoại

                    // Mở kết nối
                    con.Open();

                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();

                    // Thông báo thành công
                    MessageBox.Show("Thêm người dùng thành công!");
                    populate();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DsUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
