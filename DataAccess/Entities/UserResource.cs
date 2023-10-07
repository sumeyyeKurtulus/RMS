#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess;

public class UserResource
{
    // First Primary Key
    [Key]
    [Column(Order = 0)]
    public int UserId { get; set; }

    // Second Primary Key
    [Key]
    [Column(Order = 1)]
    public int ResourceId { get; set; }

    // Relations
    // 1: One UserResource can have one User
    public User User { get; set; }

    // 2: One UserResource can have one Resource
    public Resource Resource { get; set; }

}
