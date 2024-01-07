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
    public class HocKyDao
    {
        readonly SqlConnection _conn;
        public HocKyDao(string connection)
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

        public List<HocKyModel> LayTatCaHocKy(string ma_nghanh = null, string ten_monhoc = null)
        {
            string query = $"select * from hoc_ky; ";
            List<HocKyModel> models = new List<HocKyModel>();
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
                            models.Add(new HocKyModel
                            {
                                ma_hocky = reader["ma_hocky"].ToString(),
                                ten_hocky = reader["ten_hocky"].ToString()    
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

        public int ThemMonHocHocKy(string ma_mh, string id_hocky)
        {
            int res = 0;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "insert into monhoc_hocky values (@ma_mh,@id_hocky)";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@ma_mh", ma_mh);
                cmd.Parameters.AddWithValue("@id_hocky", id_hocky);

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
