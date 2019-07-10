using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CandidateInformation.Models
{
    public class CandidateInformationContext : DbContext
    {
        public CandidateInformationContext (DbContextOptions<CandidateInformationContext> options)
            : base(options)
        {
        }

        public DbSet<CandidateInformation.Models.Candidate> Candidate { get; set; }
    }
}
