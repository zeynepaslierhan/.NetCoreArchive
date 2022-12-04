using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginController.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
    }
}
