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
        //[Required(ErrorMessage = "Username required", AllowEmptyStrings = false)]
        public string Username { get; set; }
        //[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        public string apitoken { get; set; }
        public Boolean isadmin { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
      
    }
}
