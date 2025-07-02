using System.ComponentModel.DataAnnotations;

namespace CrudService.Models
{
    public class Customer
    {
        [Key]
        public int   id { get; set; }
        [ Required]
        [MaxLength(30)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name should only contain letters and spaces.")]


        public string name { get; set; }
        
      [Range(1,100)]




        public int  DisplayOrder { get; set; }
    }
}
