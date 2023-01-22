using Coursework2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
    public class UsersRepository : BaseRepository<User>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool Any(Guid UserId)
        {
            return _dbContext.User.Any(t => t.UserId == UserId);
        }
    }
}
