using System.ComponentModel.DataAnnotations;

namespace PlantShop.Models;

public class Plant()
{
    public int Plant_Id { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Make sure that the Name is at least 2 characters. Must start with a capital letter.")]
    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Name { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Make sure that the Name is at least 2 characters. Must start with a capital letter.")]
    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Family { get; set; }

    [RegularExpression("^(?:indoor(?!.*indoor)|outdoor(?!.*outdoor))$", ErrorMessage = "Plant can only be 'indoor or outdoor'")]
    [Required]
    public string IndoorOutdoor { get; set; }



    public string Plant_Image { get; set; }
}