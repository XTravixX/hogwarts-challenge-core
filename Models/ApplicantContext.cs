using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace hogwarts_challenge_core.Models
{
    public class ApplicantContext : DbContext
    {
        public ApplicantContext(DbContextOptions<ApplicantContext> options) : base(options)
        { }
        
        public DbSet<Applicant> Applicants { get; set; } = null!;
    }
}