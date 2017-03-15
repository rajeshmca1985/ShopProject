using ShopModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ShopDAO
{
    public class UserLoginDAO
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopConnnection"].ConnectionString);
        public LoginModel ValidateLogin(string username, string password)
        {
            var obj = _db.Query<LoginModel>("select User_name as Username,Password from Login where User_name ='" + username + "' and Password = '" + password + "'").FirstOrDefault();
            return obj;
        }
    }
}
