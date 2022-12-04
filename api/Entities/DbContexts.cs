using System;
using System.Collections.Generic;
using Api.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Entities;

public partial class DbContexts : DbContext
{
    public DbContexts(DbContextOptions<DbContexts> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<CustomerX> CustomerXes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }

    public virtual DbSet<Todo> Todos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_BIN");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CustomerX>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07C0BFD46F");
        });

        modelBuilder.Entity<Todo>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Last).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Name).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
