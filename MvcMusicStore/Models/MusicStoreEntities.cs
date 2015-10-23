using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			// do not use migration
			Database.SetInitializer<MusicStoreEntities>(null);

			modelBuilder.Entity<Artist>().ToTable("Artist", "public");
			modelBuilder.Entity<Album>().ToTable("Album", "public");
			modelBuilder.Entity<Cart>().ToTable("Cart", "public");
			modelBuilder.Entity<Order>().ToTable("Order", "public");
			modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail", "public");
			modelBuilder.Entity<Genre>().ToTable("Genre", "public");
		}
	}
}