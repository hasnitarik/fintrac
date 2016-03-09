using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace fintrac.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("DefaultConnection")
        { 
        }
          public DbSet<Offer>Offers{get;set;}
          public DbSet<Advisor>Advisors{ get; set; }
    }
}