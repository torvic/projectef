using Microsoft.EntityFrameworkCore;
using projectef.models;

namespace projectef;

public class AssignmentContext: DbContext
{
	public DbSet<Category> Categories {get;set;}
	public DbSet<Assignment> Assignments {get;set;}

	public AssignmentContext(DbContextOptions<AssignmentContext> options): base(options) {}

}