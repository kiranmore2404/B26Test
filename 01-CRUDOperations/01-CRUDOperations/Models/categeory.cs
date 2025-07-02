using System.ComponentModel.DataAnnotations;

namespace _01_CRUDOperations.Models
{
    public class Categeory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Display { get; set; }
    }
}
