namespace DhakaRegencyProject.DB;

public class ApplicationDBContext : DbContext
{
    public DbSet<Class> Classes { get; set; }
    public DbSet<Student> Students { get; set; }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DhakaRegencyDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}