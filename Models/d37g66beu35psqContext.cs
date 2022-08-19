using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiSalao.Models
{
    public partial class d37g66beu35psqContext : DbContext
    {
        public d37g66beu35psqContext()
        {
        }

        public d37g66beu35psqContext(DbContextOptions<d37g66beu35psqContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adm> Adms { get; set; } = null!;
        public virtual DbSet<Buy> Buys { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Procedure> Procedures { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestProduct> RequestProducts { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<ReservationProcedure> ReservationProcedures { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("host;Database=.;Username=;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adm>(entity =>
            {
                entity.ToTable("adms");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Buy>(entity =>
            {
                entity.ToTable("buys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Buys)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("fk_request_id");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("discounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discount1).HasColumnName("discount");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.ToTable("procedures");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categorie)
                    .HasMaxLength(45)
                    .HasColumnName("categorie");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Qt).HasColumnName("qt");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RequestProductId).HasColumnName("request_product_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.RequestProduct)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestProductId)
                    .HasConstraintName("fk_requsest_product_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<RequestProduct>(entity =>
            {
                entity.ToTable("request_products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.QtProduct).HasColumnName("qt_product");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RequestProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_product_id");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("reservations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.ReservationProcedureId).HasColumnName("reservation_procedure_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ReservationProcedure)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.ReservationProcedureId)
                    .HasConstraintName("fk_reservation_procedure_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<ReservationProcedure>(entity =>
            {
                entity.ToTable("reservation_procedures");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ReservationProcedures)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("fk_procedure_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
