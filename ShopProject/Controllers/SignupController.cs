using ShopBL;
using ShopModel;
using System;
using System.Collections.Generic;
using System.IO;
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
                string arImagePath = string.Empty, arUploadDir = string.Empty, arImageUrl = string.Empty;
                //FileInfo[] dat, xml;
                arUploadDir = @"~/Uploads/ARImages";
                bool arUploadDirexists = System.IO.Directory.Exists(Server.MapPath(arUploadDir));
                try
                {

                    if (arUploadDirexists)
                        System.IO.Directory.CreateDirectory(Server.MapPath(arUploadDir));
                    if (model.uploadFile[0] != null && model.uploadFile[0].ContentLength > 0)
                    {
                        arImagePath = Path.Combine(Server.MapPath(arUploadDir), (model.uploadFile[0]).FileName);
                        arImageUrl = Path.Combine(arUploadDir, (model.uploadFile[0]).FileName);
                        (model.uploadFile[0]).SaveAs(arImagePath);
                    }

                }
                catch (Exception ex)
                {
                }
                arImageUrl = arImageUrl.Replace(@"\", "/");
                model.uploadFilepath = arImageUrl;
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
      
        
    


    

