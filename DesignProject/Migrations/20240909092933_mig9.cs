using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignProject.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Context",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Context", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "context2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_context2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contextcontext2",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    context2sId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contextcontext2", x => new { x.ChildrenId, x.context2sId });
                    table.ForeignKey(
                        name: "FK_contextcontext2_Context_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Context",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contextcontext2_context2s_context2sId",
                        column: x => x.context2sId,
                        principalTable: "context2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contextcontext2_context2sId",
                table: "contextcontext2",
                column: "context2sId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contextcontext2");

            migrationBuilder.DropTable(
                name: "Context");

            migrationBuilder.DropTable(
                name: "context2s");
        }
    }
}
