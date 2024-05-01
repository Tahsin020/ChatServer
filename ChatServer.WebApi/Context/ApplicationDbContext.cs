using ChatServer.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatServer.WebApi.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Chat> Chats { get; set; }
}
