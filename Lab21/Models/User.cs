using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace Lab21.Models
{
    public class User
    {

        [Key]
        [Required]
        [MaxLength (20)]
        [RegularExpression("^[a-zA-Z ]*$")]  //only allows letters, from SO
        public string UserName { get; set; }



        public string Email { get; set; }

        [MinLength(8)]
        [MaxLength(20)]
        [Required]
        public string Password { get; set; }
    }
}
