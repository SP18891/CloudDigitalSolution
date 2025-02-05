using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDS.Repository.Models;

public class Client
{
    [Key]
    public int Id { get; set; }

    public string ClientId { get; set; }

    public string ClientName { get; set; }

    public string CompanyAddress { get; set; }

    public string ComapnyName { get; set; }

    public string EmailAddress { get; set; }

    public long MobileNumber1 { get; set; }

    public long MobileNumber2 { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
}