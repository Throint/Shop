using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestEFC.ModelView
{
    public class OrderCreateModel
    {
        [Required(ErrorMessage ="Enter name")]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Enter your email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Enter your phone number")]
        [Phone]
        public string PhoneNubmer { get; set; }
        
        public string Address { get; set; }
        [Required]
        public string PaymentType { get; set; }
        public string Status { get; set; }


    }
}
