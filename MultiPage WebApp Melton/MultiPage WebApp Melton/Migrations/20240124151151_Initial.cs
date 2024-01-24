using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiPage_WebApp_Melton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Number" },
                values: new object[] { 1, "123 Fake Street", "Bob", "Co-worker", 1234567890L });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Number" },
                values: new object[] { 2, "111 Maple Drive", "Sarah", "A", 987654321L });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Number" },
                values: new object[] { 3, "222 Sunset Lane", "Tom", "Tailor", 1032547698L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
