using System.ComponentModel.DataAnnotations;

namespace CDS.Repository.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Gender { get; set; }

    [EmailAddress]
    public string EmailAddress { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public long MobileNumber { get; set; }
}