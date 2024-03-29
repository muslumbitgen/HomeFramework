﻿using HomeFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Entities.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
