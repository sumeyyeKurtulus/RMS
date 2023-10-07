#nullable disable
namespace DataAccess;

public class Resource
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public decimal Score { get; set; }
    public DateTime Date { get; set; }

    // Relations
    // 1: One Resource can have many UserResources
    public List<UserResource> UserResources { get; set; }
}
