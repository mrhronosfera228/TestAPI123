using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class StatementDetailContext : DbContext
    {
        public StatementDetailContext(DbContextOptions<StatementDetailContext> options) : base(options)
        {

        }
        public DbSet<StatementDetail1> StatementDetails1 { get; set; }
        public DbSet<StatementDetail2> StatementDetails2 { get; set; }
    }
}
