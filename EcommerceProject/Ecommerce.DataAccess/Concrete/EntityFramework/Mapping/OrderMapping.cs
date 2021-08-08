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
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId)
                   .HasColumnName("UserId")
                   .HasMaxLength(10)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.BookId)
                   .HasColumnName("BookId")
                   .HasMaxLength(10)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.OrderDate)
                   .HasColumnName("OrderDate")
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.CreatedOrderDate).HasDefaultValue(DateTime.Now);


            //data to show when the project is up and running

            builder.HasData(new Order
            {
                Id = 1,
                BookId = 1,
                UserId = 1,
                CreatedOrderId = 1,
                CreatedOrderDate = Convert.ToDateTime("16-08-2021"),
                OrderDate = Convert.ToDateTime("18-08-2021")
                

            });
        }
    }
}
