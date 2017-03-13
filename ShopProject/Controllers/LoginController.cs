using ShopBL;
using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ShopProject.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       // [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                UserLoginBL userbl = new UserLoginBL();
                var response = userbl.ValidateLogin(model);
                // return response;

            }
            catch (Exception ex)
            {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return View();
        }
    }
}
