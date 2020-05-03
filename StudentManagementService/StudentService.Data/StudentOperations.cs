using Microsoft.EntityFrameworkCore;
using StudentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Data
{
    public class StudentOperations : IOperations<Student>
    {
        StudentManagement studentDbContext;

        public StudentOperations(DbContextOptions options)
        {
            studentDbContext = new StudentManagement(options);
        }

        public StudentOperations(StudentManagement context)
        {
            studentDbContext = context;
        }

        public void Create(Student t)
        {
            studentDbContext.Students.Add(t);
            studentDbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            Student stu = Get(id);
            if(stu != null)
            {
                studentDbContext.Students.Remove(stu);
                studentDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Student Get(int id)
        {
            return studentDbContext.Students.Where(x => x.StudentId == id).SingleOrDefault();
        }

        public IEnumerable<Student> GetAll()
        {
            return studentDbContext.Students.ToList();
        }

        public void Update(Student t)
        {
            Student temp = Get(t.StudentId);
            if(temp != null)
            {
                studentDbContext.Entry(temp).CurrentValues.SetValues(t);
                studentDbContext.SaveChanges();
            }
        }
    }
}
