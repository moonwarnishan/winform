using System.ComponentModel.DataAnnotations.Schema;

namespace DhakaRegencyProject.Models;
public class BaseModel
{
    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [Column("ModificationDate")]
    public DateTime ModificationDate { get; set; }
}