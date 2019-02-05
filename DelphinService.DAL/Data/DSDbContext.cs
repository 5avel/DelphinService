using DelphinService.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelphinService.DAL.Data
{
    public class DSDbContext : IdentityDbContext<AppUser>
    {
        public DSDbContext(DbContextOptions<DSDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
