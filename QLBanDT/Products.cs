using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace QLBanDT
{
    public partial class Products : Form
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        public Products()
        {
            InitializeComponent();
        }

        // Phương thức điền danh mục sản phẩm vào ComboBox
        void FillCategories()
        {
            string query = "SELECT LoaiId, TenLoai FROM LoaiSP"; // Lấy cả LoaiId và TenLoai

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("LoaiId", typeof(int));   // Cột LoaiId
                        dt.Columns.Add("TenLoai", typeof(string)); // Cột TenLoai

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            dt.Load(rdr);
                        }

                        // Gán cho ComboBox
                        comboBox1.ValueMember = "LoaiId";  // Lưu LoaiId khi người dùng chọn một item
                        comboBox1.DisplayMember = "TenLoai";  // Hiển thị TenLoai trong ComboBox
                        comboBox1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục sản phẩm: {ex.Message}", "Thông báo");
            }
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
                    string myquery = "SELECT SP.id, SP.TenSP, SP.Gia, SP.SL, SP.ram, SP.pin, SP.bonho, SP.Details, LoaiSP.TenLoai, SP.img " +
                                     "FROM SP " +
                                     "JOIN LoaiSP ON SP.LoaiId = LoaiSP.LoaiId"; // JOIN để lấy tên loại sản phẩm

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo DataSet để chứa dữ liệu
                    DataSet ds = new DataSet();

                    // Điền dữ liệu vào DataSet
                    da.Fill(ds);

                    // Gán DataSource cho DataGridView
                    DsUser.DataSource = ds.Tables[0];

                    // Kiểm tra và ẩn cột img nếu có
                    if (DsUser.Columns.Contains("img"))
                    {
                        DsUser.Columns["img"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        private void DsUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DsUser.SelectedRows.Count > 0) { 
            unameTb.Text = DsUser.SelectedRows[0].Cells[0].Value.ToString();
            Fnametb.Text = DsUser.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = DsUser.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = DsUser.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox1.Text = DsUser.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox2.Text = DsUser.SelectedRows[0].Cells[5].Value.ToString();
            guna2TextBox4.Text = DsUser.SelectedRows[0].Cells[6].Value.ToString();
            guna2TextBox3.Text = DsUser.SelectedRows[0].Cells[7].Value.ToString();
            comboBox1.Text = DsUser.SelectedRows[0].Cells[8].Value.ToString();
            var imgBytes = DsUser.SelectedRows[0].Cells["img"].Value;
            if (imgBytes != DBNull.Value && imgBytes != null)
            {                
                // Chuyển đổi byte[] thành hình ảnh và hiển thị
                byte[] imageBytes = (byte[])imgBytes;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }            
        }

        private void Products_Load_1(object sender, EventArgs e)
        {
            // Điền danh mục vào ComboBox khi form được tải
            FillCategories();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tính hợp lệ của dữ liệu đầu vào
                if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(Fnametb.Text) ||
                    string.IsNullOrEmpty(PasswordTb.Text) || string.IsNullOrEmpty(PhoneTb.Text)
                    || string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) ||
                    string.IsNullOrEmpty(guna2TextBox4.Text) || string.IsNullOrEmpty(guna2TextBox3.Text) ||
                    comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                //if (!int.TryParse(PhoneTb.Text, out int soLuong) || soLuong < 0)
                //{
                //    MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo");
                //    return;
                //}

                //if (!decimal.TryParse(PasswordTb.Text, out decimal gia) || gia <= 0)
                //{
                //    MessageBox.Show("Giá phải là số dương!", "Thông báo");
                //    return;
                //}

                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO SP (id, TenSP, Gia,SL,ram,pin,bonho, Details, LoaiId) " +
                                   "VALUES (@id, @TenSP, @Gia,@SL,@ram,@pin,@bonho, @Details, @LoaiId)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", unameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", Fnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@SL", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ram", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@pin", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bonho", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Details", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiId", comboBox1.SelectedValue); // Lưu LoaiId vào cơ sở dữ liệu

                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat); // Lưu ảnh vào MemoryStream
                            byte[] imgBytes = ms.ToArray();
                            cmd.Parameters.AddWithValue("@img", imgBytes);  // Lưu ảnh dưới dạng byte array
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value);  // Nếu không có ảnh
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào: đảm bảo các textbox không rỗng
                if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(Fnametb.Text) ||
                    string.IsNullOrEmpty(PasswordTb.Text) || string.IsNullOrEmpty(PhoneTb.Text)
                    || string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) ||
                    string.IsNullOrEmpty(guna2TextBox4.Text) || string.IsNullOrEmpty(guna2TextBox3.Text) ||
                    comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật.");
                    return;
                }

                // Kiểm tra số lượng và giá trị
                //if (!int.TryParse(guna2TextBox1.Text, out int soLuong) || soLuong < 0)
                //{
                //    MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo");
                //    return;
                //}

                //if (!decimal.TryParse(guna2TextBox2.Text, out decimal gia) || gia <= 0)
                //{
                //    MessageBox.Show("Giá phải là số dương!", "Thông báo");
                //    return;
                //}

                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để cập nhật thông tin sản phẩm
                    string query = "UPDATE SP " +
                                   "SET TenSP = @TenSP, Gia = @Gia, SL = @SL, Details = @Details, LoaiId = @LoaiId, img = @img, " +
                                   "ram = @ram, pin = @pin, bonho = @bonho " +
                                   "WHERE id = @id";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@id", unameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", Fnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@SL", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ram", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@pin", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bonho", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Details", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiId", comboBox1.SelectedValue); // Lưu LoaiId vào cơ sở dữ liệu

                    // Xử lý ảnh
                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            byte[] imgBytes = ms.ToArray();
                            cmd.Parameters.AddWithValue("@img", imgBytes);
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value);  // Nếu không có ảnh, dùng DBNull.Value
                    }

                    // Mở kết nối
                    con.Open();

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra nếu có dòng nào được cập nhật
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm đã nhập.");
                    }

                    // Cập nhật lại danh sách sản phẩm trên DataGridView
                    populate();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "")
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
                    string query = "DELETE FROM SP WHERE id = @id";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@id", unameTb.Text);

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

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            unameTb.Text = "";
            Fnametb.Text = "";
            PasswordTb.Text = "";
            PhoneTb.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
        }
    }
}
