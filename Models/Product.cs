using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiprojeto.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter de 3 a 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage ="Este campo é grande demais")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatorio")]
        [Range(1, int.MaxValue,ErrorMessage ="Este campo deve conter 1 caractere")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Este campo deve conter 1 caractere")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
