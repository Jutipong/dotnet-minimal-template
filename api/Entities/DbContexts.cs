using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Api.Entities.Models;

namespace Api.Entities
{
    public partial class DbContexts : DbContext
    {
        public DbContexts()
        {
        }

        public DbContexts(DbContextOptions<DbContexts> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<CustomerX> CustomerXes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; } = null!;
        public virtual DbSet<Todo> Todos { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Thai_BIN");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");
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
}
