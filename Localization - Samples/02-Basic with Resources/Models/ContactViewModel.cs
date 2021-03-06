﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Localization.Models
{
    public class ContactViewModel
    {
        [Required]
        [MaxLength(20)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Url]
        [Display(Name = "Web site")]
        public string WebUri { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [MaxLength(2000)]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
