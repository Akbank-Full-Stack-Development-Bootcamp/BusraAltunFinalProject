using Ecommerce.DataAccess.Concrete.EntityFramework.Mapping;
using Ecommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.Contexts
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options ) : base (options)
        {

        }

        public ECommerceContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = " Data Source=DESKTOP-QL5AQK8;Initial Catalog=ECommerceDb;Integrated Security=True;Pooling=False ";
            optionsBuilder.UseSqlServer(connectionString);
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new BookAuthorMapping());
            modelBuilder.ApplyConfiguration(new BookOrderMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<BookOrder> BookOrders { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }

        

    }
}
