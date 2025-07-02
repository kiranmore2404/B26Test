using System.ComponentModel.DataAnnotations;

namespace BulkyWebApplication.Models
{
    public class Category
    {
        [Key]
        public int Catagory21Id{ get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
   
}
