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

    public DbSet<AllPositionsMapper> AllPositions { get; set; }
    public DbSet<Emoji> Emojis { get; set; }
    public DbSet<EmojiPosition> EmojiPositions { get; set; }
    public DbSet<EmojiPositionLinkedNode> EmojiPositionLinkedNodes { get; set; }
    public DbSet<ProfileIdeaMap> IdeaMaps { get; set; }
    public DbSet<ProfileSession> SessionProfiles { get; set; }
    public DbSet<IdeaChain> IdeaChains { get; set; }
}

