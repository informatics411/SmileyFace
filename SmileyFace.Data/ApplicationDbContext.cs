using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using SmileyFace.Data.Entities;
using System.Reflection.Metadata;

namespace SmileyFace.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
        //NewMethod(modelBuilder).HasKey(product => product.Id);
        //modelBuilder.Entity<Product>().Property(product => product.Name).HasMaxLength(70);

        //modelBuilder.Entity<IdeaCluster>()
        //    .HasKey(cluster => cluster.Id);

        //modelBuilder.Entity<Emoji>().HasKey(Emoji => Emoji.Id);
        //modelBuilder.Entity<Emoji>().Property(emoji => emoji.Meaning).HasMaxLength(70);

        //modelBuilder.Entity<IdeaCluster>()
        //    .HasMany(cluster => cluster.Emoji)
        //    .WithOne(cluster => emoji.Cluster)
        //    .HasPrincipalKey(cluster => cluster.Id)
        //    .HasForeignKey(emoji => emoji.IdeaClusterId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //modelBuilder.Entity<EmojiPositionLinkedNode>()
        //    .HasOne(emoji => emoji.PreviousId)
        //    .WithOne(emoji => emoji.Next)
        //    .HasPrincipalKey<Emoji>(principal => principal.Id)
        //    .HasForeignKey<Emoji>(dependent => dependent.PreviousId);

        //modelBuilder.Entity<EmojiPositionLinkedNode>()
        //    .HasOne(emoji => emoji.NextId)
        //    .WithOne(emoji => emoji.Previous)
        //    .HasPrincipalKey<Emoji>(principal => principal.Id)
        //    .HasForeignKey<Emoji>(dependent => dependent.SuccessorId);

        //base.OnModelCreating(modelBuilder);
    //}

    //private static Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> NewMethod(ModelBuilder modelBuilder)
    //{
    //    return modelBuilder.Entity<Product>();
    //}

    public DbSet<MapperOfAllSpaces> AllPositions { get; set; }
    public DbSet<Emoji> Emojis { get; set; }
    public DbSet<EmojiPosition> EmojiPositions { get; set; }
    // public DbSet<EmojiPositionLinkedNode> EmojiPositionLinkedNodes { get; set; }
    public DbSet<ProfileEmojisMap> IdeaMaps { get; set; }
    public DbSet<ProfileSession> SessionProfiles { get; set; }
    public DbSet<EmojisCluster> EmojisClusters { get; set; }
    public object Emoji { get; set; }
}

