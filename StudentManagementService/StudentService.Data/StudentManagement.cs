using Microsoft.EntityFrameworkCore;
using StudentService.Domain;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Data
{
    public class StudentManagement : DbContext
    {
        //public StudentManagement() : base("name=StudentDbContext")
        //{
        //}

        public StudentManagement(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ProgramType> ProgramType { get; set; }
    }
}
