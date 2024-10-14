using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDataProtection.Data
{
    public class IdentityProtectionDbContext : IdentityDbContext<IdentityUser>
    {
        public IdentityProtectionDbContext(DbContextOptions<IdentityProtectionDbContext> options) : base(options)
        {
        }
    }
}
