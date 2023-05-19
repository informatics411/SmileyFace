using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using SmileyFace.Data.Entities;

namespace SmileyFace.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<IdeaChain> IdeaChains { get; set; }
    public DbSet<Emoji> Emojis { get; set; }
    public DbSet<IdeaMapProfile> IdeaMaps { get; set; }
    public DbSet<SessionProfile> SessionProfiles { get; set; }
}

