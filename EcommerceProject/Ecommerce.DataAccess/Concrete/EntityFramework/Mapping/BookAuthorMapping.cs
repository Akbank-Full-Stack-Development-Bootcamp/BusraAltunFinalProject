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
    public class BookAuthorMapping : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthors", @"dbo");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BookId)
                   .HasColumnName("BookId");

            builder.Property(b => b.AuthorId)
                   .HasColumnName("AuthorId");

            builder.HasOne(a => a.Book)
                   .WithMany(a => a.Authors)
                   .HasForeignKey(a => a.BookId);

            builder.HasOne(a => a.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(a => a.AuthorId);


            //data to show when the project is up and running

            builder.HasData(new BookAuthor
            {
                AuthorId = 1,
                BookId = 1,
                Id = 1,
               
            });
        }
    
    }
}
