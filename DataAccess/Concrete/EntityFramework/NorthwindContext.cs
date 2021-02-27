using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class NorthwindContext:DbContext
	{
		//bu metod senin projen hangi veritabanı ile ilişkili oldgn belirtir.
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder); bu db contextin configure calıştırır buna gerek yok.
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
		}
		public DbSet<Car>Cars { get; set; }
		public DbSet<Brand>Brands { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
