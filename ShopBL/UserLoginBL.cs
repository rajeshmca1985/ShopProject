using ShopDAO;
using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBL
{
    public class UserLoginBL
    {
        UserLoginDAO loginDAO = new UserLoginDAO();
        public LoginModel ValidateLogin(LoginModel obj)
        {
            LoginModel usd = null;
            try
            {
                usd = loginDAO.ValidateLogin(obj.Username, obj.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usd;
        }

        public LoginModel SignupUser(LoginModel obj)
        {
            LoginModel usd = null;
            try
            {
                usd = loginDAO.SignupUser(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usd;
        }
    }
}
