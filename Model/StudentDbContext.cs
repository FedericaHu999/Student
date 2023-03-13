using Microsoft.EntityFrameworkCore;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    { 
        
    }

    public DbSet<Students> Students { get; set; }
    public DbSet<Course> Course { get; set; } 
    public DbSet<Pair> Pair { get; set; }
    public DbSet<Run> Run { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Students>().ToTable("Studenti");

        modelBuilder.Entity<Students>()
                .Property(s => s.IdEmail)
                .HasColumnType("varchar")
                .HasMaxLength(40);
        modelBuilder.Entity<Students>()
                .Property(s => s.Name)
                .HasColumnName("FirstName")
                .HasColumnType("varchar")
                .HasMaxLength(30);
        modelBuilder.Entity<Students>()
                .Property(s => s.Surname)
                .HasColumnName("LastName")
                .HasColumnType("varchar")
                .HasMaxLength(30);

        modelBuilder.Entity<Pair>()
                .HasOne(a => a.FirstStudent)
                .WithMany(a => a.PairUserOne)
                .HasForeignKey(a => a.)
                .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Pair>()
                .HasOne(a => a.SecondStudent)
                .WithMany(a => a.PairUserOne)
                .HasForeignKey(a => a.)
                .OnDelete(DeleteBehavior.Restrict);
        
    }

}