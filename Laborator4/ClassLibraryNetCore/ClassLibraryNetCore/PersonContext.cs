using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore
{
    public class PersonContext : DbContext
    {

        public PersonContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<PersonModel> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GLMVMO1\SQLEXPRESS;Database=CodeFirstDB;Trusted_Connection=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>()
                 .Property(t => t.PersonId)
                 .IsRequired();

            modelBuilder.Entity<PersonModel>()
                    .Property(t => t.FirstName)
                    .IsRequired()
                    .HasMaxLength(10);

            modelBuilder.Entity<PersonModel>()
                .Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<PersonModel>()
                .Property(t => t.MidleName)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<PersonModel>()
                .Property(t => t.TelephoneNumber)
                .IsRequired()
                .HasMaxLength(10);

        }
    }

}
