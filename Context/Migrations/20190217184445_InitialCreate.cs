using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wex.Context.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Previews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(nullable: false),
                    SourceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Previews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    PreviewId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Previews_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Previews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RedditId = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    CreatedUtc = table.Column<long>(nullable: false),
                    Domain = table.Column<string>(nullable: true),
                    IsMeta = table.Column<bool>(nullable: false),
                    IsSelf = table.Column<bool>(nullable: false),
                    IsVideo = table.Column<bool>(nullable: false),
                    LinkFlairText = table.Column<string>(nullable: true),
                    LinkFlairType = table.Column<string>(nullable: true),
                    Pinned = table.Column<bool>(nullable: false),
                    Stickied = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Permalink = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    SelfText = table.Column<string>(nullable: true),
                    PreviewId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Previews_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Previews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_PreviewId",
                table: "Images",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PreviewId",
                table: "Posts",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Previews_SourceId",
                table: "Previews",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Previews_Images_SourceId",
                table: "Previews",
                column: "SourceId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Previews_PreviewId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Previews");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
