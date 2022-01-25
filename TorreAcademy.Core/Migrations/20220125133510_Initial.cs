using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorreAcademy.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PublicId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FromMonth = table.Column<string>(nullable: true),
                    ToMonth = table.Column<string>(nullable: true),
                    FromYear = table.Column<string>(nullable: true),
                    ToYear = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    Highlighted = table.Column<bool>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<Guid>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOrganizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    OrganizationId = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOrganizations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    SkillId = table.Column<Guid>(nullable: false),
                    Proficiency = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "PublicId", "Status" },
                values: new object[,]
                {
                    { new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), "Torre", "Torre", 1 },
                    { new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), "AmericanInternationUniversityBangladesh", "American Internation University Bangladesh", 1 },
                    { new Guid("04872838-77e5-442b-9432-5346de7c38c0"), "7 Medical Systems", "7MedicalSystems", 1 },
                    { new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), "Aprosoft", "Aprosoft", 1 },
                    { new Guid("f2b388df-350a-44da-b27a-c674955902ae"), "Brain Station 23", "BrainStation23", 1 },
                    { new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), "Hashkloud", "Hashkloud", 1 },
                    { new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), "Microsoft", "Microsoft", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), "Azure", "Azure", 1 },
                    { new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"), "Ruby", "Ruby", 1 },
                    { new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"), "Vue.js", "Vue.js", 1 },
                    { new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), "Node.js", "Node.js", 1 },
                    { new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), "DevOps", "DevOps", 1 },
                    { new Guid("2f9831e8-7eff-4659-aec5-ddc903135a06"), "Java", "Java", 1 },
                    { new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"), "Back End", "Back End", 1 },
                    { new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"), "ASP.NET", "ASP.NET", 1 },
                    { new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), "React", "React", 1 },
                    { new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), "C#", "C#", 1 },
                    { new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), "Rest API", "Rest API", 1 },
                    { new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), "Full Stack Development", "Full Stack Development", 1 },
                    { new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), "Web Development", "Web Development", 1 },
                    { new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), "Software Development", "Software Development", 1 },
                    { new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"), "JavaScript", "JavaScript", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "Phone", "Status", "UserName" },
                values: new object[,]
                {
                    { new Guid("30095048-1935-44e2-bef9-b450b8e34135"), new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7781), "Martinez@gmail.com", "Alex", "Martinez", "+456456456456", 1, "martinez" },
                    { new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), new DateTime(2022, 1, 25, 19, 35, 10, 356, DateTimeKind.Local).AddTicks(2216), "khabir.aiub@gmail.com", "Muhammad Khabir", "Uddin", "+8801914328355", 1, "khabir" },
                    { new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7698), "Torrenegra@gmail.com", "Alexander", "Torrenegra", "+565464564565", 1, "torrenegra" },
                    { new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), new DateTime(2022, 1, 25, 19, 35, 10, 357, DateTimeKind.Local).AddTicks(7787), "Rex@gmail.com", "Jessie", "Uddin", "+44564564562", 1, "rex" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "AdditionalInfo", "Category", "FromMonth", "FromYear", "Highlighted", "Name", "OrganizationId", "Rank", "Status", "ToMonth", "ToYear", "UserId" },
                values: new object[,]
                {
                    { new Guid("d673ab55-e968-45b5-ab33-598f9f9537d1"), null, 2, "Sep", "2019", true, null, new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 7, 1, "Jul", "2021", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("67cc76b5-2571-455c-aa7c-87f60336a7b2"), null, 2, "Jan", "2018", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, 1, "Jan", "2020", new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("a70971dd-845b-425a-98bf-dd6ee5e23f7d"), null, 2, "Feb", "2020", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 2, 1, "Jul", "2021", new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("efc029e8-b75e-4e6a-847c-348a05f6575e"), null, 2, "Jan", "2010", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, 1, "Mar", "2015", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("734c4986-fdca-4006-a055-f0f4edbc8741"), null, 2, "Apr", "2015", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 2, 1, "Dec", "2018", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("9fca72a8-10f5-42db-86f1-df454657de90"), null, 2, "Jan", "2019", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 3, 1, "Jul", "2021", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("24f96c26-1590-42b9-a97d-25bf60c9a7c8"), null, 2, "Jan", "2005", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 2, 1, "Jul", "2009", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("25486295-fd51-4542-9187-a57bff7b3ca7"), null, 2, "Aug", "2009", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 3, 1, "Dec", "2014", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("f37a4c61-3123-4660-8c7a-ba693bfc2b0e"), null, 2, "Jan", "2015", true, null, new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 4, 1, "Jan", "2022", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("8cd498a9-7f9f-42b2-9177-77fa8797193a"), null, 1, "Jan", "2000", true, null, new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, 1, "Jul", "2004", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("ba436729-d248-45fa-8755-c20d8335b1c9"), null, 1, "Jan", "2007", true, null, new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, 1, "Jul", "2011", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("c54e1acb-f388-414a-98a3-c3fbf512575d"), null, 2, "Dec", "2017", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 6, 1, "Jul", "2019", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("a18be9fb-28ea-4e30-8bbc-c214199d2657"), null, 2, "Aug", "2015", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 5, 1, "Nov", "2017", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("4021a280-9885-403d-955e-1c041db425b9"), null, 2, "Sep", "2011", true, null, new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), 2, 1, "Jul", "2012", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("45ace798-fcec-4c95-bfd0-ffaafd80814d"), null, 2, "Nov", "2013", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 4, 1, "Jul", "2015", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("a4eaa797-0c28-42a0-b3d0-f8bc30ef341d"), null, 2, "Aug", "2012", true, null, new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), 3, 1, "Oct", "2013", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "Id", "OrganizationId", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("4efd764f-b15e-4fb1-9603-c53bf07ce468"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("8df3381e-b33d-4e89-860b-b25fd036162d"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("515d1297-9a92-4fd6-8c17-3f7a807c9ed6"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("2e1c8c3a-e8c2-4df6-b345-bbf08f8b8daf"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("076d7c47-3be2-4aa3-8fb1-ed5be14d5e82"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("5c6fd1ed-0e04-4e3d-80d4-e1060740a5ba"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("f27da8e3-718f-4bdf-bfaf-e2214fe79a1b"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("17d89680-fef6-4793-aa4a-9aa46340adc8"), new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("accc4577-ade3-4293-9404-415623d1ff46"), new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("3e239fe6-a066-4ece-bc91-947fcc28fac7"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("c0718d07-adac-4b9b-97fd-4e7cedaa44d6"), new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("b4667b5c-7f55-4d51-b110-309a6642fcfa"), new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("0368a824-b091-4ea4-bd2e-a62d14802791"), new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("b35113d5-f2c5-4109-8c63-8bd17085360f"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("2e7ff23e-9476-4a55-a13e-a6d8c1166bca"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("20fed92b-bf7f-4096-b8e5-10fe3d235011"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationId",
                table: "UserOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_UserId",
                table: "UserOrganizations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_UserId",
                table: "UserSkills",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "UserOrganizations");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
