using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_KIEUTIENANH.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "Character is between 3 to 32")]
        public string Name { get; set; }
        public int Price { get; set; }
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 to 100")]
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public virtual Category Category { get; set; }

    }
}