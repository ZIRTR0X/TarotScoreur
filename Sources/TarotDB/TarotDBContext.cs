﻿using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace TarotDB;

/// <summary>
/// Database context of the TarotScoreur app
/// </summary>
internal class TarotDBContext : DbContext
{
    public DbSet<PlayerEntity> Players { get; set; } = null!;
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<GameEntity> Games { get; set; } = null!;
    public DbSet<HandEntity> Hands { get; set; } = null!;
    public DbSet<BiddingPoigneeEntity> Biddings { get; set; } = null!;

    public TarotDBContext()
    {
    }

    public TarotDBContext(DbContextOptions<TarotDBContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=TarotScoreur.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BiddingPoigneeEntity>().HasKey(b => new {b.HandId, b.PlayerId});
        modelBuilder.Entity<GameEntity>()
            .HasMany(g => g.Players)
            .WithMany(p => p.Games)
            .UsingEntity(gp => gp.ToTable("GamePlayer"));
    }
}