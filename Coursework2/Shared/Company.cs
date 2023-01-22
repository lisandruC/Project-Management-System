using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework2.Shared
{
     public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }

        [Required]
        public string Name { get; set; }
   
        public string Description { get; set; }
    }
}
