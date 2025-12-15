using HW22.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Dtos.User
{
    public class RegisterUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
    }
}
