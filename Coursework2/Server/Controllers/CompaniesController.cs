using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Coursework2.Server.Data;
using Coursework2.Shared;
using Microsoft.AspNetCore.Authorization;
using Coursework2.Server.Data.Repositories;

namespace Coursework2.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ICompaniesRepository _companiesRepository;

        public CompaniesController(ApplicationDbContext context, ICompaniesRepository CompaniesRepository)
        {
            _context = context;
            _companiesRepository = CompaniesRepository;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompany()
        {
            //return await _context.Company.ToListAsync();
            var items = await _companiesRepository.GetAllAsync();
            return items.ToList();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(Guid id)
        {
            //var company = await _context.Company.FindAsync(id);
            var company = await _companiesRepository.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(Guid id, Company company)
        {
            if (id != company.CompanyId)
            {
                return BadRequest();
            }

            //_context.Entry(company).State = EntityState.Modified;
            _companiesRepository.Update(company);

            try
            {
                //await _context.SaveChangesAsync();
                await _companiesRepository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            //_context.Company.Add(company);
            //await _context.SaveChangesAsync();
            _companiesRepository.Add(company);
            await _companiesRepository.SaveChangesAsync();

            return CreatedAtAction("GetCompany", new { id = company.CompanyId }, company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            //var company = await _context.Company.FindAsync(id);
            var company = await _companiesRepository.FindAsync(id);
            
            if (company == null)
            {
                return NotFound();
            }

            //_context.Company.Remove(company);
            //await _context.SaveChangesAsync();
            _companiesRepository.Delete(company);
            await _companiesRepository.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyExists(Guid id)
        {
            //return _context.Company.Any(e => e.CompanyId == id);
            return _companiesRepository.Any(id);
        }
    }
}
