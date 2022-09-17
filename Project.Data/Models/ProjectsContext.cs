using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project.Data.Models
{
    public partial class ProjectsContext : DbContext
    {
        public ProjectsContext()
        {
        }

        public ProjectsContext(DbContextOptions<ProjectsContext> options)
            : base(options)
        {
        }
        public bool FilterCustomer { get; set; }
        public bool FilterOrder { get; set; }
        public bool FilterResturent { get; set; }
        public bool FilterMenue { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantMenu> RestaurantMenus { get; set; }
        public virtual DbSet<ScvView> ScvViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-R4I35TV\\SQLEXPRESS;Database=Projects;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(d => d.Custamer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustamerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Custamer__267ABA7A");

                entity.HasOne(d => d.RestaurantMenu)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RestaurantMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Restaura__276EDEB3");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RestaurantMenu>(entity =>
            {
                entity.ToTable("RestaurantMenu");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MealName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantMenus)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("FK__Restauran__Resta__164452B1");
            });

            modelBuilder.Entity<ScvView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("scvView");

                entity.Property(e => e.MostPurchasedCustomer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameResturent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TheBestSellingMeal)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Order>().HasQueryFilter(x => !x.Archived || FilterOrder);
            modelBuilder.Entity<Customer>().HasQueryFilter(x => !x.Archived || FilterCustomer);
            modelBuilder.Entity<Restaurant>().HasQueryFilter(x => !x.Archived || FilterResturent);
            modelBuilder.Entity<RestaurantMenu>().HasQueryFilter(x => !x.Archived || FilterMenue);
            OnModelCreatingPartial(modelBuilder); 
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
