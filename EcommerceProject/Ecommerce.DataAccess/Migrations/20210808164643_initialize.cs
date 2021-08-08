using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Authors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAuthorDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 8, 8, 19, 46, 42, 724, DateTimeKind.Local).AddTicks(7205)),
                    UpdatedAuthorId = table.Column<int>(type: "int", nullable: true),
                    UpdatedAuthorDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Role = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 8, 8, 19, 46, 42, 707, DateTimeKind.Local).AddTicks(3711)),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cover = table.Column<bool>(type: "bit", nullable: false),
                    PaperType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PaperNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BarcodeNumber = table.Column<long>(type: "bigint", maxLength: 20, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    İssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    GenreId = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    BookAuthorId = table.Column<int>(type: "int", nullable: true),
                    CreatedBookId = table.Column<int>(type: "int", nullable: false),
                    CreatedBookDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 8, 8, 19, 46, 42, 722, DateTimeKind.Local).AddTicks(8012)),
                    UpdatedBookId = table.Column<int>(type: "int", nullable: true),
                    UpdatedBookDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_BookAuthorId",
                        column: x => x.BookAuthorId,
                        principalSchema: "dbo",
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "dbo",
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "dbo",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    BookId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 8, 8, 19, 46, 42, 736, DateTimeKind.Local).AddTicks(1827)),
                    UpdatedOrderId = table.Column<int>(type: "int", nullable: true),
                    UpdatedOrderDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalSchema: "dbo",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookOrders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookOrders_Books_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "dbo",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrders_Orders_BookId",
                        column: x => x.BookId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedAuthorId", "Name", "Poster", "SurName", "UpdatedAuthorDate", "UpdatedAuthorId" },
                values: new object[] { 1, "Meriç’in “aynı kaynaktan fışkırdılar” dediği eserler dizisinin önemli bir halkası. Bir çağın, bir ülkenin vicdanı olmak isteği Meriç’in bütün çabasına her zaman yön vermiştir: “Bu sayfalarda hayatımın bütünü, yani bütün sevgilerim, bütün kinlerim, bütün tecrübelerim var. Bana öyle geliyor ki, hayat denen mülakata bu kitabı yazmak için geldim; etimin eti, kemiğimin kemiği.” Bu Ülke, Meriç’in sürekli etrafında dolandığı Doğu-Batı sorunu yanında, sol-sağ kutuplaşmasına ve kalıplaşmasına ilişkin önemli tesbit ve aforizmalarını da içeriyor.", 1, "Cemil", "https://ia.tmgrup.com.tr/ff6b76/0/0/0/0/0/0?u=https://i.tmgrup.com.tr/fikriyat//album/2018/12/12/1544618723987.jpg&mw=752", "Meriç", null, null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Books",
                columns: new[] { "Id", "BarcodeNumber", "BookAuthorId", "BookName", "Cover", "CreatedBookDate", "CreatedBookId", "GenreId", "PaperNumber", "PaperType", "Poster", "Price", "Publisher", "Size", "UpdatedBookDate", "UpdatedBookId", "İssueDate" },
                values: new object[] { 1, 9789754702811L, null, "Bu Ülke", true, new DateTime(2021, 8, 8, 19, 46, 42, 723, DateTimeKind.Local).AddTicks(7051), 1, 0, "339", "FirstPulpPaper", "https://img.kitapyurdu.com/v1/getImage/fn:10951862/wh:true/wi:220", 27m, "CONTACT PUBLICATIONS", "13 x 19 cm", null, null, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedUserDate", "CreatedUserId", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Password", "Role", "UpdatedUserDate", "UpdatedUserId", "UserName" },
                values: new object[] { 1, "Hatay/Antakya", new DateTime(2021, 8, 8, 19, 46, 42, 719, DateTimeKind.Local).AddTicks(2577), 1, new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "busraltunb@gmail.com", "Büşra", true, "Altun", "12345", false, null, null, "busraltun" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BookAuthors",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Orders",
                columns: new[] { "Id", "BookId", "CreatedOrderDate", "CreatedOrderId", "OrderDate", "UpdatedOrderDate", "UpdatedOrderId", "UserId" },
                values: new object[] { 1, 1, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BookOrders",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                schema: "dbo",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                schema: "dbo",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrders_BookId",
                schema: "dbo",
                table: "BookOrders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrders_OrderId",
                schema: "dbo",
                table: "BookOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookAuthorId",
                schema: "dbo",
                table: "Books",
                column: "BookAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                schema: "dbo",
                table: "Orders",
                column: "BookId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookOrders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Authors",
                schema: "dbo");
        }
    }
}
