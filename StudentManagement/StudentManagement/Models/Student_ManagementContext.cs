using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Student_ManagementContext : DbContext
    {
        public Student_ManagementContext()
        {
        }

        public Student_ManagementContext(DbContextOptions<Student_ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Student_Management"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.MajorCode)
                    .HasName("PK__Major__64E58F95A06A0763");

                entity.ToTable("Major");

                entity.Property(e => e.MajorCode)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.MajorName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => new { e.StudentCode, e.SubjectCode });

                entity.ToTable("Result");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.StudentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Result__StudentC__2A4B4B5E");

                entity.HasOne(d => d.SubjectCodeNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.SubjectCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_Subject");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentCode)
                    .HasName("PK__Student__1FC886059B422EAB");

                entity.ToTable("Student");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.MajorCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MajorCodeNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.MajorCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__MajorCo__2C3393D0");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubjectCode)
                    .HasName("PK__Subject__9F7CE1A8500E0147");

                entity.ToTable("Subject");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
