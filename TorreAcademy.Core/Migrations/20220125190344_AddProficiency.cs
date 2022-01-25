using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorreAcademy.Core.Migrations
{
    public partial class AddProficiency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proficiency",
                table: "UserSkills");

            migrationBuilder.AddColumn<Guid>(
                name: "ProficiencyId",
                table: "UserSkills",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Proficiencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Proficiencies",
                columns: new[] { "Id", "Name", "Order", "Status" },
                values: new object[,]
                {
                    { new Guid("cc82bee1-f49e-4b53-a062-b666e83ad6d6"), "Master / Influencer", 1, 1 },
                    { new Guid("d67b3c14-da66-4ebd-a5f9-6087b33f4649"), "Expert", 2, 1 },
                    { new Guid("55bf6696-fc88-4b9e-a01f-8670d4d627c1"), "Proficient", 3, 1 },
                    { new Guid("ac095f03-1349-48aa-94aa-ab8f23021f30"), "Novice", 4, 1 },
                    { new Guid("6e22f4b3-dedd-40f4-99b1-1a419afb0415"), "No Experience", 5, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30095048-1935-44e2-bef9-b450b8e34135"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 26, 1, 3, 43, 512, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 26, 1, 3, 43, 512, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 26, 1, 3, 43, 510, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 26, 1, 3, 43, 512, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_ProficiencyId",
                table: "UserSkills",
                column: "ProficiencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Proficiencies_ProficiencyId",
                table: "UserSkills",
                column: "ProficiencyId",
                principalTable: "Proficiencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Proficiencies_ProficiencyId",
                table: "UserSkills");

            migrationBuilder.DropTable(
                name: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_ProficiencyId",
                table: "UserSkills");

            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "UserSkills");

            migrationBuilder.AddColumn<int>(
                name: "Proficiency",
                table: "UserSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30095048-1935-44e2-bef9-b450b8e34135"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 25, 19, 35, 10, 356, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"),
                column: "CreatedDate",
                value: new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7698));
        }
    }
}
