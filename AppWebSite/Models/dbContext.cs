using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppWebSite.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Encuesta> Encuesta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.HasKey(e => new { e.Enfecha, e.Enemail });

                entity.ToTable("encuesta");

                entity.Property(e => e.Enfecha)
                    .HasColumnName("enfecha")
                    .HasColumnType("date");

                entity.Property(e => e.Enemail)
                    .HasColumnName("enemail")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Encalificacion).HasColumnName("encalificacion");

                entity.Property(e => e.Ennombre)
                    .IsRequired()
                    .HasColumnName("ennombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
