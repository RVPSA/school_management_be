using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<AllocatedClassroom> allocation_classroom { get; set; }
        public DbSet<AllocatedSubject> allocation_subject { get; set; }
        public DbSet<Classroom> classroom { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<Subject> ssubject { get; set; }
        public DbSet<Teacher> teacher { get; set; }

    }
}
