using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace crowdfunding.Models
{
    public class user_login : Controller
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
