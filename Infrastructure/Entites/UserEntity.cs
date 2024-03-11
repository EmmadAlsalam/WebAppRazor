using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entites;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string SecurityKry { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Biography { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Modified { get; set; }

    public int? AddressId { get; set; }

    public AdressEntity? Address { get; set; }

}
