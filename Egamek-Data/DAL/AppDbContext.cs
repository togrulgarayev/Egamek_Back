using System;
using System.Collections.Generic;
using System.Text;
using Egamek_Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Egamek_Data.DAL
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.ApplyConfiguration(new CategoryConfiguration());




            base.OnModelCreating(builder);

        }


        //public DbSet<Category> Categories { get; set; }

    }
}
