using Microsoft.EntityFrameworkCore;


namespace OSA.Server.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        // DbSet properties for entity classes
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Administrator> Administrators { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Administrator>()
                .HasOne(a => a.User)
                .WithOne()
                .HasForeignKey<Administrator>(a => a.user_id);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.User)
                .WithOne()
                .HasForeignKey<Instructor>(i => i.user_id);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithOne()
                .HasForeignKey<Student>(s => s.user_id);
        }
    }
}