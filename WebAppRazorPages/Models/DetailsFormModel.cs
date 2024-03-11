using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPages.Models;

public class DetailsFormModel
{
    [DataType(DataType.ImageUrl)]
    public string? ProfilImage { get; set; }


    [Display(Name = "First Name", Prompt = "Enter	your  FirstName")]
    [Required(ErrorMessage = "FirstName is	required")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last Name", Prompt = "Enter	your  Last Name")]
    [Required(ErrorMessage = "Last Name is	required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email Adress", Prompt = "Enter	your  Email Adress")]
    [Required(ErrorMessage = "Enter your vaild email")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
    public string EmailAddress { get; set; } = null!;


    [Display(Name = "Phone", Prompt = "Ente your  Phone")]
    [Required(ErrorMessage = "Phone is	required")]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; } = null!;


    [Display(Name = "Bio", Prompt = "Add a short Massege ")]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; } 


}
