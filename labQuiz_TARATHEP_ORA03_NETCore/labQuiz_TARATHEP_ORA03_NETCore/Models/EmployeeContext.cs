using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace labQuiz_TARATHEP_ORA03_NETCore.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<titles> Titles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

                optionsBuilder.UseSqlServer("Server=Bokie-Surface;Database=Employee;User " +
                    "ID=sa;Password=password;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<departments>(entity =>
            {
                entity.HasKey(e => e.DeptNo);

                entity.ToTable("departments");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.empNo);

                entity.ToTable("employees");

                entity.Property(e => e.empNo)
                    .HasColumnName("emp_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.department)
                    .HasColumnName("department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.firstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.lastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.salary)
                    .HasColumnName("salary")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.titleName)
                    .HasColumnName("title_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.HasKey(e => e.genderId);

                entity.ToTable("genders");

                entity.Property(e => e.genderId)
                    .HasColumnName("gender_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.genderDescription)
                    .HasColumnName("gender_description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.genderName)
                    .HasColumnName("gender_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<titles>(entity =>
            {
                entity.HasKey(e => e.title);

                entity.ToTable("titles");

                entity.Property(e => e.title)
                    .HasColumnName("title")
                    .ValueGeneratedNever();

                entity.Property(e => e.titleName)
                    .HasColumnName("title_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
