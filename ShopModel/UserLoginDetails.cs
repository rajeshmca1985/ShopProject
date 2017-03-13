using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class UserLoginDetails
    {
        public int shopid { get; set; }
        public int userid { get; set; }
        public string apitoken { get; set; }
        public Boolean isadmin { get; set; }
    }
}
