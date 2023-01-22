using Coursework2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
    public class ProjectsRepository : BaseRepository<Project>, IProjectsRepository
    {
        public ProjectsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool Any(Guid ProjectId)
        {
            return _dbContext.Project.Any(t => t.ProjectId == ProjectId);
        }
    }
}
