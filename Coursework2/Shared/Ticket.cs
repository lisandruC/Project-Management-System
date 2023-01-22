using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework2.Shared
{
    public class Ticket
    {
        [Key]
        public Guid TicketId { get; set; }
        [Required]
        public string TicketName { get; set; }

        public DateTime TicketEndDate { get; set; }

        public Boolean TicketStatus { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}
