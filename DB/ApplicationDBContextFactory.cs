namespace DhakaRegencyProject.DB;

public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
{
    public ApplicationDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DhakaRegencyDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        return new ApplicationDBContext(optionsBuilder.Options);
    }
}
