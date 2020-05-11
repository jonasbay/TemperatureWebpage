using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureWebpage.Models
{
    public class ApplicationUser
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(254)]
        public string Email { get; set; }
        [MaxLength(64)]
        public string UserName { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
        [MaxLength(60)]
        public string PasswordHash { get; set; }
    }
}
