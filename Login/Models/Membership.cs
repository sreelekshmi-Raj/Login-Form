﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}