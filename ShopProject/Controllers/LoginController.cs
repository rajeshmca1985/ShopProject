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
        public ActionResult Login()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            UserLoginBL loginbl = new UserLoginBL();
            try
            {

                LoginModel user = loginbl.ValidateLogin(model);
                if (user != null)
                {
                    if (model.Username == user.Username && model.Password == user.Password)
                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ViewBag.Message = "Invalid login!";
                    ViewBag.Error = "Credentials invalid. Please try again.";
                }
            }
            catch (Exception ex)
            {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return View();
        }
    }
}
