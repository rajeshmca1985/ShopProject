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
        public UserLoginDetails ValidateLogin(LoginModel obj)
        {
            UserLoginDetails usd = null;
            try
            {
                // UserLoginDetails loginDetails=  loginDAO.ValidateLogin(obj);     
                usd = loginDAO.ValidateLogin(obj);

                //byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                //byte[] key = Guid.NewGuid().ToByteArray();
                //string token = Convert.ToBase64String(time.Concat(key).ToArray());
                //usd.apitoken = token;

                ////throw new ApplicationException("The User could not be found");


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usd;
        }
    }
}
