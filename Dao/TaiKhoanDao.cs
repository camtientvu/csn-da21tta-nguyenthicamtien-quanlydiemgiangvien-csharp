using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class TaiKhoanDao
    {
        private readonly SqlConnection _conn;
        public TaiKhoanDao(string connection)
        {
            _conn = new SqlConnection(connection);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    _conn.Close();
                    _conn.Dispose();
                }
                else
                {
                    _conn.Dispose();
                }
            }
        }

        public bool KiemTraTenDangNhapTonTai(string ten_dn)
        {
            string query = $"select * from tai_khoan where tai_khoan ='{ten_dn}';";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    if (_conn.State != System.Data.ConnectionState.Open)
                    {
                        _conn.Open();
                    }

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            _conn.Close();

            return false;
        }

        public List<TaiKhoanModel> LayTatCaTaiKhoan(string email = null)
        {
            string query = $"select * from tai_khoan ";
            if (email != null && email != "")
            {
                query = query + $"where email like '%{email}%'";
            }

            List<TaiKhoanModel> results = new List<TaiKhoanModel>();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    if (_conn.State != System.Data.ConnectionState.Open)
                    {
                        _conn.Open();
                    }
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new TaiKhoanModel
                            {
                                id = reader["id"].ToString(),
                                tai_khoan = reader["tai_khoan"].ToString(),
                                mat_khau = reader["mat_khau"].ToString(),
                                email = reader["email"].ToString(),
                                ngay_tao = reader["ngay_tao"].ToString(),
                                ngay_dangnhap_cuoicung = reader["ngay_dang_nhap"].ToString(),
                                trang_thai = Convert.ToBoolean(reader["trang_thai"].ToString()) == true ? "Khóa" : "Hoạt động",
                            }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return results;
            }
            _conn.Close();

            return results;
        }

        public int ThemTaiKhoan(string tai_khoan, string mat_khau, string email, bool trang_thai)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into tai_khoan values (@id,@tai_khoan,@mat_khau,@email,@ngay_tao,@ngay_dang_nhap,@trang_thai)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@tai_khoan", tai_khoan);
                cmd.Parameters.AddWithValue("@mat_khau", mat_khau);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ngay_tao", DateTime.Now);
                cmd.Parameters.AddWithValue("@ngay_dang_nhap", DateTime.Now);
                cmd.Parameters.AddWithValue("@trang_thai", trang_thai);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return res;
            }

            return res;
        }

        public int CapNhapTaiKhoan(string id, string tai_khoan, string mat_khau, string email,DateTime ngay_tao ,DateTime ngay_dang_nhap, bool trang_thai)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update tai_khoan set tai_khoan = @tai_khoan, mat_khau = @mat_khau, email = @email,ngay_tao = @ngay_tao,ngay_dang_nhap = @ngay_dang_nhap, trang_thai = @trang_thai" +
                    $" where id = '{id}';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@tai_khoan", tai_khoan);
                cmd.Parameters.AddWithValue("@mat_khau", mat_khau);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ngay_tao", ngay_tao);
                cmd.Parameters.AddWithValue("@ngay_dang_nhap", ngay_dang_nhap);
                cmd.Parameters.AddWithValue("@trang_thai", trang_thai);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int XoaTaiKhoan(string id_taikhoan)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from tai_khoan where id = '{id_taikhoan}';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return res;
            }
            return res;
        }
    }
}
