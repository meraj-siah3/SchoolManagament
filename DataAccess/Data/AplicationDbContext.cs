using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Security.Claims;
using Models.Model;




namespace DataAccess.Data
{
  public  class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> Options) : base(Options) 
        {
            
        }
        public DbSet<Student> Teachers { get; set; }
        public DbSet<Classroom> Classes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbContextOptions<AplicationDbContext> Options { get; }
    }
}


