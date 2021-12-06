using BeluqaTahir.Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeluqaTahir.Domain.Model.DataContexts
{
   public class BeluqaTahirDbContext:DbContext
    {
        public BeluqaTahirDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Contact> contacts { get; set; }
        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<ProductTypes> productTypes { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<HappyClients> happyClients { get; set; }
        public DbSet<AuditLog> auditLogs { get; set; }
        public DbSet<Accountdetails> accountdetails { get; set; }
        

    }
}
