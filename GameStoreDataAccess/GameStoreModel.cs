
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

        public System.Data.Entity.DbSet<Game> Games { get; set; }

        public System.Data.Entity.DbSet<Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<PlatformType> PlatformTypes { get; set; }

        public System.Data.Entity.DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<GameGenre> GameGenres { get; set; }

        public System.Data.Entity.DbSet<GamePlatform> GamePlatforms { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<GameGenre>().HasOne<Game>(s => s.Game).WithMany(sc => sc.GameGenre)
                .HasForeignKey(s => s.GameId);
            modelBuilder.Entity<GamePlatform>().HasOne<Game>(s => s.Game).WithMany(sc => sc.GamePlatform)
                .HasForeignKey(s => s.GameId);
            modelBuilder.Entity<GamePlatform>().HasKey(sc => new { sc.GameId, sc.PlatformTypeId }); 
            modelBuilder.Entity<GameGenre>().HasKey(sc => new { sc.GameId, sc.GenreId });
            modelBuilder.Entity<Comment>().HasOne<Game>(s => s.Game).WithMany(m => m.ListOfComments)
                .HasForeignKey(s => s.GameId);

        }
    }
}
