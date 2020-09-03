using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentATool1.Models;

namespace RentATool1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RentATool1.Models.Tool> Tool { get; set; }
        public DbSet<RentATool1.Models.User> User { get; set; }
    }
    public class RentAToolContext : DbContext
    {
        public RentAToolContext(DbContextOptions<RentAToolContext> options)
            : base(options)
        {
        }

        public DbSet<Tool> Tool { get; set; }
        public DbSet<User> User { get; set; }
    }
}
