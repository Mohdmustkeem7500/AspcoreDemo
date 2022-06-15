using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AspcoreDemo.Models
{
    //public partial class AspcoreDemoContext : DbContext
    public class AspcoreDemoContext : DbContext
    {
        public AspcoreDemoContext(DbContextOptions<AspcoreDemoContext> options) : base(options)
        {
        }

        //public virtual DbSet<Employee> Employees { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-L91OLLD;Database=AspcoreDemo;Integrated Security=True");
        //            }
        //        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>(entity =>
        //    {
        //        entity.HasNoKey();

        //        entity.Property(e => e.Address)
        //            .HasMaxLength(250)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Designation)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EmployeeId).ValueGeneratedOnAdd();

        //        entity.Property(e => e.JoiningDate).HasColumnType("datetime");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
