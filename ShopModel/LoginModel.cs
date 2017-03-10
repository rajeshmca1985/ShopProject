using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopModel
{
    public class LoginModel
    {
        public int Userid { get; set; }
        //public string FullName { get; set; }
        [Required(ErrorMessage = "Username required", AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password Required", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
    }
}
