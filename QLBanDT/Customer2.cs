using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Guna.UI2.WinForms;
namespace QLBanDT
{
    public partial class Customer2 : Form
    {
        public Customer2()
        {
            InitializeComponent();
        }
        private string connectionstring = "Server=AHIUS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

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
                    string myquery = "SELECT * FROM KhachHang ";

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo đối tượng SqlCommandBuilder
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    // Tạo DataSet để chứa dữ liệu
                    DataSet ds = new DataSet();

                    // Điền dữ liệu vào DataSet
                    da.Fill(ds);

                    // Gán DataSource cho DataGridView
                    panel36.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để thêm người dùng
                    string query = "INSERT INTO KhachHang (Id, TenKhachHang, SoDienThoai) VALUES (@Id, @TenKhachHang, @SoDienThoai)";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Id", guna2TextBox1.Text);  // unameTb là textbox cho tên đăng nhập
                    cmd.Parameters.AddWithValue("@TenKhachHang", guna2TextBox2.Text);     // FnameTb là textbox cho họ tên
                    cmd.Parameters.AddWithValue("@SoDienThoai", guna2TextBox3.Text);   // PasswordTb là textbox cho mật khẩu


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
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox26_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=AHIUS;Initial Catalog=QLBanDT;Integrated Security=True;Trust Server Certificate=True");

        private void panel36_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào: đảm bảo các textbox không rỗng
                if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật.");
                    return;
                }

                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để cập nhật thông tin người dùng
                    string query = "UPDATE KhachHang " +
                                   "SET Id = @Id, TenKhachHang = @TenKhachHang, SoDienThoai = @SoDienThoai " +
                                   "WHERE Id = @Id ";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Id", guna2TextBox1.Text);  // unameTb là textbox cho tên đăng nhập
                    cmd.Parameters.AddWithValue("@TenKhachHang", guna2TextBox2.Text);     // FnameTb là textbox cho họ tên
                    cmd.Parameters.AddWithValue("@SoDienThoai", guna2TextBox3.Text);   // PasswordTb là textbox cho mật khẩu

                    // Mở kết nối
                    con.Open();

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra nếu có dòng nào được cập nhật
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng với tài khoản đã nhập.");
                    }

                    // Cập nhật lại danh sách người dùng trên DataGridView
                    populate();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void Customer2_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản cần xóa.");
                return;
            }

            try
            {
                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để xóa người dùng theo số điện thoại
                    string query = "DELETE FROM KhachHang WHERE Id = @Id";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Id", guna2TextBox1.Text);

                    // Mở kết nối
                    con.Open();

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng với tài khoản này.");
                    }

                    // Cập nhật lại danh sách người dùng
                    populate();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
        }

        private void panel36_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox1.Text = panel36.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox2.Text = panel36.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox3.Text = panel36.SelectedRows[0].Cells[2].Value.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from KhachHang Where Id = " + guna2TextBox1.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label2.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count (*) from KhachHang Where Id = " + guna2TextBox1.Text + "", con);

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            label3.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count (*) from KhachHang Where Id = " + guna2TextBox1.Text + "", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            label5.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
    }
}
