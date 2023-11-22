using Car_rental.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Car_rental.Data
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarssRecord;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server=PSRINIVASAMUR04\\SQLEXPRESS;Database=Car_rental;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            //gitclonetry
        }

        public DbSet<Users> Signups { get; set; }

        public DbSet<Cars> Cars { get; set; }

        public DbSet<Owner> owners { get; set; }

        public DbSet<CarAvailability> carsAvailability { get; set; }

        public DbSet<Booking> bookings { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseAuditEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "system";
                        entry.Entity.LastUpdatedDate = DateTime.UtcNow;
                        entry.Entity.LastUpdatedBy = "system";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastUpdatedDate = DateTime.UtcNow;
                        entry.Entity.LastUpdatedBy = "system";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }


}
    

