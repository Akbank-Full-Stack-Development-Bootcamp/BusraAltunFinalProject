using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.Concrete.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
  
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.ToTable("Books", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BookName)
                   .HasColumnName("BookName")
                   .HasMaxLength(50)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Publisher)
                   .HasColumnName("Publisher")
                   .HasMaxLength(150)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Cover)
                   .HasColumnName("Cover")
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.PaperType)
                   .HasColumnName("PaperType")
                   .HasMaxLength(20)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.PaperNumber)
                   .HasColumnName("PaperNumber")
                   .HasMaxLength(10)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Poster)
                   .HasColumnName("Poster")
                   .HasMaxLength(150)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.BarcodeNumber)
                   .HasColumnName("BarcodeNumber")
                   .HasMaxLength(20)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.Size)
                   .HasColumnName("Size")
                   .HasMaxLength(12)
                   .IsRequired(); //cannot be blank


            builder.Property(x => x.İssueDate)
                   .HasColumnName("İssueDate")
                   .IsRequired(); //cannot be blank
            builder.Property(x => x.CreatedBookDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.Price)
                   .HasColumnName("Price")
                   .HasMaxLength(10)
                   .IsRequired(); //cannot be blank

            builder.Property(x => x.GenreId)
                   .HasColumnName("GenreId")
                   .HasMaxLength(150)
                   .IsRequired(); //cannot be blank
                

            //builder.Property<BookAuthor>()
            //    .HasOne(ba => ba.Author)
            //    .WithMany(auth => auth.Books)
            //    .HasForeignKey(ba => ba.BookId);

            //data to show when the project is up and running

            builder.HasData(new Book
            {
                Id = 1,
                BookName = "Bu Ülke",
               // AuthorId = 1,
                Publisher = "CONTACT PUBLICATIONS",
                Cover = true,
                PaperType = "FirstPulpPaper",
                PaperNumber =  "339",
                Poster = "https://img.kitapyurdu.com/v1/getImage/fn:10951862/wh:true/wi:220",
                BarcodeNumber = 9789754702811,
                Size = "13 x 19 cm",
                İssueDate = Convert.ToDateTime("16.04.2021"),
                Price = 27,
                CreatedBookDate = DateTime.Now,
                CreatedBookId = 1,
                
                






            });
        }
    }



}
