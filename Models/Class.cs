using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DhakaRegencyProject.Models;

[Table("Class")]
public class Class : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Id")]
    public int Id { get; set; }

    [Required]
    [Column("Name")]
    public string? Name { get; set; }

    public virtual ICollection<Student>? Students { get; set; }

}