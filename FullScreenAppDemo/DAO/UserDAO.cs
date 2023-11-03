using FullScreenAppDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.DAO
{
    internal class UserDAO
    {

        public DataTable GetALlUser()
        {
            string sql = "select * from users";
            DataTable dt = DBConnection.Instance.ExecuteQuery(sql);
            return dt;
        }
    }
}
