#nullable disable
namespace DataAccess;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }


    // Relations
    // 1: One role can have many users
    public List<User> Users { get; set; }

}
