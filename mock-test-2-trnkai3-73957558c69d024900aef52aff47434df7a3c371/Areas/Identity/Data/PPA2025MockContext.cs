using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PPA2025Mock.Areas.Identity.Data;

namespace PPA2025Mock.Data;

public class PPA2025MockContext : IdentityDbContext<PPA2025MockUser>
{
    public PPA2025MockContext(DbContextOptions<PPA2025MockContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
