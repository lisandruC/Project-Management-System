using Coursework2.Server.Models;
using Coursework2.Shared;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Coursework2.Shared.User> User { get; set; }
        public DbSet<Coursework2.Shared.Ticket> Ticket { get; set; }
        public ApplicationDbContext( DbContextOptions options,  IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        
    }
}
