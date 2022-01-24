using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorreAcademy.Core.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "PublicId" },
                values: new object[] { new Guid("085b5c6f-5fa5-45f0-a76b-9ede0904311c"), "Torre", "Torre" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("86a7856d-e263-45c5-beec-e511df45ae61"), "Software Development", "Software Development" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "Phone", "UserName" },
                values: new object[,]
                {
                    { new Guid("e1f5e4dd-c883-4ad8-9c76-b15f254a0e45"), new DateTime(2022, 1, 25, 4, 55, 46, 403, DateTimeKind.Local).AddTicks(6502), "khabir.aiub@gmail.com", "Muhammad Khabir", "Uddin", "+8801914328355", "khabir" },
                    { new Guid("80d0da1c-a1fa-4a0b-9ffc-624566addc56"), null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "Id", "Proficiency", "SkillId", "Status", "UserId" },
                values: new object[] { new Guid("a28a70b7-c0ed-43e6-86bc-be78215617ef"), 1, new Guid("86a7856d-e263-45c5-beec-e511df45ae61"), null, new Guid("e1f5e4dd-c883-4ad8-9c76-b15f254a0e45") });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                unique: true,
                filter: "[SkillId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("085b5c6f-5fa5-45f0-a76b-9ede0904311c"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("a28a70b7-c0ed-43e6-86bc-be78215617ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80d0da1c-a1fa-4a0b-9ffc-624566addc56"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("86a7856d-e263-45c5-beec-e511df45ae61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1f5e4dd-c883-4ad8-9c76-b15f254a0e45"));
        }
    }
}
