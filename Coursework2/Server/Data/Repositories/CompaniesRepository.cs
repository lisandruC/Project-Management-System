using Coursework2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
    public class CompaniesRepository : BaseRepository<Company>, ICompaniesRepository
    {
        public CompaniesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool Any(Guid CompanyId)
        {
            return _dbContext.Company.Any(t => t.CompanyId == CompanyId);
        }
    }
}
