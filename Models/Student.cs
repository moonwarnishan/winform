using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DhakaRegencyProject.Models;

[Table("Student")]
public class Student : BaseModel
{
    [Key]
    [Column("Id")]
    public Guid Id { get; set; }

    [Required]
    [Column("Name")]
    public string? Name { get; set; }

    [Column("Gender")]
    public int Gender { get; set; }
    [Column("DOB")]
    public DateTime DOB { get; set; }
    [Column("ClassId")]
    public int ClassId { get; set; }

    [ForeignKey("ClassId")]
    public virtual Class? Class { get; set; }
}
