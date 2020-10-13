using Kanban.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Kanban.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { set; get; }
        public DbSet<Cardlist> Cardlists { set; get; }
        public DbSet<Board> Boards { set; get; }
        public DbSet<User> Users { set; get; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Card>().ToTable("Cards");
            builder.Entity<Card>().HasKey(p => p.Id);
            builder.Entity<Card>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Card>().Property(p => p.Name);
            builder.Entity<Card>().Property(p => p.Description);

            builder.Entity<Cardlist>().ToTable("Cardlists");
            builder.Entity<Cardlist>().HasKey(p => p.Id);
            builder.Entity<Cardlist>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Cardlist>().Property(p => p.Name);
            builder.Entity<Cardlist>().Property(p => p.Description);
            builder.Entity<Cardlist>().Property(p => p.IsVisible);
            builder.Entity<Cardlist>().HasMany(p => p.Cards).WithOne(p => p.Cardlist).HasForeignKey(p => p.CardlistId);


            // builder.Entity<Board>().ToTable("Boards");
            // builder.Entity<Board>().HasKey(p => p.Id);
            // builder.Entity<Board>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            // builder.Entity<Board>().Property(p => p.Name);


            // builder.Entity<User>().ToTable("Users");
            // builder.Entity<User>().HasKey(p => p.Id);
            // builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            // builder.Entity<User>().Property(p => p.Name);
            // builder.Entity<User>().Property(p => p.Password);


            builder.Entity<Card>().HasData
            (
                new Card { Id = 100, Name = "Card 100", CardlistId = 100 },
                new Card { Id = 101, Name = "Card 101", CardlistId = 100 }
            );

            builder.Entity<Cardlist>().HasData
            (
                new Cardlist { Id = 100, Name = "Cardlist 100", Description = "Demo Cardlist" }
            );
        }
    }
}