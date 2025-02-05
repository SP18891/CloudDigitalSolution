using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDS.Repository.Models;

public class ClientServiceCost
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("ClientServicesId")]
    public virtual ClientService ClientService { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Currency { get; set; } = "INR";

    public double ReceivedAmount { get; set; }

    public double TotalAmount { get; set; }

    public double BalanceAmount { get; set; }

    public double Discount { get; set; }
}