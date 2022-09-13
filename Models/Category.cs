using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_KIEUTIENANH.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int ProductId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}