using ShopBL;
using ShopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopProject.Controllers
{
    public class SignupController : Controller
    {
        //
        // GET: /Signup/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(LoginModel model)
        {
            UserLoginBL loginbl = new UserLoginBL();
            try
            {
                LoginModel user = loginbl.SignupUser(model);
                if (user != null)
                {
                    if (model.Username == user.Username && model.Password == user.Password)
                        return RedirectToAction("Login", "Login");
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
