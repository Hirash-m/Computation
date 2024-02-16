using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Models;

public partial class ComputationContext : DbContext
{
    public ComputationContext()
    {
    }

    public ComputationContext(DbContextOptions<ComputationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }

    public virtual DbSet<InventoryTransactionDetail> InventoryTransactionDetails { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<PersonType> PersonTypes { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2UH1FV0\\HIRASH;Initial catalog = Computation;User Id=sa;Password=Nm123456;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Persian_100_CI_AI");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(400)
                .HasColumnName("Address");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Title).HasMaxLength(250);
            entity.Property(e => e.TypeAdressId).HasColumnName("TypeAdressID");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.Person).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Addresses_Persons");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);

            entity.HasOne(d => d.User).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Users");
        });

        modelBuilder.Entity<InventoryTransaction>(entity =>
        {
            entity.ToTable("InventoryTransaction");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InventoryId).HasColumnName("InventoryID");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");

            entity.HasOne(d => d.AcceptUserNavigation).WithMany(p => p.InventoryTransactionAcceptUserNavigations)
                .HasForeignKey(d => d.AcceptUser)
                .HasConstraintName("FK_InventoryTransaction_Users1");

            entity.HasOne(d => d.CreateUserNavigation).WithMany(p => p.InventoryTransactionCreateUserNavigations)
                .HasForeignKey(d => d.CreateUser)
                .HasConstraintName("FK_InventoryTransaction_Users");

            entity.HasOne(d => d.Inventory).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransaction_Inventory");
        });

        modelBuilder.Entity<InventoryTransactionDetail>(entity =>
        {
            entity.ToTable("InventoryTransactionDetail");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.InventoryTransactionId).HasColumnName("InventoryTransactionID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InventoryTransactionDetail)
                .HasForeignKey<InventoryTransactionDetail>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransactionDetail_InventoryTransaction");

            entity.HasOne(d => d.Product).WithMany(p => p.InventoryTransactionDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransactionDetail_Product");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerRemaining)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Family).HasMaxLength(250);
            entity.Property(e => e.ModifiDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.NationalCode).HasMaxLength(50);

            entity.HasOne(d => d.CreateUserNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.CreateUser)
                .HasConstraintName("FK_Persons_Users");

            entity.HasOne(d => d.Type).WithMany(p => p.People)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_Persons_PersonType");
        });

        modelBuilder.Entity<PersonType>(entity =>
        {
            entity.ToTable("PersonType");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Phone");

            entity.HasOne(d => d.Person).WithMany(p => p.Phones)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Phones_Persons");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastPriceUpdate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.SaleAble).HasDefaultValue(true);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.HasOne(d => d.Person).WithMany(p => p.Users)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Persons");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
