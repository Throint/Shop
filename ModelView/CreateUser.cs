using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestEFC.ModelView
{
    public class CreateUser
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string PassFirst { get; set; }
        [Required]
        [Compare(nameof(PassFirst), ErrorMessage ="Passwords do not match")]
        public string PassConfirm { get; set; }
      //  public decimal SalaryUser { get; set; }
    }

 
}
