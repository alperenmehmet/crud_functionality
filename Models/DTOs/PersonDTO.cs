using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDOperation_ASP.NET_Web_Application.Models.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please type person name!!!")]
        [MinLength(2, ErrorMessage = "Name length should be at least 2 character!!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please type person last name!!!")]
        [MinLength(2, ErrorMessage = "Last name length should be at least 2 character!!!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please type person birth date!!!")]
        [Range(1900,2021,ErrorMessage ="Please rewrite your age. Age should be between 1900 and 2021")]
        public int BirthDate { get; set; }
    }
}