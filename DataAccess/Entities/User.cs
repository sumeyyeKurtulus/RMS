#nullable disable
namespace DataAccess;
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }

    public Statuses Status { get; set; }

    // Relations
    // 1: One User can have one Role ---->
    //        Please add the RoleId as well since it is on the ONE side and it needs to be distinguishable
    public Role Role { get; set; }
    public int RoleId { get; set; }

    // 2: One User can have many UserResources
    public List<UserResource> UserResources { get; set; }
}
