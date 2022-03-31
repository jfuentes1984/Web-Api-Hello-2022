using Microsoft.EntityFrameworkCore;

namespace Web_Api_Hello;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    public DbSet<Place>? Places { get; set; }
}