using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
						.HasData(Enumerable.Range(1, 3).Select(i => new Company()
						{
							Id = i,
							Name = $"Company {i}"
						}));

			modelBuilder.Entity<Customer>()
						.HasData(Enumerable.Range(1, 3).Select(i => new Customer()
						{
							Id = i,
							Name = $"Customer {i}"
						}));

			modelBuilder.Entity<Seller>()
						.HasData(Enumerable.Range(1, 3).Select(i => new Seller()
						{
							Id = i,
							CompanyId = i,
							Name = $"Seller {i}"
						}));

			modelBuilder.Entity<Product>()
						.HasData(Enumerable.Range(1, 3).Select(i => new Product()
						{
							Id = i,
							Name = $"Product {i}"
						}));

			modelBuilder.Entity<Deal>()
						.HasData(Enumerable.Range(1, 3).Select(i => new Deal()
						{
							Id = i,
							CustomerId = i,
							ProductId = i,
							SellerId = i,
							ProductAmount = i
						}));

			#endregion

			#region Relationships



			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}

}
