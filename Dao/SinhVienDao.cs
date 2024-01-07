using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class SinhVienDao
    {
        private readonly SqlConnection _conn;
        public SinhVienDao(string connection)
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

        public List<SinhVienModel> LayTatCaSinhVien(string ten_sv = null)
        {
            string query = $"select * from sinh_vien ";
            if (ten_sv != null && ten_sv != "")
            {
                query = query + $"where ten_sv like '%{ten_sv}%'";
            }

            List<SinhVienModel> results = new List<SinhVienModel>();
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
                            results.Add(new SinhVienModel
                            {
                                ma_sv = reader["ma_sv"].ToString(),
                                ten_sv = reader["ten_sv"].ToString(),
                                gioi_tinh = Convert.ToBoolean(reader["gioi_tinh"].ToString()) == true ? "Nam" : "Nữ",
                                ngay_sinh = reader["ngay_sinh"].ToString(),
                                id_nghanh = reader["id_nghanh"].ToString(),
                                id_lop = reader["id_lop"].ToString(),
                                ngay_tao = reader["ngay_tao"].ToString(),
                                trang_thai = Convert.ToBoolean(reader["trang_thai"].ToString()) == true ? "Đang học" : "Thôi học",
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

        public bool KiemTraMaSinhVienTonTai(string ma_sv)
        {
            string query = $"select * from sinh_vien where ma_sv ='{ma_sv}';";
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

        public int ThemSinhVien(string ma_sv, string ten_sv, bool gioi_tinh, DateTime ngay_sinh, string id_nghanh, string id_lop, bool trang_thai)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into sinh_vien values (@ma_sv,@ten_sv,@gioi_tinh,@ngay_sinh,@id_nghanh,@id_lop,@ngay_tao,@trang_thai)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@ma_sv", ma_sv);
                cmd.Parameters.AddWithValue("@ten_sv", ten_sv);
                cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
                cmd.Parameters.AddWithValue("@ngay_sinh", ngay_sinh);
                cmd.Parameters.AddWithValue("@id_nghanh", id_nghanh);
                cmd.Parameters.AddWithValue("@id_lop", id_lop);
                cmd.Parameters.AddWithValue("@ngay_tao", DateTime.Now);
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

        public int CapNhapSinhVienQuaMa(string ma_sv, string ten_sv, bool gioi_tinh , DateTime ngay_sinh, string id_nghanh, string id_lop, bool trang_thai)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update sinh_vien set ten_sv = @ten_sv, gioi_tinh = @gioi_tinh, ngay_sinh = @ngay_sinh, id_nghanh = @id_nghanh, id_lop = @id_lop, ngay_tao = @ngay_tao," +
                    $" trang_thai = @trang_thai where ma_sv = '{ma_sv}';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ten_sv", ten_sv);
                cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
                cmd.Parameters.AddWithValue("@ngay_sinh", ngay_sinh);
                cmd.Parameters.AddWithValue("@id_nghanh", id_nghanh);
                cmd.Parameters.AddWithValue("@id_lop", id_lop);
                cmd.Parameters.AddWithValue("@ngay_tao", DateTime.Now);
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

        public int XoaSinhVien(string ma_sv)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from sinh_vien where ma_sv = '{ma_sv}';";

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
