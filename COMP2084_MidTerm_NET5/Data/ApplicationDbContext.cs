using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using COMP2084_MidTerm_NET5.Models;

namespace COMP2084_MidTerm_NET5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<COMP2084_MidTerm_NET5.Models.Candidate> Candidate { get; set; }
        public DbSet<COMP2084_MidTerm_NET5.Models.Job> Job { get; set; }
    }
}
