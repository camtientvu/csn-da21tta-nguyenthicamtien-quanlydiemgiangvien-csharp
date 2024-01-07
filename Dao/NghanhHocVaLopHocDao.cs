using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using WaterAndPower.Model;

namespace WaterAndPower.Dao
{
    public class NghanhHocVaLopHocDao
    {
        private readonly SqlConnection _conn;
        public NghanhHocVaLopHocDao(string connection)
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

        public List<NghanhHocModel> LayTatCaNghanhHoc()
        {
            string query = $"select * from nghanh;";

            List<NghanhHocModel> results = new List<NghanhHocModel>();
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
                            results.Add(new NghanhHocModel
                            {
                                ma_nghanh = reader["ma_nghanh"].ToString(),
                                ten_nghanh = reader["ten_nghanh"].ToString(),
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

        public List<LopHocModel> LayTatCaLopHoc()
        {
            string query = $"select * from lop;";

            List<LopHocModel> results = new List<LopHocModel>();
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
                            results.Add(new LopHocModel
                            {
                                ma_lop = reader["ma_lop"].ToString(),
                                ten_lop = reader["ten_lop"].ToString(),
                                id_nghanh = reader["id_nghanh"].ToString()
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
