using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentService.Data;
using StudentService.Domain;

namespace StudentManagementApi.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        StudentOperations studentOperations;
       
        public StudentsController(StudentManagement context)
        {
            studentOperations = new StudentOperations(context);
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return studentOperations.Get(id);
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return studentOperations.GetAll();

        }

        [HttpPost]
        public void Post([FromBody]Student student)
        {
            studentOperations.Create(student);           
        }

        [HttpPut]
        public void Put([FromBody]Student student)
        {
            studentOperations.Update(student);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentOperations.Delete(id);
        }
    }
}
