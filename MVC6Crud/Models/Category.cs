using System.ComponentModel.DataAnnotations;

namespace MVC6Crud.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        [Required]
        [Display(Name ="Category Nombre")]
        public string? CategoryNombre { get; set; }
    }
}
