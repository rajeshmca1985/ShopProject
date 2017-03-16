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

        public LoginModel SignupUser(LoginModel usr)
        {
            var p = new DynamicParameters();

            p.Add("MenuType", "AR"); // Augmented Reality files
            p.Add("TargetName", um.targetName);
            p.Add("TargetName_JP", "");
            p.Add("Name", um.name);
            p.Add("Name_JP", um.name_jp);
            p.Add("Type", um.type);
            p.Add("Code", um.code);
            p.Add("ImgUrl", arImagUrl);
            p.Add("UploadUrl", um.uploadUrl);
            p.Add("Description", um.description);
            p.Add("Description_JP", um.description_jp);
            p.Add("PageNo", um.pageNo);
            p.Add("DatUrl", datUrl);
            p.Add("XmlUrl", xmlUrl);

            _db.Execute("sp_MenuListInsert", p, commandType: CommandType.StoredProcedure);

            return um;
            return usr;
        }
    }
}
