using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentService.Data;
using StudentService.Domain;

namespace StudentManagementApi.Controllers
{
    [Produces("application/json")]
    [Route("api/ProgramTypes")]
    public class ProgramTypesController : Controller
    {

        ProgramTypeOperations ProgramOperations;

        public ProgramTypesController(StudentManagement context)
        {
            ProgramOperations = new ProgramTypeOperations(context);
        }

        [HttpGet("{id}")]
        public ProgramType Get(int id)
        {
            return ProgramOperations.Get(id);
        }

        [HttpGet]
        public IEnumerable<ProgramType> Get()
        {
            return ProgramOperations.GetAll();
        }

        [HttpPost]
        public void Post([FromBody]ProgramType programType)
        {
            ProgramOperations.Create(programType);
        }

        [HttpPut]
        public void Put([FromBody]ProgramType programType)
        {
            ProgramOperations.Update(programType);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProgramOperations.Delete(id);
        }
    }
    //    private readonly StudentManagement _context;

    //    public ProgramTypesController(StudentManagement context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/ProgramTypes
    //    [HttpGet]
    //    public IEnumerable<ProgramType> GetProgramType()
    //    {
    //        return _context.ProgramType;
    //    }

    //    // GET: api/ProgramTypes/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetProgramType([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var programType = await _context.ProgramType.SingleOrDefaultAsync(m => m.ProgramTypeId == id);

    //        if (programType == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(programType);
    //    }

    //    // PUT: api/ProgramTypes/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutProgramType([FromRoute] int id, [FromBody] ProgramType programType)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != programType.ProgramTypeId)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(programType).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!ProgramTypeExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/ProgramTypes
    //    [HttpPost]
    //    public async Task<IActionResult> PostProgramType([FromBody] ProgramType programType)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.ProgramType.Add(programType);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetProgramType", new { id = programType.ProgramTypeId }, programType);
    //    }

    //    // DELETE: api/ProgramTypes/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteProgramType([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var programType = await _context.ProgramType.SingleOrDefaultAsync(m => m.ProgramTypeId == id);
    //        if (programType == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.ProgramType.Remove(programType);
    //        await _context.SaveChangesAsync();

    //        return Ok(programType);
    //    }

    //    private bool ProgramTypeExists(int id)
    //    {
    //        return _context.ProgramType.Any(e => e.ProgramTypeId == id);
    //    }

}