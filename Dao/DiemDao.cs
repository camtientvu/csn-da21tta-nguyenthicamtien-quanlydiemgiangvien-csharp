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
    public class DiemDao
    {
        private readonly SqlConnection _conn;
        /// <summary>
        /// Mở kết nối
        /// </summary>
        /// <param name="connection"></param>
        public DiemDao(string connection)
        {
            _conn = new SqlConnection(connection);
        }

        /// <summary>
        /// Giải phóng
        /// </summary>
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

        public int XoaDiemQuaMaMonHoc(string id_mohoc)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from diem where id_monhoc = '{id_mohoc}';";

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

        public int XoaDiemQuaMaSvVaMaMonHoc(string ma_sv, string ma_mh)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from diem where id_sv = '{ma_sv}' and id_monhoc = '{ma_mh}';";

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

        public int XoaDiemQuaMaSv(string ma_sv)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from diem where id_sv = '{ma_sv}';";

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

        public int CapNhapDiemSinhVien(int id, string ma_sv, string id_mh, double diem_qt1, double diem_qt2, double diem_thi1, double diem_thi2)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update diem set DiemQT1 = @diem_qt1, DiemQT2 = @diem_qt2, DiemThilan1 = @diem_thi1, DiemThilan2 = @diem_thi2" +
                    $" where id = {id} and id_sv = '{ma_sv}' and id_monhoc = '{id_mh}';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@diem_qt1", diem_qt1);
                cmd.Parameters.AddWithValue("@diem_qt2", diem_qt2);
                cmd.Parameters.AddWithValue("@diem_thi1", diem_thi1);
                cmd.Parameters.AddWithValue("@diem_thi2", diem_thi2);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int ThemDiemMonHoc(string ma_sv, string id_monhoc, double DiemQT1, double DiemQT2, double DiemThilan1, double DiemThilan2)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into diem values (@id_sv,@id_monhoc,@DiemQT1,@DiemQT2,@DiemThilan1,@DiemThilan2,@ngay_tao,@trang_thai)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_sv", ma_sv);
                cmd.Parameters.AddWithValue("@id_monhoc", id_monhoc);
                cmd.Parameters.AddWithValue("@DiemQT1", DiemQT1);
                cmd.Parameters.AddWithValue("@DiemQT2", DiemQT2);
                cmd.Parameters.AddWithValue("@DiemThilan1", DiemThilan1);
                cmd.Parameters.AddWithValue("@DiemThilan2", DiemThilan2);
                cmd.Parameters.AddWithValue("@ngay_tao", DateTime.Now);
                cmd.Parameters.AddWithValue("@trang_thai", false);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return res;
            }

            return res;
        }

        public List<DiemMonHocSinhVienModel> LayDiemMonHocTheoMaSinhVien(string ma_sv)
        {
            string query = $"select d.id, s.id_nghanh, s.id_lop, s.ma_sv,s.ten_sv, mh.ma_monhoc, mh.ten_monhoc, d.DiemQT1,d.DiemQT2,d.DiemThilan1, d.DiemThilan2, mh.ngay_ket_thuc from sinh_vien s "
                + " join diem d on s.ma_sv = d.id_sv"
                + " join mon_hoc mh on d.id_monhoc = mh.ma_monhoc";
            if (ma_sv != null && ma_sv != "")
            {
                query += $" where s.ma_sv = '{ma_sv}'";
            }

            List<DiemMonHocSinhVienModel> results = new List<DiemMonHocSinhVienModel>();
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
                            results.Add(new DiemMonHocSinhVienModel
                            {
                                id = Convert.ToInt32(reader["id"].ToString()),
                                id_nghanh = reader["id_nghanh"].ToString(),
                                id_lop = reader["id_lop"].ToString(),
                                ma_sv = reader["ma_sv"].ToString(),
                                ten_sv = reader["ten_sv"].ToString(),
                                ma_monhoc = reader["ma_monhoc"].ToString(),
                                ten_monhoc = reader["ten_monhoc"].ToString(),
                                DiemQT1 = reader["DiemQT1"].ToString(),
                                DiemQT2 = reader["DiemQT2"].ToString(),
                                DiemThilan1 = reader["DiemThilan1"].ToString(),
                                DiemThilan2 = reader["DiemThilan2"].ToString(),
                                ngay_ket_thuc = reader["ngay_ket_thuc"].ToString(),
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
    }
}
