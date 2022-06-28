using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Sailor.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(maximumLength: 15)]
        public string Firstname { get; set; }
        [StringLength(maximumLength: 20)]
        public string Lastname { get; set; }
    }
}
