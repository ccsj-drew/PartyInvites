using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse

    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage ="please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
