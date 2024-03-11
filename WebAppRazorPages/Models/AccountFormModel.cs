using System.ComponentModel.DataAnnotations;


namespace WebAppRazorPages.Models;

public class AccountFormModel
{
    [Display(Name = "Address line 1", Prompt = "Enter	your  address  line")]
    [Required(ErrorMessage = "Address	1ine is	required")]
     public string AddressIine_1 { get; set; } = null!;


    [Display(Name = "Address line 2", Prompt = "Enter	your second  addressline")]
    public string AddressIine_2 { get; set; } = null!;


    [Display(Name = "Postal code", Prompt = "Enter	your Postol code")]
    [Required(ErrorMessage = "Postol code is required")]
    [DataType(DataType.PostalCode)] 
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter	your  City")]
    [Required(ErrorMessage = "City is	required")]
    public string City { get; set; } = null!;


}
