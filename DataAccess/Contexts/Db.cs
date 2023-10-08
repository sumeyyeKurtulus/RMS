using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class Db: DbContext
{

    //1: Add the tables 
    public DbSet<User> Users { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserResource> UserResources { get; set; }

    public Db(DbContextOptions options): base(options){}

    // We will need to create a model creation method for 
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<UserResource>().HasKey(e => new {e.UserId, e.ResourceId});
    }
}
