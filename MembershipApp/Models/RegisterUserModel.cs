﻿using System.ComponentModel.DataAnnotations;

namespace MembershipApp.Models
{
    public class RegisterUserModel
    {
        [Required, Display(Name = "Name")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {1} characters long", MinimumLength = 2)]
        public string Name { get; set; }

        [Required, EmailAddress, Display(Name = "Email")]
        public string Email { get; set; }

        [Required, StringLength(100), Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public bool AcceptUserAgreement { get; set; }
    }
}