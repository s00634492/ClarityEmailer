using Microsoft.EntityFrameworkCore;
using Emailer;

namespace ClarityEmailer.Models
{
    public class EmailContext : DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> options)
            : base(options)
        { }

        public DbSet<EmailModel> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ;
        }
    }
}
