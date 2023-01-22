using Coursework2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
    public class TicketsRepository : BaseRepository<Ticket>, ITicketsRepository
    {
        public TicketsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool Any(Guid TicketId)
        {
            return _dbContext.Ticket.Any(t => t.TicketId == TicketId);
        }
    }
}
