using Microsoft.AspNetCore.Identity;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GameStore.DAL.Entities
{
    public class User : IdentityUser
    { 
        public string Login { get; set; }
    }
}
