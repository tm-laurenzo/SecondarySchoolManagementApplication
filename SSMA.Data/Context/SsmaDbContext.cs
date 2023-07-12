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
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Gaurdian> Gaurdians { get; set; }
        public DbSet<HeadOfDeparment> HeadOfDeparments { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<VicePrincipal> VicePrincipals { get; set; }



    }
}
