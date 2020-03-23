

using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore
{
    public class AlbumArtistContext : DbContext
    {

        public AlbumArtistContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<AlbumModel> Albums { get; set; }
        public DbSet<ArtistModel> Artists { get; set; }
        public DbSet<ArtistAlbum> artistAlbums { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=DESKTOP-GLMVMO1\SQLEXPRESS;Database=CodeFirstDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlbumModel>()
            .HasMany<ArtistModel>(o => o.Artists);
            modelBuilder.Entity<ArtistModel>()
           .HasMany<AlbumModel>(o => o.Albums);

        }
    }
}
