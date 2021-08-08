﻿// <auto-generated />
using System;
using Ecommerce.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.DataAccess.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20210808164643_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasColumnName("Bio");

                    b.Property<DateTime>("CreatedAuthorDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 8, 19, 46, 42, 724, DateTimeKind.Local).AddTicks(7205));

                    b.Property<int>("CreatedAuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Poster");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SurName");

                    b.Property<DateTime?>("UpdatedAuthorDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedAuthorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authors", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Meriç’in “aynı kaynaktan fışkırdılar” dediği eserler dizisinin önemli bir halkası. Bir çağın, bir ülkenin vicdanı olmak isteği Meriç’in bütün çabasına her zaman yön vermiştir: “Bu sayfalarda hayatımın bütünü, yani bütün sevgilerim, bütün kinlerim, bütün tecrübelerim var. Bana öyle geliyor ki, hayat denen mülakata bu kitabı yazmak için geldim; etimin eti, kemiğimin kemiği.” Bu Ülke, Meriç’in sürekli etrafında dolandığı Doğu-Batı sorunu yanında, sol-sağ kutuplaşmasına ve kalıplaşmasına ilişkin önemli tesbit ve aforizmalarını da içeriyor.",
                            CreatedAuthorDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAuthorId = 1,
                            Name = "Cemil",
                            Poster = "https://ia.tmgrup.com.tr/ff6b76/0/0/0/0/0/0?u=https://i.tmgrup.com.tr/fikriyat//album/2018/12/12/1544618723987.jpg&mw=752",
                            Surname = "Meriç"
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BarcodeNumber")
                        .HasMaxLength(20)
                        .HasColumnType("bigint")
                        .HasColumnName("BarcodeNumber");

                    b.Property<int?>("BookAuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("BookName");

                    b.Property<bool>("Cover")
                        .HasColumnType("bit")
                        .HasColumnName("Cover");

                    b.Property<DateTime>("CreatedBookDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 8, 19, 46, 42, 722, DateTimeKind.Local).AddTicks(8012));

                    b.Property<int>("CreatedBookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasMaxLength(150)
                        .HasColumnType("int")
                        .HasColumnName("GenreId");

                    b.Property<string>("PaperNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("PaperNumber");

                    b.Property<string>("PaperType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PaperType");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Poster");

                    b.Property<decimal>("Price")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Publisher");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Size");

                    b.Property<DateTime?>("UpdatedBookDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("İssueDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("İssueDate");

                    b.HasKey("Id");

                    b.HasIndex("BookAuthorId");

                    b.ToTable("Books", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BarcodeNumber = 9789754702811L,
                            BookName = "Bu Ülke",
                            Cover = true,
                            CreatedBookDate = new DateTime(2021, 8, 8, 19, 46, 42, 723, DateTimeKind.Local).AddTicks(7051),
                            CreatedBookId = 1,
                            GenreId = 0,
                            PaperNumber = "339",
                            PaperType = "FirstPulpPaper",
                            Poster = "https://img.kitapyurdu.com/v1/getImage/fn:10951862/wh:true/wi:220",
                            Price = 27m,
                            Publisher = "CONTACT PUBLICATIONS",
                            Size = "13 x 19 cm",
                            İssueDate = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorId");

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookId = 1
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.BookOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookId");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("BookOrders", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("BookId");

                    b.Property<DateTime>("CreatedOrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 8, 19, 46, 42, 736, DateTimeKind.Local).AddTicks(1827));

                    b.Property<int>("CreatedOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("OrderDate");

                    b.Property<DateTime?>("UpdatedOrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedOrderId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("Orders", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedOrderDate = new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOrderId = 1,
                            OrderDate = new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("CreatedUserDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 8, 19, 46, 42, 707, DateTimeKind.Local).AddTicks(3711));

                    b.Property<int>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit")
                        .HasColumnName("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Password");

                    b.Property<bool>("Role")
                        .HasColumnType("bit")
                        .HasColumnName("Role");

                    b.Property<DateTime?>("UpdatedUserDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Hatay/Antakya",
                            CreatedUserDate = new DateTime(2021, 8, 8, 19, 46, 42, 719, DateTimeKind.Local).AddTicks(2577),
                            CreatedUserId = 1,
                            DateOfBirth = new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "busraltunb@gmail.com",
                            FirstName = "Büşra",
                            Gender = true,
                            LastName = "Altun",
                            Password = "12345",
                            Role = false,
                            UserName = "busraltun"
                        });
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Book", b =>
                {
                    b.HasOne("Ecommerce.Entities.Concrete.Author", "BookAuthor")
                        .WithMany()
                        .HasForeignKey("BookAuthorId");

                    b.Navigation("BookAuthor");
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.BookAuthor", b =>
                {
                    b.HasOne("Ecommerce.Entities.Concrete.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Concrete.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.BookOrder", b =>
                {
                    b.HasOne("Ecommerce.Entities.Concrete.Order", "Order")
                        .WithMany("Books")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Concrete.Book", "Book")
                        .WithMany("Orders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Order", b =>
                {
                    b.HasOne("Ecommerce.Entities.Concrete.Book", null)
                        .WithOne("BookOrder")
                        .HasForeignKey("Ecommerce.Entities.Concrete.Order", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Book", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("BookOrder");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce.Entities.Concrete.Order", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
