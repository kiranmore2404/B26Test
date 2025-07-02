using System.ComponentModel.DataAnnotations; // Add this namespace for Data Annotations

namespace Bulky.Models
{
    public class Details
    {
        // Add the Key attribute to the Id property



        public int Id { get; set; }

            // Make the Name property required
            public required string Name { get; set; }

            public int DisplayOrder { get; set; }
        }
    }



