using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Contexts
{
	public class ProgrammersBlogContext:DbContext
	{
		public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString: @"Data Source=(localdb)\ProjectsV13;Database=ProgrammerBlog;Initial 
                                                          Catalog=master;Integrated Security=True;Connect Timeout=30;
                                                          Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                                          MultiSubnetFailover=False");
		}

	}
}
