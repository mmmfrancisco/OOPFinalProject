using System;
using Microsoft.EntityFrameworkCore;
using Finals_Project_Group5.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;  // Ensure this is included

namespace Finals_Project_Group5.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }  // Ensure this is correct
    }
}
