using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<Quote> Quotes { get; set; }
        DbSet<Sale> Sales { get; set; }
        DbSet<Comment> Comments { get; set; }

    }
}
