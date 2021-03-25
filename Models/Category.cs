using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiprojeto.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        public string Title { get; set; }

    }
}
