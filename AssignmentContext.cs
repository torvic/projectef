using Microsoft.EntityFrameworkCore;
using projectef.models;

namespace projectef;

public class AssignmentContext: DbContext
{
	protected readonly IConfiguration Configuration;
	public AssignmentContext(IConfiguration configuration)
	{
			Configuration = configuration;
	}
	public DbSet<Category> Categories {get;set;}
	public DbSet<Assignment> Assignments {get;set;}

	// public AssignmentContext(DbContextOptions<AssignmentContext> options): base(options) {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
    optionsBuilder.UseNpgsql(Configuration.GetConnectionString("cnMyDatabase"));
	}
}