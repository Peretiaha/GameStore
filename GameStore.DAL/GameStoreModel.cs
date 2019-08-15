
namespace GameStoreModel
{
    using GameStoreModel.Models;
    using Microsoft.EntityFrameworkCore;


    public class GameStoreDb : DbContext
    {

        public GameStoreDb(DbContextOptions<GameStoreDb> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<PlatformType> PlatformTypes { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<GameGenre> GameGenres { get; set; }

        public DbSet<GamePlatform> GamePlatforms { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<GameGenre>().HasOne<Game>(s => s.Game).WithMany(sc => sc.GameGenre)
                .HasForeignKey(s => s.GameId);
            modelBuilder.Entity<GameGenre>().HasOne<Genre>(s => s.Genre).WithMany(sc => sc.GameGenre)
                .HasForeignKey(s => s.GenreId);
            modelBuilder.Entity<GamePlatform>().HasOne<Game>(s => s.Game).WithMany(sc => sc.GamePlatform)
                .HasForeignKey(s => s.GameId);
            modelBuilder.Entity<GamePlatform>().HasOne<PlatformType>(s => s.Platform).WithMany(sc => sc.GamePlatform)
                .HasForeignKey(s => s.PlatformTypeId);
            modelBuilder.Entity<GamePlatform>().HasKey(sc => new { sc.GameId, sc.PlatformTypeId }); 
            modelBuilder.Entity<GameGenre>().HasKey(sc => new { sc.GameId, sc.GenreId });
            modelBuilder.Entity<Comment>().HasOne<Game>(s => s.Game).WithMany(m => m.ListOfComments)
                .HasForeignKey(s => s.GameId);

        }
    }
}
