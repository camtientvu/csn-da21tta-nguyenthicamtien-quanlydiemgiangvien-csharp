using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class ThietLapThoiGianThiDao
    {
        private readonly SqlConnection _conn;
        public ThietLapThoiGianThiDao(string connection)
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

        public List<ThoiGianThiModel> KiemTraThoiGianThi(string id_monhoc)
        {
            string query = $"Select * from thoigian_thi where id_monhoc ='{id_monhoc}';";
            List<ThoiGianThiModel> models = new List<ThoiGianThiModel>();
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
                            while (reader.Read())
                            {
                                models.Add(new ThoiGianThiModel
                                {
                                    id = Convert.ToInt32(reader["id"].ToString()),
                                    ma_monhoc = reader["id_monhoc"].ToString(),
                                    id_hocky = reader["id_hocky"].ToString(),
                                    ngay_thi = reader["ngay_thi"].ToString() != null ? reader["ngay_thi"].ToString() : "",
                                }
                                );
                            }
                            return models;
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

        public List<ThoiGianThiModel> LayTatCaThoiGianThiCuaMonHoc(string ma_monhoc = null)
        {
            string query = $"select tgt.id,tgt.id_hocky,mh.id_nghanh,mh.ma_monhoc,mh.ten_monhoc,tgt.ngay_thi,mh.ngay_ket_thuc " +
                $"from thoigian_thi tgt " +
                $"join mon_hoc mh on tgt.id_monhoc = mh.ma_monhoc " +
                $"where 1 = 1";
            bool check = false;
            if (ma_monhoc != null && ma_monhoc != "" && !check)
            {
                query += $" and ma_monhoc like N'%{ma_monhoc}%'";
            }
            List<ThoiGianThiModel> models = new List<ThoiGianThiModel>();
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
                            models.Add(new ThoiGianThiModel
                            {
                                id = Convert.ToInt32(reader["id"].ToString()),
                                id_hocky = reader["id_hocky"].ToString(),
                                ma_monhoc = reader["ma_monhoc"].ToString(),
                                ten_monhoc = reader["ten_monhoc"].ToString(),
                                id_nghanh = reader["id_nghanh"].ToString(),
                                ngay_ket_thuc = reader["ngay_ket_thuc"].ToString() != null ? reader["ngay_ket_thuc"].ToString() : "Chưa kết thúc",
                                ngay_thi = reader["ngay_thi"].ToString() != null ? reader["ngay_thi"].ToString() : "Chưa thi",
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

        public int ThemMoiThoiGianThiCuaMonHoc(string ma_mh, string id_taikhoan, string id_hocky, DateTime ngay_thi)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into thoigian_thi values (@id_taikhoan,@id_monhoc,@id_hocky,@ngay_thi,@trang_thai)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_taikhoan", id_taikhoan);
                cmd.Parameters.AddWithValue("@id_monhoc", ma_mh);
                cmd.Parameters.AddWithValue("@id_hocky", id_hocky);
                cmd.Parameters.AddWithValue("@ngay_thi", ngay_thi);
                cmd.Parameters.AddWithValue("@trang_thai", 1);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return res;
            }

            return res;
        }

        public int UpdateNgayThiCuaMonHoc(int id, DateTime ngay_thi)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update thoigian_thi set ngay_thi = @ngay_thi where id = {id};";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ngay_thi", ngay_thi);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int XoaThoiGianChamThi(int id)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from thoigian_thi where id = {id};";

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

        public int XoaThoiGianThiQuaIdMonHoc(string id_mohoc)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from thoigian_chamthi where id_monhoc = '{id_mohoc}';";

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
