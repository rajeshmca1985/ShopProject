using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAO
{
    public class UserLoginDAO
    {
        public UserLoginDetails ValidateLogin(LoginModel objlogin)
        {
            UserLoginDetails loginDetails = new UserLoginDetails();
            //using (NpgsqlConnection con = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Axiom_MobileConnection"].ToString()))
            //{
            //    con.Open();
            //    NpgsqlDataReader reader = null;
            //    string fn_userlogin = "fn_userlogin";
            //    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(fn_userlogin, con))
            //    {
            //        using (NpgsqlTransaction tran = con.BeginTransaction())
            //        {
            //            pgsqlcommand.CommandType = CommandType.StoredProcedure;

            //            pgsqlcommand.Parameters.Add(new NpgsqlParameter("p_username", NpgsqlDbType.Varchar));
            //            pgsqlcommand.Parameters.Add(new NpgsqlParameter("p_password", NpgsqlDbType.Varchar));

            //            pgsqlcommand.Parameters.Add(new NpgsqlParameter("ref", NpgsqlDbType.Refcursor));

            //            pgsqlcommand.Parameters[0].Value = objlogin.username;
            //            pgsqlcommand.Parameters[1].Value = objlogin.password;
            //            pgsqlcommand.Parameters[2].Value = "ref";

            //            pgsqlcommand.ExecuteNonQuery();

            //            pgsqlcommand.CommandText = "fetch all in \"ref\"";
            //            pgsqlcommand.CommandType = CommandType.Text;

            //            reader = pgsqlcommand.ExecuteReader();

            //            while (reader.Read())
            //            {
            //                loginDetails.userid = Convert.ToInt32(reader.GetValue(0));
            //                loginDetails.companyid = Convert.ToInt32(reader.GetValue(1));
            //                loginDetails.url = reader.GetValue(2).ToString();
            //                loginDetails.apitoken = reader.GetValue(3).ToString();
            //                loginDetails.isadmin = Convert.ToBoolean(reader.GetValue(4));
            //            }
            //            reader.Close();

            //            tran.Commit();
            //            con.Close();
            //        }
            //    }
            //}
            loginDetails.shopid = 1;
            loginDetails.userid = 456;
            loginDetails.isadmin = true;
            return loginDetails;     
        }
    }
}
