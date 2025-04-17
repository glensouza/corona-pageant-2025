using Corona.Pageant.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Corona.Pageant.Web.Database;

public class PageantDb : DbContext
{
    public PageantDb(DbContextOptions options) : base(options) { }

    public DbSet<Scripts> Scripts => this.Set<Scripts>();
    public DbSet<Settings> Settings => this.Set<Settings>();
}
