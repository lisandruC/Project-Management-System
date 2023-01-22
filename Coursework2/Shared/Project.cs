using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework2.Shared
{
     public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }
        
        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public Company Company { get; set; }

        public Guid CompanyId { get; set; }
    }
}
