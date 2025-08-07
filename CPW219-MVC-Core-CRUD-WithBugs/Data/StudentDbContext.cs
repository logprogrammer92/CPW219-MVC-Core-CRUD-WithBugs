using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CPW219_MVC_Core_CRUD_WithBugs.Models;

namespace CPW219_MVC_Core_CRUD_WithBugs.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<CPW219_MVC_Core_CRUD_WithBugs.Models.Student> Student { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateOnly(2000, 1, 15) },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", DateOfBirth = new DateOnly(2001, 2, 20) },
                new Student { StudentId = 3, FirstName = "Carol", LastName = "Williams", DateOfBirth = new DateOnly(2002, 3, 10) },
                new Student { StudentId = 4, FirstName = "David", LastName = "Brown", DateOfBirth = new DateOnly(2000, 4, 5) },
                new Student { StudentId = 5, FirstName = "Eve", LastName = "Jones", DateOfBirth = new DateOnly(2001, 5, 25) },
                new Student { StudentId = 6, FirstName = "Frank", LastName = "Garcia", DateOfBirth = new DateOnly(2002, 6, 30) },
                new Student { StudentId = 7, FirstName = "Grace", LastName = "Martinez", DateOfBirth = new DateOnly(2000, 7, 12) },
                new Student { StudentId = 8, FirstName = "Hank", LastName = "Rodriguez", DateOfBirth = new DateOnly(2001, 8, 18) },
                new Student { StudentId = 9, FirstName = "Ivy", LastName = "Lee", DateOfBirth = new DateOnly(2002, 9, 22) },
                new Student { StudentId = 10, FirstName = "Jack", LastName = "Walker", DateOfBirth = new DateOnly(2000, 10, 8) },
                new Student { StudentId = 11, FirstName = "Kara", LastName = "Hall", DateOfBirth = new DateOnly(2001, 11, 14) },
                new Student { StudentId = 12, FirstName = "Leo", LastName = "Allen", DateOfBirth = new DateOnly(2002, 12, 19) },
                new Student { StudentId = 13, FirstName = "Mona", LastName = "Young", DateOfBirth = new DateOnly(2000, 1, 3) },
                new Student { StudentId = 14, FirstName = "Nate", LastName = "Hernandez", DateOfBirth = new DateOnly(2001, 2, 9) },
                new Student { StudentId = 15, FirstName = "Olive", LastName = "King", DateOfBirth = new DateOnly(2002, 3, 15) },
                new Student { StudentId = 16, FirstName = "Paul", LastName = "Wright", DateOfBirth = new DateOnly(2000, 4, 21) },
                new Student { StudentId = 17, FirstName = "Quinn", LastName = "Lopez", DateOfBirth = new DateOnly(2001, 5, 27) },
                new Student { StudentId = 18, FirstName = "Rita", LastName = "Hill", DateOfBirth = new DateOnly(2002, 6, 2) },
                new Student { StudentId = 19, FirstName = "Sam", LastName = "Scott", DateOfBirth = new DateOnly(2000, 7, 7) },
                new Student { StudentId = 20, FirstName = "Tina", LastName = "Green", DateOfBirth = new DateOnly(2001, 8, 13) }
            );
        }
    }
}
