using System.ComponentModel.DataAnnotations;
namespace PlantShop.Models;

public class Staff()
{
    public int Staff_Id { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Make sure that the Forename is at least 2 characters. Must start with a capital letter.")]
    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Forename { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Make sure that the Surname is at least 2 characters. Must start with a capital letter.")]
    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Surname { get; set; }

    //Restore when add entry works
    //public DateOnly DateOfBirth { get; set; }

    [RegularExpression("^[a-z]+(@greenplant.com)$", ErrorMessage = "Make sure the email is according to the company standard format *yourname@greenplant.com*. The email cannot have a capital letter in it.")]
    [Required]
    [StringLength(50, MinimumLength = 10)]
    public string Email { get; set; }

    [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$", ErrorMessage = "Paasword must have these conditions: Has minimum 8 characters in length.At least one uppercase English letter. At least one lowercase English letter. At least one digit.")]
    [Required]
    [StringLength(50, MinimumLength = 8)]
    public string Password { get; set; }

    [RegularExpression("^(?:manager(?!.*manager)|standard(?!.*standard))$", ErrorMessage = "Role can only be 'standard or manager'")]
    [Required]
    public string Role { get; set; }
}