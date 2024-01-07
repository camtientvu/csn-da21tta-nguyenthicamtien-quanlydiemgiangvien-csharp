using ProjectManage.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WaterAndPower.Common;
using WaterAndPower.Model;

namespace ProjectManage.Dao
{
    public class DangNhapDao
    {
        private readonly SqlConnection _conn;
        public DangNhapDao(string connection)
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

        public bool KiemTraTaiKhoanDangNhap(string username, string password)
        {
            string query = $"Select * from tai_khoan where tai_khoan ='{username}' and mat_khau = '{password}' and trang_thai = 0";
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
                                UserCommon.id_taikhoan = reader["id"].ToString();
                            }
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
    }
}
