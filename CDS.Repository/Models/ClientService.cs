using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDS.Repository.Models;

public class ClientService
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("ClientId")]
    public virtual Client Client { get; set; }

    [Required]
    [ForeignKey("ServiceId")]
    public virtual Service Service { get; set; }

    public ServiceDurationType DurationType { get; set; }

    public DateOnly StartDate { get; set; }

    public bool IsActive { get; set; }

    public DateOnly TerminationDate { get; set; }
}