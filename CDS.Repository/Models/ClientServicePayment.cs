using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDS.Repository.Models;

public class ClientServicePayment
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("ClientServiceCostId")]
    public virtual ClientServiceCost ClientServiceCost { get; set; }

    public int ReceivedAmount { get; set; }

    public DateTime CreatedDate { get; set; }

    public string PaymentMode { get; set; } = "Cash";

    public string Remark { get; set; } = string.Empty;

    [ForeignKey("UserId")]
    [Required]
    public virtual User User { get; set; }
}