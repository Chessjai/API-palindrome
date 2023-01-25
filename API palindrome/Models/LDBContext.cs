using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_palindrome.Models
{
    public class LDBContext : DbContext
    {
        public LDBContext() : base("MyConnectionString")
        {
            Database.SetInitializer<LDBContext>(null);
        }

        public DbSet<DBclass> LModels { get; set; }
    }

}