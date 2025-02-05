using CDS.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CDS.Repository.Context
{
    public class CDSContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ClientService> ClientServices { get; set; }

        public DbSet<ClientServiceCost> ClientServicesCosts { get; set; }

        public DbSet<ClientServicePayment> ClientServicePayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure composite key for ClientService
            //modelBuilder.Entity<ClientService>()
            //    .HasKey(cs => new { cs.Client.Id, cs.Service.Id });

            // Configure enum to be stored as string
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<ClientService>()
                .Property(cs => cs.DurationType)
                .HasConversion<string>();
        }

        public CDSContext(DbContextOptions<CDSContext> options)
        : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=srv1022.hstgr.io;database=u408385369_CDS_Master;user=u408385369_admin;password=CDSAdmin@2025");
        //}
    }
}