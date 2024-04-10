using Microsoft.EntityFrameworkCore;
namespace ASPNetCore_pr4.Models;

public class AppDbContent : DbContext{
    public DbSet<Users> Users { get; set; }
    public DbSet<Message> Message { get; set; }
    public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
    {

    }
}