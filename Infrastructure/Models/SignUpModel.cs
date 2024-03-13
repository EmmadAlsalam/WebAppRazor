using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Infrastructure.Helpers;

namespace Infrastructure.Models;

public class SignUpModel
{
    [DisplayName("First name")]
    [Required(ErrorMessage = "Invalid first name")]
    [MinLength(2, ErrorMessage = "Enter a first name")]
    public string FirstName { get; set; } = null!;

    [DisplayName("Lats name")]
    [Required(ErrorMessage = "Invalid Last name")]
    [MinLength(2, ErrorMessage = "Enter a LastName")]
    public string LastName { get; set; } = null!;

    [DisplayName("Email adress")]
    [Required(ErrorMessage = "Invalid Email adress")]
    [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid email")]
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
