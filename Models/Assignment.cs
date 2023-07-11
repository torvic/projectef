using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.models;

public class Assignment
{
	[Key]
	public Guid AssignmentId { get; set; }

	[ForeignKey("CategoryId")]
	public Guid CategoryId { get; set; }

	[Required]
	[MaxLength(200)]
	public string Title { get; set; }

	public string Description { get; set; }

	public Priority AssignmentPriority { get; set; }

	public DateTime CreationDate { get; set; }

	public virtual Category Category { get; set; }

	[NotMapped]
	public string Overview { get; set; }
}

public enum Priority
{
	Low,
	Medium,
	High,
}