using Microsoft.EntityFrameworkCore;
using projectef.models;

namespace projectef;

public class AssignmentContext: DbContext
{
	public DbSet<Category> Categories {get;set;}
	public DbSet<Assignment> Assignments {get;set;}

	public AssignmentContext(DbContextOptions<AssignmentContext> options): base(options) {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost;Username=root;Password=root;Database=mydatabase");
}