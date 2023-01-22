using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework2.Shared;

namespace Coursework2.Shared
{
     public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string UserFirstName { get; set; }
        [Required]
        public string UserLastName { get; set; }
        [Required]
        public string UserEmail { get; set; }

        public string UserMobile { get; set; }

        public Project Project { get; set; }

        public Guid ProjectId { get; set; }
    }
}
