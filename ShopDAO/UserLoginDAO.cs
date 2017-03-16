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
            var obj = _db.Query<LoginModel>("select Username,Password from Login where Username ='" + username + "' and Password = '" + password + "'").FirstOrDefault();
            return obj;
        }

        public LoginModel SignupUser(LoginModel usr)
        {
            var p = new DynamicParameters();

          //  p.Add("MenuType", "AR"); // Augmented Reality files
            p.Add("username", usr.Username);
            p.Add("firstname", usr.firstname);
            p.Add("lastname", usr.lastname);
            p.Add("password", usr.Password);
            _db.Execute("sp_Add_UserRegistration", p, commandType: CommandType.StoredProcedure);
            return usr;
        }
    }
}
