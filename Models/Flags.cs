using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flags4us_assignment1.Models
{
    public class Flags
    {
        public int Id { get; set; }

        //   [Display(Name = "Product Name")]
        //   [StringLength(60, MinimumLength = 3)]
        //  [Required]
        public string ProductName { get; set; }


        //   [Display(Name = "Product Description ")]
        //   [Required]

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //  [StringLength(30)]
        public string Size { get; set; }

        public string Edible {get; set;}

        public string Review { get; set; } 

       // [StringLength(30)]
        public string Color { get; set; }

      //  [Range(1, 20)]
       // [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}










/* namespace Flags4us_assignment1.Models
{
    public class Flags
    {
    }
} */
