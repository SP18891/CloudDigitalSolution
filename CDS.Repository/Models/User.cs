using System.ComponentModel.DataAnnotations;

namespace CDS.Repository.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string EmailAddress { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public long MobileNumber { get; set; }
}