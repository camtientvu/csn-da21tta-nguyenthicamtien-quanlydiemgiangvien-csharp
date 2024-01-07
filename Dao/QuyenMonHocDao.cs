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
    public class QuyenMonHocDao
    {
        private readonly SqlConnection _conn;
        public QuyenMonHocDao(string connection)
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

        public bool KiemTraQuyenCuaTaiKhoan(string id_taikhoan, string id_monhoc)
        {
            string query = $"select * from quyen_monhoc where id_taikhoan = '{id_taikhoan}' and id_monhoc = '{id_monhoc}';";
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

        public bool KiemTraQuyenCuaTaiKhoanTheoIdTaiKhoanVaIdQuyen(string id_taikhoan, string id_quyen)
        {
            string query = $"select * from quyen_monhoc where id_taikhoan = '{id_taikhoan}' and id_quyen = '{id_quyen}';";
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

        public string LayTatCaQuyenTheoMaCode(string code = null)
        {
            string query = $"select id from quyen ";
            if (code != null && code != "")
            {
                query += $"where code like '%{code}%'";
            }

            string result = "";
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
                            result = reader["id"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result;
            }
            _conn.Close();

            return result;
        }

        public int GanQuyenMonHocChoTaiKhoan(string id_quyen,string id_monhoc, string id_taikhoan)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Insert into quyen_monhoc values (@id_quyen,@id_monhoc,@id_taikhoan);";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_taikhoan", id_taikhoan);
                cmd.Parameters.AddWithValue("@id_monhoc", id_monhoc);
                cmd.Parameters.AddWithValue("@id_quyen", id_quyen);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int XoaQuyenCuaMonHocTheoIdTaiKhoan(string id_taikhoan, string id_monhoc)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from quyen_monhoc where id_taikhoan = '{id_taikhoan}' and id_monhoc = '{id_monhoc}';";

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

        public int XoaQuyenCuaMonHocTheoIdTaiKhoanVaIdQuyen(string id_taikhoan, string id_quyen)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from quyen_monhoc where id_taikhoan = '{id_taikhoan}' and id_quyen = '{id_quyen}';";

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
