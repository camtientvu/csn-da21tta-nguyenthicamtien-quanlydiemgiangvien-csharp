using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class QuyenHeThongDao
    {
        private readonly SqlConnection _conn;
        public QuyenHeThongDao(string connection)
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

        public bool KiemTraQuyenCuaTaiKhoan(string id_quyen, string id_taikhoan)
        {
            string query = $"select * from quyen_hethong where id_quyen ='{id_quyen}' and id_taikhoan = '{id_taikhoan}';";
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

        public List<QuyenHeThongModel> LayTatCaQuyenTheoMaCode(string code = null)
        {
            string query = $"select * from quyen ";
            if (code != null && code != "")
            {
                query += $"where code like '%{code}%'";
            }

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public List<QuyenHeThongModel> LayTatCaQuyenMonHoc()
        {
            string query = $"select * from quyen where code not like '%SYS%' ";

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public List<QuyenHeThongModel> LayTatCaQuyenHeThong()
        {
            string query = $"select * from quyen where code like '%SYS%' ";

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public List<QuyenHeThongModel> LayTatCaQuyenMonhocTheoIdTaiKhoanVaIdMonhoc(string id_taikhoan, string id_monhoc)
        {
            string query = $"select q.id, q.code, q.ten_quyen from quyen_monhoc qtk join quyen q on qtk.id_quyen = q.id where code not like '%SYS%'";
            if (id_taikhoan != null && id_taikhoan != "")
            {
                query += $" and qtk.id_taikhoan = '{id_taikhoan}' and qtk.id_monhoc = '{id_monhoc}'";
            }

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public List<QuyenHeThongModel> LayTatCaQuyenMonHocTheoIdTaiKhoan(string id_taikhoan)
        {
            string query = $"select q.id,q.code, q.ten_quyen from quyen_monhoc qtk join quyen q on qtk.id_quyen = q.id where 1 = 1";
            if (id_taikhoan != null && id_taikhoan != "")
            {
                query += $" and id_taikhoan = '{id_taikhoan}'";
            }

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public List<QuyenHeThongModel> LayTatCaQuyenHeThongTheoIdTaiKhoan(string id_taikhoan)
        {
            string query = $"select q.id,q.code, q.ten_quyen from quyen_hethong qtk join quyen q on qtk.id_quyen = q.id where 1 = 1";
            if (id_taikhoan != null && id_taikhoan != "")
            {
                query += $" and id_taikhoan = '{id_taikhoan}'";
            }

            List<QuyenHeThongModel> results = new List<QuyenHeThongModel>();
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
                            results.Add(new QuyenHeThongModel
                            {
                                id = reader["id"].ToString(),
                                code = reader["code"].ToString(),
                                ten_quyen = reader["ten_quyen"].ToString(),
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

        public int GanQuyenChoTaiKhoan(string id_taikhoan, string id_quyen)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Insert into quyen_hethong values (@id_quyen,@id_taikhoan);";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_taikhoan", id_taikhoan);
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

        public int XoaQuyenCuaTaiKhoan(string id_quyen, string id_taikhoan)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from quyen_hethong where id_quyen = '{id_quyen}' and id_taikhoan = '{id_taikhoan}';";

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

        public int XoaQuyenCuaTaiKhoanTheoIdTaiKhoan( string id_taikhoan)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from quyen_taikhoan where id_taikhoan = '{id_taikhoan}';";

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
