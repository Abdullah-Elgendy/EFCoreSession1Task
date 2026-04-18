using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EFCoreSession1Task.Model;

namespace EFCoreSession1Task.Context
{
    internal class LibraryAppContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=EF01G01; Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}
