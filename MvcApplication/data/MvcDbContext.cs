using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using MvcApplication.Models;
namespace MvcApplication
{
    public class MvcDbContext : DbContext
    {
        public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
