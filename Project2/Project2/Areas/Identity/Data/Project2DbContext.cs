using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project2.Areas.Identity.Data;
using Project2.Models;

namespace Project2.Data
{
    public class Project2DbContext : IdentityDbContext<ApplicationUser>
    {
        public Project2DbContext(DbContextOptions<Project2DbContext> options)
            : base(options)
        {

        }
        public DbSet<ImageModel> Image { get; set; }
        public object ImageModel { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
