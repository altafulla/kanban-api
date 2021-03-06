﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace kanban.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cardlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    userId = table.Column<int>(nullable: true),
                    BoardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cardlists_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cardlists_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CardlistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Cardlists_CardlistId",
                        column: x => x.CardlistId,
                        principalTable: "Cardlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cardlists",
                columns: new[] { "Id", "BoardId", "Deleted", "Description", "IsVisible", "Name", "userId" },
                values: new object[] { 100, null, false, "Demo Cardlist", false, "Cardlist 100", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Deleted", "Name", "Password" },
                values: new object[] { 100, false, "Pedro", "AQAAAAEAACcQAAAAECpMqBSbOCbe+QRJp85XRYcSRpnedd/uP6ZMpaJSGtUOmuRYb/Z5sVTSKyuHsoSPbg==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Deleted", "Name", "Password" },
                values: new object[] { 101, false, "Altafulla", "AQAAAAEAACcQAAAAECpMqBSbOCbe+QRJp85XRYcSRpnedd/uP6ZMpaJSGtUOmuRYb/Z5sVTSKyuHsoSPbg==" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardlistId", "Deleted", "Description", "Name" },
                values: new object[] { 100, 100, false, null, "Card 100" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardlistId", "Deleted", "Description", "Name" },
                values: new object[] { 101, 100, false, null, "Card 101" });

            migrationBuilder.CreateIndex(
                name: "IX_Boards_UserId",
                table: "Boards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cardlists_BoardId",
                table: "Cardlists",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cardlists_userId",
                table: "Cardlists",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardlistId",
                table: "Cards",
                column: "CardlistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Cardlists");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
