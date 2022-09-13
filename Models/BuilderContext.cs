using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class BuilderContext : DbContext
    {
        public BuilderContext()
        {
        }

        public BuilderContext(DbContextOptions<BuilderContext> options)
            : base(options)
        {
        }



        public virtual DbSet<BuilderForm> BuilderForm { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {  
                optionsBuilder.UseSqlServer("Server=KIENTRUONG;Database=Builder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuilderForm>(entity =>
            {
                entity.ToTable("BuilderForm");

                entity.Property(e => e.Buttion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HelpText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Option)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public DbSet<BuilderForm> BuilderForms{ get; set; }
        // public object BuilderForms { get; internal set; }
    }
}
