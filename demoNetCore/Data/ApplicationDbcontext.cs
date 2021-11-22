using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demoNetCore.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<demoNetCore.Models.Demo> Demo { get; set; }

        public DbSet<demoNetCore.Models.Product> Product { get; set; }

        public DbSet<demoNetCore.Models.Person> Person { get; set; }

        public DbSet<demoNetCore.Models.Student> Student { get; set; }

        public DbSet<demoNetCore.Models.Employee> Employee { get; set; }

        public DbSet<demoNetCore.Models.demokethua> demokethua { get; set; }

        public DbSet<demoNetCore.Models.tes1> tes1 { get; set; }

        public DbSet<demoNetCore.Models.tes2> tes2 { get; set; }
    }
