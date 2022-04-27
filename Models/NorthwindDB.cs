using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Builds a model of the entity classes used in the application.  This then represents an entity set that can be used for create, read
/// update and delete operations
/// </summary>

namespace UWofS.CS7
{
    public class NorthwindDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }//sets dbSet type properties for the entitites which map to the database tables.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        public NorthwindDB(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);// Defines a way to configure the entities 


            //sets the model for the entity Category Name to max-Length of 15 and required.
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);

            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerID)
                .IsRequired()
                .HasMaxLength(5);

            modelBuilder.Entity<Customer>()
                .Property(c => c.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Customer>()
                .Property(c => c.ContactName)
                 .HasMaxLength(30);

            modelBuilder.Entity<Customer>()
                 .Property(c => c.Country)
                 .HasMaxLength(15);

            modelBuilder.Entity<Employee>()
                .Property(c => c.LastName)
                 .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Employee>()
                .Property(c => c.FirstName)
                 .IsRequired()
                 .HasMaxLength(10);

            modelBuilder.Entity<Employee>()
                .Property(c => c.Country)
                 .HasMaxLength(15);

            modelBuilder.Entity<Employee>()
                .HasOne(c => c.Manager)
                .WithMany()
                .HasForeignKey(c => c.ReportsTo);

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                 .IsRequired()
                 .HasMaxLength(40);

            modelBuilder.Entity<Product>()
                 .HasOne(p => p.Category)
                 .WithMany(c => c.Products);

            modelBuilder.Entity<Product>()
                 .HasOne(p => p.Supplier)
                 .WithMany(s => s.Products);

            modelBuilder.Entity<OrderDetail>()
                .ToTable("Order Details");


            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderID, od.ProductID });

            modelBuilder.Entity<Supplier>()
                 .Property(c => c.CompanyName)
                 .IsRequired()
                 .HasMaxLength(40);

            modelBuilder.Entity<Supplier>()
                 .HasMany(s => s.Products)
                 .WithOne(p => p.Supplier);
        }
    }

    
}
