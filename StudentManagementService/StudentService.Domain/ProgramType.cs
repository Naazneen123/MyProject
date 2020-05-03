using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Domain
{
    public class ProgramType
    {
        public int ProgramTypeId { get; set; }
        public string ProgramTypeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
