using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud1
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Kullanici { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;database=Crud_Kullanici;uid=sa;pwd=123");
        }

    }
}