using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Banking_Backend.Data
{
    public class AppDbContext : DbContext 
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet <Models.Role> Roles { get; set; }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Account> Accounts { get; set; }
        public DbSet<Models.Transaction> Transactions { get; set; }
        public DbSet<Models.Beneficiary> Beneficiaries { get; set; }
        public DbSet<Models.AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Transaction>()
                .HasOne(t => t.FromAccount)
                .WithMany(a => a.SentTransactions)
                .HasForeignKey(t => t.FromAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Models.Transaction>()
                .HasOne(t => t.ToAccount)
                .WithMany(a => a.ReceivedTransactions)
                .HasForeignKey(t => t.ToAccountId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
