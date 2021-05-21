using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class UsersModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Completar este campo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Completar este campo")]
        public string Name { get; set; }

        [Display(Name ="Contraseña")]
        [Required(ErrorMessage ="Completar este campo")]
        [StringLength(100,ErrorMessage ="la {0} debe tener al menos {2} caracteres",MinimumLength =2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterTime { get; set; }
    }
}
