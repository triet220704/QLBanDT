using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBanDT
{
    public partial class Order : Form
    {
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";
        public Order()
        {
            InitializeComponent();
        }



        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

<<<<<<< Updated upstream
        private void button2_Click(object sender, EventArgs e)
=======
            if (string.IsNullOrWhiteSpace(QuyTB.Text))
            {
                MessageBox.Show("Nhập vào số lượng của sản phẩm");
                return;
            }

            // Kiểm tra và chuyển đổi số lượng từ TextBox
            // int soLuong;
            if (!int.TryParse(QuyTB.Text, out sốlượng) || sốlượng <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return;
            }
            if (Convert.ToUInt32(QuyTB.Text) > stock)
            {
                MessageBox.Show("Không đủ lượng hàng trong kho!");
                return;
            }

            // Kiểm tra nếu table chưa được khởi tạo
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("Số thứ tự", typeof(int));
                table.Columns.Add("Số Lượng", typeof(int));
                table.Columns.Add("Sản Phẩm", typeof(string));
                table.Columns.Add("Giá", typeof(int));
                table.Columns.Add("Tổng Giá", typeof(int));
            }

            // Kiểm tra sản phẩm và giá hợp lệ
            if (string.IsNullOrEmpty(sảnphẩm) || giá <= 0)
            {
                MessageBox.Show("Dữ liệu sản phẩm không hợp lệ!");
                return;
            }

            // Tính tổng giá
            số = số + 1;
            sốlượng = Convert.ToInt32(QuyTB.Text);
            tổnggiá = giá * sốlượng;

            // Thêm dữ liệu vào bảng
            table.Rows.Add(số, sốlượng, sảnphẩm, giá, tổnggiá);

            // Cập nhật DataGridView
            OrderGV.DataSource = null;
            OrderGV.DataSource = table;
            OrderGV.Refresh();

            // Reset flag
            flag = 0;
            sum += tổnggiá;
            totalamount.Text = ":" + sum.ToString();
            updateproduct();
        }
        // Khai báo biến kết nối SQL
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-AS1JC9I8\\MSSQLSERVER02;Initial Catalog=QLBanDT;Integrated Security=True;Trust Server Certificate=True");

        void updateproduct()
        {


           

            int id = Convert.ToInt32(ProdGv.SelectedRows[0].Cells[0].Value);
            int newsoluong = stock - Convert.ToInt32(QuyTB.Text);
            if (newsoluong < 0)
            {
                MessageBox.Show("Không hoạt động");
            }
            else
            {
                Con.Open();
                // Lệnh SQL đúng cú pháp
                string query = "UPDATE SP SET SL = " + newsoluong + " WHERE id = " + id + ";";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                // Gọi lại hàm cập nhật danh sách sản phẩm
                populateProduct();
            }
            Con.Close();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }
        int số = 0;
        int giá, tổnggiá, sốlượng;
        String sảnphẩm;
        private void Order_Load(object sender, EventArgs e)
        {
            populate();
            populateProduct();
            FillCategories();

        }

        private void button4_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }
<<<<<<< Updated upstream
=======

        private void CUSTOMERSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Custid.Text = CUSTOMERSGV.SelectedRows[0].Cells[0].Value.ToString();
            CUSTNAME.Text = CUSTOMERSGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void OrderTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int flag = 0;
        int stock;
        private void ProdGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sảnphẩm = ProdGv.SelectedRows[0].Cells[1].Value.ToString();
            // sốlượng = Convert.ToInt32(QuyTB.Text);
            // giá = Convert.ToInt32(ProdGv.SelectedRows[0].Cells[2].Value.ToString());
            giá = Convert.ToInt32(ProdGv.SelectedRows[0].Cells[2].Value);
            stock = Convert.ToInt32(ProdGv.SelectedRows[0].Cells[3].Value.ToString());
            //  tổnggiá = sốlượng * giá;
            flag = 1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrderIdTb.Text) || string.IsNullOrEmpty(Custid.Text) ||
                string.IsNullOrEmpty(CUSTNAME.Text) || string.IsNullOrEmpty(totalamount.Text) || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            try
            {
                // Kiểm tra tổng tiền hợp lệ
                //if (!decimal.TryParse(totalamount.Text, out decimal totalAmount))
                //{
                //    MessageBox.Show("Tổng tiền không hợp lệ! Vui lòng nhập số hợp lệ.", "Lỗi nhập liệu");
                //    return;
                //}

                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    // 1️⃣ Kiểm tra xem MaDH đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM DatHang WHERE MaDH = @MaDH";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@MaDH", OrderIdTb.Text.Trim());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0) // Nếu mã đơn hàng đã tồn tại
                        {
                            MessageBox.Show("Mã đơn hàng đã tồn tại! Vui lòng nhập mã khác.", "Lỗi trùng lặp");
                            return;
                        }
                    }
                    con.Close();
                    string query = "INSERT INTO DatHang (MaDH, Id, TenKhachHang, NgayDatHang, LoaiId, Tongtien) " +
                                   "VALUES (@MaDH, @Id, @TenKhachHang, @NgayDatHang, @LoaiId, @Tongtien)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", OrderIdTb.Text.Trim()); // Mã đơn hàng
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(Custid.Text)); // ID Khách hàng
                        cmd.Parameters.AddWithValue("@TenKhachHang", CUSTNAME.Text.Trim()); // Tên khách hàng
                        cmd.Parameters.AddWithValue("@NgayDatHang", Orderdate.Value.ToString("yyyy-MM-dd")); // Ngày đặt hàng đúng format
                        cmd.Parameters.AddWithValue("@LoaiId", Convert.ToInt32(comboBox1.SelectedValue)); // Loại sản phẩm
                        cmd.Parameters.AddWithValue("@Tongtien", tổnggiá);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo");
                        populate(); // Cập nhật danh sách đơn hàng
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();

        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalamount_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}


