using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorreAcademy.Core.Migrations
{
    public partial class AddMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "UserSkills",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Organizations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Experiences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Experiences",
                nullable: false,
                defaultValue: 0);

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
                    { new Guid("30095048-1935-44e2-bef9-b450b8e34135"), new DateTime(2022, 1, 25, 16, 25, 21, 606, DateTimeKind.Local).AddTicks(1254), "Martinez@gmail.com", "Alex", "Martinez", "+456456456456", 1, "martinez" },
                    { new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), new DateTime(2022, 1, 25, 16, 25, 21, 605, DateTimeKind.Local).AddTicks(514), "khabir.aiub@gmail.com", "Muhammad Khabir", "Uddin", "+8801914328355", 1, "khabir" },
                    { new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), new DateTime(2022, 1, 25, 16, 25, 21, 606, DateTimeKind.Local).AddTicks(1207), "Torrenegra@gmail.com", "Alexander", "Torrenegra", "+565464564565", 1, "torrenegra" },
                    { new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), new DateTime(2022, 1, 25, 16, 25, 21, 606, DateTimeKind.Local).AddTicks(1259), "Rex@gmail.com", "Jessie", "Uddin", "+44564564562", 1, "rex" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "AdditionalInfo", "Category", "FromMonth", "FromYear", "Highlighted", "Name", "OrganizationId", "Rank", "Status", "ToMonth", "ToYear", "UserId" },
                values: new object[,]
                {
                    { new Guid("d673ab55-e968-45b5-ab33-598f9f9537d1"), null, 2, "Sep", "2019", true, null, new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 7, 1, "Jul", "2021", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("25486295-fd51-4542-9187-a57bff7b3ca7"), null, 2, "Aug", "2009", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 3, 1, "Dec", "2014", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("24f96c26-1590-42b9-a97d-25bf60c9a7c8"), null, 2, "Jan", "2005", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 2, 1, "Jul", "2009", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("9fca72a8-10f5-42db-86f1-df454657de90"), null, 2, "Jan", "2019", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 3, 1, "Jul", "2021", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("734c4986-fdca-4006-a055-f0f4edbc8741"), null, 2, "Apr", "2015", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 2, 1, "Dec", "2018", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("efc029e8-b75e-4e6a-847c-348a05f6575e"), null, 2, "Jan", "2010", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, 1, "Mar", "2015", new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("8cd498a9-7f9f-42b2-9177-77fa8797193a"), null, 1, "Jan", "2000", true, null, new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, 1, "Jul", "2004", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("a70971dd-845b-425a-98bf-dd6ee5e23f7d"), null, 2, "Feb", "2020", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 2, 1, "Jul", "2021", new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("67cc76b5-2571-455c-aa7c-87f60336a7b2"), null, 2, "Jan", "2018", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, 1, "Jan", "2020", new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("f37a4c61-3123-4660-8c7a-ba693bfc2b0e"), null, 2, "Jan", "2015", true, null, new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 4, 1, "Jan", "2022", new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("4021a280-9885-403d-955e-1c041db425b9"), null, 2, "Sep", "2011", true, null, new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), 2, 1, "Jul", "2012", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("a4eaa797-0c28-42a0-b3d0-f8bc30ef341d"), null, 2, "Aug", "2012", true, null, new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), 3, 1, "Oct", "2013", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("45ace798-fcec-4c95-bfd0-ffaafd80814d"), null, 2, "Nov", "2013", true, null, new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 4, 1, "Jul", "2015", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("a18be9fb-28ea-4e30-8bbc-c214199d2657"), null, 2, "Aug", "2015", true, null, new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 5, 1, "Nov", "2017", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("c54e1acb-f388-414a-98a3-c3fbf512575d"), null, 2, "Dec", "2017", true, null, new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 6, 1, "Jul", "2019", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("ba436729-d248-45fa-8755-c20d8335b1c9"), null, 1, "Jan", "2007", true, null, new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, 1, "Jul", "2011", new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "Id", "OrganizationId", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("20fed92b-bf7f-4096-b8e5-10fe3d235011"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("515d1297-9a92-4fd6-8c17-3f7a807c9ed6"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("2e1c8c3a-e8c2-4df6-b345-bbf08f8b8daf"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("076d7c47-3be2-4aa3-8fb1-ed5be14d5e82"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("f27da8e3-718f-4bdf-bfaf-e2214fe79a1b"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("17d89680-fef6-4793-aa4a-9aa46340adc8"), new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("3e239fe6-a066-4ece-bc91-947fcc28fac7"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("8df3381e-b33d-4e89-860b-b25fd036162d"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("5c6fd1ed-0e04-4e3d-80d4-e1060740a5ba"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("b4667b5c-7f55-4d51-b110-309a6642fcfa"), new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("0368a824-b091-4ea4-bd2e-a62d14802791"), new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("accc4577-ade3-4293-9404-415623d1ff46"), new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("c0718d07-adac-4b9b-97fd-4e7cedaa44d6"), new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("2e7ff23e-9476-4a55-a13e-a6d8c1166bca"), new Guid("04872838-77e5-442b-9432-5346de7c38c0"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("4efd764f-b15e-4fb1-9603-c53bf07ce468"), new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("b35113d5-f2c5-4109-8c63-8bd17085360f"), new Guid("f2b388df-350a-44da-b27a-c674955902ae"), 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "Id", "Proficiency", "SkillId", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("445a962c-8284-4ded-8929-3d5f851496f4"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("e50dd2c7-4f49-4976-86fa-86932742b996"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("d6808ca1-11e0-4b33-b0d6-20ab5d76318d"), 1, null, 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("6671c34f-1467-4e16-8ca3-e9c118e74148"), 1, null, 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("d4cc59ec-6edb-47f3-8dad-ae7aac97f5dd"), 1, new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("82cd0811-3e2c-44e6-8911-7f2e0f0d3119"), 1, new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("ea549560-6e86-4b37-adfc-8d81576add14"), 1, new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("912ea50b-a487-4e0d-866a-d4d77a07f00e"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("7f7d41bb-2c61-4508-99dc-9739643d32ff"), 1, new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("5f8375a7-11c9-41a1-9efa-9023e5066836"), 1, new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("7447e741-30d5-4067-9086-5f545dc528f9"), 1, new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("284a8584-d011-4327-9053-f33bf79abac9"), 1, new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("3c2d4c16-6c44-4c3c-89fc-77ec96014d52"), 1, new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("47fedd01-8cde-4244-bd46-ff593fbe1788"), 1, new Guid("2f9831e8-7eff-4659-aec5-ddc903135a06"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("34d37e90-9772-4c2f-be8e-11ba983b7d1a"), 1, new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), 1, new Guid("30095048-1935-44e2-bef9-b450b8e34135") },
                    { new Guid("53228fdd-336e-464c-849d-fcb409d8cb04"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("c6f91676-e32d-4302-ab28-5ec92ce19bf8"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("763ff707-2dd3-45eb-9e09-0753e5b8a829"), 1, new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("1d0b6b3e-be6a-413c-80d5-9630b3e55f5a"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("bc9649ec-e639-4f88-b68d-b1ff3ae3a35e"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("fb8c4bfc-48c0-4ee3-bfd1-38bda0c2eccd"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("988343f2-1d55-4249-b484-e1aaba04e84f"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("81f2a23f-0ab4-46e2-a389-a42202892817"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("86b9ee6a-ce3c-4047-b5cf-c794f347b917"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("d36e9de1-2dd8-4b09-861a-80bebb73be25"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("66570d6a-15ae-4e32-b0ff-000e5788a3a8"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("803ad574-1417-4fe4-bd31-54c63ba9eca1"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("7bee2d52-e5f9-4db4-be75-f0d53a7e181f"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("9c9832c1-6c2e-4fb1-a233-837e2ebc1084"), 1, new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") },
                    { new Guid("b5467767-51ae-4f0c-8225-bb454654ccbb"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("4e936507-d7d7-4105-9c7a-30a6517d8c14"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("3245ee35-f529-4a4d-bb5d-1881c14b9139"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("85aedcb0-5d83-4a03-b7ad-69b2f9abafe3"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("df4c2ad4-6898-456e-9dfe-5d30262138d7"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("24025fff-dc2d-4159-872a-e3861d917cbc"), 1, new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("d0d16f74-3443-4713-b837-28b8277eff0e"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("3a8393ac-e689-46c9-b5e0-94e8ab95f245"), 1, new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"), 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("f14666fe-ebd9-4ee1-9167-ee827d3e44e2"), 1, null, 1, new Guid("50f9ee73-8522-4303-8422-957fa1537bc4") },
                    { new Guid("d23c451c-8c90-40b5-be27-c775bf4dbb53"), 1, null, 1, new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748") },
                    { new Guid("ef959467-b2c1-44fe-8b73-3ba74024b860"), 1, new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"), 1, new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("24f96c26-1590-42b9-a97d-25bf60c9a7c8"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("25486295-fd51-4542-9187-a57bff7b3ca7"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("4021a280-9885-403d-955e-1c041db425b9"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("45ace798-fcec-4c95-bfd0-ffaafd80814d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("67cc76b5-2571-455c-aa7c-87f60336a7b2"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("734c4986-fdca-4006-a055-f0f4edbc8741"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("8cd498a9-7f9f-42b2-9177-77fa8797193a"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("9fca72a8-10f5-42db-86f1-df454657de90"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("a18be9fb-28ea-4e30-8bbc-c214199d2657"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("a4eaa797-0c28-42a0-b3d0-f8bc30ef341d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("a70971dd-845b-425a-98bf-dd6ee5e23f7d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("ba436729-d248-45fa-8755-c20d8335b1c9"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("c54e1acb-f388-414a-98a3-c3fbf512575d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("d673ab55-e968-45b5-ab33-598f9f9537d1"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("efc029e8-b75e-4e6a-847c-348a05f6575e"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("f37a4c61-3123-4660-8c7a-ba693bfc2b0e"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("0368a824-b091-4ea4-bd2e-a62d14802791"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("076d7c47-3be2-4aa3-8fb1-ed5be14d5e82"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("17d89680-fef6-4793-aa4a-9aa46340adc8"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("20fed92b-bf7f-4096-b8e5-10fe3d235011"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("2e1c8c3a-e8c2-4df6-b345-bbf08f8b8daf"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("2e7ff23e-9476-4a55-a13e-a6d8c1166bca"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("3e239fe6-a066-4ece-bc91-947fcc28fac7"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("4efd764f-b15e-4fb1-9603-c53bf07ce468"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("515d1297-9a92-4fd6-8c17-3f7a807c9ed6"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("5c6fd1ed-0e04-4e3d-80d4-e1060740a5ba"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("8df3381e-b33d-4e89-860b-b25fd036162d"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("accc4577-ade3-4293-9404-415623d1ff46"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("b35113d5-f2c5-4109-8c63-8bd17085360f"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("b4667b5c-7f55-4d51-b110-309a6642fcfa"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("c0718d07-adac-4b9b-97fd-4e7cedaa44d6"));

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumn: "Id",
                keyValue: new Guid("f27da8e3-718f-4bdf-bfaf-e2214fe79a1b"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("1d0b6b3e-be6a-413c-80d5-9630b3e55f5a"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("24025fff-dc2d-4159-872a-e3861d917cbc"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("284a8584-d011-4327-9053-f33bf79abac9"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("3245ee35-f529-4a4d-bb5d-1881c14b9139"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("34d37e90-9772-4c2f-be8e-11ba983b7d1a"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("3a8393ac-e689-46c9-b5e0-94e8ab95f245"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("3c2d4c16-6c44-4c3c-89fc-77ec96014d52"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("445a962c-8284-4ded-8929-3d5f851496f4"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("47fedd01-8cde-4244-bd46-ff593fbe1788"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("4e936507-d7d7-4105-9c7a-30a6517d8c14"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("53228fdd-336e-464c-849d-fcb409d8cb04"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("5f8375a7-11c9-41a1-9efa-9023e5066836"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("66570d6a-15ae-4e32-b0ff-000e5788a3a8"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("6671c34f-1467-4e16-8ca3-e9c118e74148"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("7447e741-30d5-4067-9086-5f545dc528f9"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("763ff707-2dd3-45eb-9e09-0753e5b8a829"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("7bee2d52-e5f9-4db4-be75-f0d53a7e181f"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("7f7d41bb-2c61-4508-99dc-9739643d32ff"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("803ad574-1417-4fe4-bd31-54c63ba9eca1"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("81f2a23f-0ab4-46e2-a389-a42202892817"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("82cd0811-3e2c-44e6-8911-7f2e0f0d3119"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("85aedcb0-5d83-4a03-b7ad-69b2f9abafe3"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("86b9ee6a-ce3c-4047-b5cf-c794f347b917"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("912ea50b-a487-4e0d-866a-d4d77a07f00e"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("988343f2-1d55-4249-b484-e1aaba04e84f"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("9c9832c1-6c2e-4fb1-a233-837e2ebc1084"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("b5467767-51ae-4f0c-8225-bb454654ccbb"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("bc9649ec-e639-4f88-b68d-b1ff3ae3a35e"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("c6f91676-e32d-4302-ab28-5ec92ce19bf8"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("d0d16f74-3443-4713-b837-28b8277eff0e"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("d23c451c-8c90-40b5-be27-c775bf4dbb53"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("d36e9de1-2dd8-4b09-861a-80bebb73be25"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("d4cc59ec-6edb-47f3-8dad-ae7aac97f5dd"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("d6808ca1-11e0-4b33-b0d6-20ab5d76318d"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("df4c2ad4-6898-456e-9dfe-5d30262138d7"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("e50dd2c7-4f49-4976-86fa-86932742b996"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("ea549560-6e86-4b37-adfc-8d81576add14"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("ef959467-b2c1-44fe-8b73-3ba74024b860"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("f14666fe-ebd9-4ee1-9167-ee827d3e44e2"));

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: new Guid("fb8c4bfc-48c0-4ee3-bfd1-38bda0c2eccd"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("04872838-77e5-442b-9432-5346de7c38c0"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("c1bf1539-a695-4722-ad97-47529029fe96"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("f2b388df-350a-44da-b27a-c674955902ae"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2f9831e8-7eff-4659-aec5-ddc903135a06"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30095048-1935-44e2-bef9-b450b8e34135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Experiences");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "UserSkills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

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
        }
    }
}
