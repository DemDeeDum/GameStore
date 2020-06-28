using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.WEB.ViewComponents
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Your login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Your password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RemeberMe { get; set; }
    }
}
