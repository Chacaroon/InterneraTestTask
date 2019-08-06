using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Seller> Sellers { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Deal> Deals { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region DataSeeding

			modelBuilder.Entity<Company>()
						.HasData(new[] {
							new Company { Id = 1, Name = "Company 1" },
							new Company { Id = 2, Name = "Company 2" },
							new Company { Id = 3, Name = "Company 3" },
						});

			modelBuilder.Entity<Customer>()
						.HasData(new[]
						{
							new Customer() { Id = 1, Name = "Customer 1" },
							new Customer() { Id = 2, Name = "Customer 2" },
							new Customer() { Id = 3, Name = "Customer 3" },
						});

			modelBuilder.Entity<Seller>()
						.HasData(new[] {
							new Seller() { Id = 1, CompanyId = 1, Name = "Seller 1" },
							new Seller() { Id = 2, CompanyId = 2, Name = "Seller 2" },
							new Seller() { Id = 3, CompanyId = 3, Name = "Seller 3" },
						});

			modelBuilder.Entity<Product>()
						.HasData(new[]
						{
							new Product() { Id = 1, Name = "Product 1" },
							new Product() { Id = 2, Name = "Product 2" },
							new Product() { Id = 3, Name = "Product 3" },
						});

			modelBuilder.Entity<Deal>()
						.HasData(new[] {
							new Deal() { Id = 1, CustomerId = 1, ProductId = 1, SellerId = 1, ProductAmount = 1 },
							new Deal() { Id = 2, CustomerId = 2, ProductId = 2, SellerId = 2, ProductAmount = 2 },
							new Deal() { Id = 3, CustomerId = 3, ProductId = 3, SellerId = 3, ProductAmount = 3 },
						});

			#endregion

			#region Relationships



			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}

}
