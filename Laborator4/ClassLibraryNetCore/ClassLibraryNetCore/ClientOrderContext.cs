using Microsoft.EntityFrameworkCore;


namespace ClassLibraryNetCore
{
    public class ClientOrderContext : DbContext
    {
        public ClientOrderContext() 
        {
            Database.EnsureCreated();
       }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GLMVMO1\SQLEXPRESS;Database=CodeFirstDB;Trusted_Connection=True;");
            }
        }

        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<OrderModel> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientModel>()
            .HasMany<OrderModel>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<ClientModel>()
        .ToTable("Clients");
            modelBuilder.Entity<OrderModel>()
        .ToTable("OrderModels");
        }

}
}
