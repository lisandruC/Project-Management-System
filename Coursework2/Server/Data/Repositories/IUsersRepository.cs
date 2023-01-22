using Coursework2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
    public interface IUsersRepository : IBaseRepository<User>
    {
        public bool Any(Guid UserId);

    }
}
