public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        string connectionString = Configuration.GetConnectionString("DBCS");
        services.AddDbContext<YourDbContext>(options =>
            options.UseSqlServer(connectionString));
    }

    // Other methods...
}
