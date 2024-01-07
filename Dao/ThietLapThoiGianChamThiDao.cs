using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class ThietLapThoiGianChamThiDao
    {
        private readonly SqlConnection _conn;
        public ThietLapThoiGianChamThiDao(string connection)
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

        public List<ThoiGianChamThiModel> KiemTraThoiGianChamThi(string id_monhoc)
        {
            string query = $"Select * from thoigian_chamthi where id_monhoc ='{id_monhoc}';";
            List<ThoiGianChamThiModel> models = new List<ThoiGianChamThiModel>();
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
                                models.Add(new ThoiGianChamThiModel
                                {
                                    id = Convert.ToInt32(reader["id"].ToString()),
                                    ma_monhoc = reader["id_monhoc"].ToString(),
                                    id_hocky = reader["id_hocky"].ToString(),
                                    ngay_cham = reader["ngay_cham"].ToString() != null ? reader["ngay_cham"].ToString() : "",
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

        public List<ThoiGianChamThiModel> LayTatCaThoiGianChamThiCuaMonHoc(string ten_monhoc = null)
        {
            string query = $"select tgt.id,tgt.id_hocky,mh.id_nghanh,mh.ma_monhoc,mh.ten_monhoc,tgt.ngay_cham,mh.ngay_ket_thuc " +
                $"from thoigian_chamthi tgt " +
                $"join mon_hoc mh on tgt.id_monhoc = mh.ma_monhoc " +
                $"where 1 = 1";
            bool check = false;
            if (ten_monhoc != null && ten_monhoc != "" && !check)
            {
                query += $" and ten_monhoc like N'%{ten_monhoc}%'";
            }
            List<ThoiGianChamThiModel> models = new List<ThoiGianChamThiModel>();
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
                            models.Add(new ThoiGianChamThiModel
                            {
                                id = Convert.ToInt32(reader["id"].ToString()),
                                id_hocky = reader["id_hocky"].ToString(),
                                ma_monhoc = reader["ma_monhoc"].ToString(),
                                ten_monhoc = reader["ten_monhoc"].ToString(),
                                id_nghanh = reader["id_nghanh"].ToString(),
                                ngay_ket_thuc = reader["ngay_ket_thuc"].ToString() != null ? reader["ngay_ket_thuc"].ToString() : "Chưa kết thúc",
                                ngay_cham = reader["ngay_cham"].ToString() != null ? reader["ngay_cham"].ToString() : "Chưa thi",
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

        public int ThemMoiThoiGianChamThi(string ma_mh, string id_taikhoan, string id_hocky, DateTime ngay_cham)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into thoigian_chamthi values (@id_taikhoan,@id_monhoc,@id_hocky,@ngay_cham,@trang_thai)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_taikhoan", id_taikhoan);
                cmd.Parameters.AddWithValue("@id_monhoc", ma_mh);
                cmd.Parameters.AddWithValue("@id_hocky", id_hocky);
                cmd.Parameters.AddWithValue("@ngay_cham", ngay_cham);
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

        public int CapNhapThoiGianChamThi(int id, DateTime ngay_cham)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Update thoigian_chamthi set ngay_cham = @ngay_cham where id = {id};";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ngay_cham", ngay_cham);

                cmd.ExecuteNonQuery();

                res = 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

            return res;
        }

        public int XoaThoiGianChamThiQuaIdMonHoc(string id_mohoc)
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

        public int XoaThoiGianChamThiQuaId(int id)
        {
            int res = 0;
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = $"Delete from thoigian_chamthi where id = {id};";

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
