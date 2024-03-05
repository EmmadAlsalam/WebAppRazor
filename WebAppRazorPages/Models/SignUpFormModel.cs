using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPages.Models;

public class SignUpFormModel
{
    [DisplayName("First name")]
    [Required(ErrorMessage = "Invalid first name")]
    public string FirstName { get; set; } = null!;

    [DisplayName("Lats name")]
    [Required(ErrorMessage = "Invalid Last name")]
    public string LastName { get; set; } = null!;

    [DisplayName("Email adress")]
    [Required(ErrorMessage = "Invalid Email adress")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [DisplayName("Password")]
    [Required(ErrorMessage = "Invalid Password")]
    public string Password { get; set; } = null!;
    [DataType(DataType.Password)]

    [DisplayName("Comfrim Password")]
    [Required(ErrorMessage = "must Comfrim Password")]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    public string ComfrimPassword { get; set; } = null!;

    [DisplayName("Terms & Conditions")]
    [CheckBoxRequired(ErrorMessage = "Please accept the terms and condition.")]
    public bool Terms { get; set; } = false;


}


public class CheckBoxRequired : ValidationAttribute, IClientModelValidator
{
    public override bool IsValid(object value)
    {
        if (value is bool)
        {
            return (bool)value;
        }

        return false;
    }

    public void AddValidation(ClientModelValidationContext context)
    {
        context.Attributes.Add("data-val-checkboxrequired", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
    }
}
