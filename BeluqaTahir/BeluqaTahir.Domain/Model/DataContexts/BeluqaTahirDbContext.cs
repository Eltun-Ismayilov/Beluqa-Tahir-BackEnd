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


    }
}
