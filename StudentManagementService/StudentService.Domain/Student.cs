using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        [ForeignKey("ProgramType")]
        public int ProgramTypeId { get; set; }
        public ProgramType ProgramType { get; set; }

    }
}
