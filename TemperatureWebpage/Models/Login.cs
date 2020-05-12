﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureWebpage.Models
{
    public class Login
    {
        [Required, MaxLength(254)]
        public string Email { get; set; }
        [Required, MaxLength(56)]
        public string Password { get; set; }
    }
}
