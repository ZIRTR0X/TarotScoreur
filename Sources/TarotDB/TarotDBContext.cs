﻿using Microsoft.EntityFrameworkCore;

namespace TarotDB;

internal class TarotDBContext : DbContext
{
    public DbSet<PlayerEntity> Players { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=TarotScoreur.db");
}