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
    public class MonHocDao
    {
        private readonly SqlConnection _conn;
        public MonHocDao(string connection)
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

        public List<MonHocModel> LayTatCaMonHocTheoIdTaikhoan(string id_taikhoan)
        {
            string query = $"select mh.ma_monhoc,mh.ten_monhoc " +
                $"from mon_hoc mh " +
                $"join nghanh n on mh.id_nghanh = n.ma_nghanh " +
                $"join monhoc_hocky mhhk on mh.ma_monhoc = mhhk.ma_monhoc " +
                $"join quyen_monhoc qmh on qmh.id_monhoc = mh.ma_monhoc " +
                $"where 1 = 1";
            bool check = false;
            if (id_taikhoan != null && id_taikhoan != "-1" && !check)
            {
                query += $" and qmh.id_taikhoan = '{id_taikhoan}'";
            }

            query += " group by mh.ma_monhoc,mh.ten_monhoc";
            List<MonHocModel> models = new List<MonHocModel>();
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
                            models.Add(new MonHocModel
                            {
                                ma_monhoc = reader["ma_monhoc"].ToString(),
                                ten_monhoc = reader["ten_monhoc"].ToString()
                            }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return models;
            }
            _conn.Close();

            return models;
        }

        public List<MonHocModel> LayTatCaMonHoc(string ma_nghanh = null, string ten_monhoc = null)
        {
            string query = $"select n.ma_nghanh,n.ten_nghanh,mhhk.id_hocky,mh.ma_monhoc,mh.ten_monhoc,mh.ngay_ket_thuc " +
                $"from mon_hoc mh " +
                $"join nghanh n on mh.id_nghanh = n.ma_nghanh " +
                $"join monhoc_hocky mhhk on mh.ma_monhoc = mhhk.ma_monhoc " +
                $"where 1 = 1";
            bool check = false;
            if ((ma_nghanh != null && ma_nghanh != "-1") && (ten_monhoc != null && ten_monhoc != ""))
            {
                query += $" and id_nghanh = '{ma_nghanh}' and ten_monhoc like N'%{ten_monhoc}%'";
                check = true;
            }
            if (ma_nghanh != null && ma_nghanh != "-1" && !check)
            {
                query += $" and id_nghanh = '{ma_nghanh}'";
            }
            if (ten_monhoc != null && ten_monhoc != "" && !check)
            {
                query += $" and ten_monhoc like N'%{ten_monhoc}%'";
            }
            List<MonHocModel> models = new List<MonHocModel>();
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
                            models.Add(new MonHocModel
                            {
                                ma_nghanh = reader["ma_nghanh"].ToString(),
                                ten_nghanh = reader["ten_nghanh"].ToString(),
                                id_hocky = reader["id_hocky"].ToString(),
                                ma_monhoc = reader["ma_monhoc"].ToString(),
                                ten_monhoc = reader["ten_monhoc"].ToString(),
                                ngay_ket_thuc = reader["ngay_ket_thuc"].ToString() != null ? reader["ngay_ket_thuc"].ToString() : "Chưa kết thúc",
                            }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return models;
            }
            _conn.Close();

            return models;
        }

        public bool KiemTraMaMonHocDaTonTai(string ma_mh)
        {
            string query = $"select * from mon_hoc where ma_monhoc ='{ma_mh}';";
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

        public int ThemMonHoc(string ma_mh, string ten_mh, string ma_nghanh, bool trang_thai_thi, DateTime ngay_ket_thuc)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into mon_hoc values (@ma_monhoc,@ten_monhoc,@id_nghanh,@ngay_tao,@trang_thai,@ngay_ket_thuc)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@ma_monhoc", ma_mh);
                cmd.Parameters.AddWithValue("@ten_monhoc", ten_mh);
                cmd.Parameters.AddWithValue("@id_nghanh", ma_nghanh);
                cmd.Parameters.AddWithValue("@ngay_tao", DateTime.Now);
                cmd.Parameters.AddWithValue("@trang_thai", 1);
                cmd.Parameters.AddWithValue("@ngay_ket_thuc", ngay_ket_thuc);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return res;
            }

            return res;
        }

        public int CapNhapMonHocQuaMa(string id_monhoc, string ten_monhoc, string id_nghanh, bool trang_thai_thi, DateTime ngay_ket_thuc)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update mon_hoc set ten_monhoc = @ten_monhoc, id_nghanh = @id_nghanh, trang_thai = @trang_thai_thi, ngay_ket_thuc = @ngay_ket_thuc where ma_monhoc = '{id_monhoc}';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ten_monhoc", ten_monhoc);
                cmd.Parameters.AddWithValue("@id_nghanh", id_nghanh);
                cmd.Parameters.AddWithValue("@trang_thai_thi", trang_thai_thi);
                cmd.Parameters.AddWithValue("@ngay_ket_thuc", ngay_ket_thuc);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int XoaMonHoc(string ma_mh)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from mon_hoc where ma_monhoc = '{ma_mh}';";

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
