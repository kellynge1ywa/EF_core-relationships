using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Many_to_Many.Migrations
{
    /// <inheritdoc />
    public partial class Many_To_Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAuthors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Mbooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mbooks", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorsBooks",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    M_AuthorsAuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorsBooks", x => new { x.BooksBookId, x.M_AuthorsAuthorId });
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_MAuthors_M_AuthorsAuthorId",
                        column: x => x.M_AuthorsAuthorId,
                        principalTable: "MAuthors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_Mbooks_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Mbooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsBooks_M_AuthorsAuthorId",
                table: "AuthorsBooks",
                column: "M_AuthorsAuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsBooks");

            migrationBuilder.DropTable(
                name: "MAuthors");

            migrationBuilder.DropTable(
                name: "Mbooks");
        }
    }
}
