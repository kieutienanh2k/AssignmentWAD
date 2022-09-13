using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_KIEUTIENANH.Models
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DemoDBContext() : base("name=DemoDbConnect")
        {

        }
    }
}