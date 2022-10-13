using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flags4us_assignment1.Models
{
    public class Flags
    {
        public int Id { get; set; }

           
        
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }


        
        //   [Required]

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        
        public DateTime ReleaseDate { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        [StringLength(3)]
        public string Edible {get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(30)]
        [Required]
        public string Review { get; set; } 

       [StringLength(50)]
        public string Color { get; set; }

      //  [Range(1, 20)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}










/* namespace Flags4us_assignment1.Models
{
    public class Flags
    {
    }
} */
