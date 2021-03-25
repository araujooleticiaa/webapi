using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiprojeto.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter de 3 a 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter de 3 a 20 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter de 3 a 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter de 3 a 20 caracteres")]
        public string Passoword { get; set; }

        public string Role { get; set; }    
    }
}
