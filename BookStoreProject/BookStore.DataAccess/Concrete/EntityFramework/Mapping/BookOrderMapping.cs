using Ecommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework.Mapping
{

    public class BookOrderMapping : IEntityTypeConfiguration<BookOrder>
    {
        public void Configure(EntityTypeBuilder<BookOrder> builder)
        {
            builder.ToTable("BookOrders", @"dbo");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BookId)
                   .HasColumnName("BookId");

            builder.Property(b => b.OrderId)
                   .HasColumnName("OrderId");

            builder.HasOne(bo => bo.Book)
                   .WithMany(bk => bk.Orders)
                   .HasForeignKey(bo => bo.OrderId);

            builder.HasOne(bo => bo.Order)
                   .WithMany(ord => ord.Books)
                   .HasForeignKey(bo => bo.BookId)
                   .OnDelete(DeleteBehavior.NoAction);


            //data to show when the project is up and running

            builder.HasData(new BookOrder
            {
                OrderId = 1,
                BookId = 1,
                Id = 1

            });
        }
    }
}