﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTaskManager.Identity
{
    public class ApplicationUser: IdentityUser
    {
        [NotMapped]
        public string Token { get; set; }

        [NotMapped]
        public string Role { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public int CountryID { get; set; }
        public bool ReceiveNewsLetters { get; set; }
    }
}
