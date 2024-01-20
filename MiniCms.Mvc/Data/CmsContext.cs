using Microsoft.EntityFrameworkCore;
using MiniCms.Mvc.Models;

namespace MiniCms.Mvc.Data;

public class CmsContext : DbContext
{
    public CmsContext(DbContextOptions<CmsContext> options) : base(options)
    {
    }

    public DbSet<OrderViewModel> Orders => Set<OrderViewModel>();
}