using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSMA.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMA.Data.Context
{
    public class SsmaDbContext : IdentityDbContext<AppUser>
    {
        public SsmaDbContext(DbContextOptions<SsmaDbContext> options) : base(options)
        {

        }
        public DbSet<Amenity> Amenities { get; set; }

    }
}
