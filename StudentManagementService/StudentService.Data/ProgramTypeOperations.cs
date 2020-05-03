using Microsoft.EntityFrameworkCore;
using StudentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Data
{
    public class ProgramTypeOperations : IOperations<ProgramType>
    {
        StudentManagement programTypeDbContext;

        public ProgramTypeOperations(DbContextOptions options)
        {
            programTypeDbContext = new StudentManagement(options);
        }

        public ProgramTypeOperations(StudentManagement context)
        {
            programTypeDbContext = context;
        }

        public void Create(ProgramType t)
        {
            programTypeDbContext.ProgramType.Add(t);
            programTypeDbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            ProgramType prg = Get(id);
            if (prg != null)
            {
                programTypeDbContext.ProgramType.Remove(prg);
                programTypeDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public ProgramType Get(int id)
        {
            return programTypeDbContext.ProgramType.Where(x => x.ProgramTypeId == id).SingleOrDefault();
        }

        public IEnumerable<ProgramType> GetAll()
        {
            return programTypeDbContext.ProgramType.ToList();
        }

        public void Update(ProgramType t)
        {
            ProgramType temp = Get(t.ProgramTypeId);
            if (temp != null)
            {
                programTypeDbContext.Entry(temp).CurrentValues.SetValues(t);
                programTypeDbContext.SaveChanges();
            }
        }
    }
}
