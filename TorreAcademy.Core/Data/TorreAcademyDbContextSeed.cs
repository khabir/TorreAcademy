using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TorreAcademy.Core.Entities;

namespace TorreAcademy.Core.Data
{
    public static class TorreAcademyDbContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedUser(modelBuilder);
            SeedSkill(modelBuilder);
            //SeedUserSkill(modelBuilder);
            SeedUserExperience(modelBuilder);
            SeedOrganization(modelBuilder);
            SeedUserOrganization(modelBuilder);
            SeedProficiency(modelBuilder);
        }

        private static void SeedProficiency(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proficiency>().HasData(
                new Proficiency { Id = new Guid("cc82bee1-f49e-4b53-a062-b666e83ad6d6"), Name = "Master / Influencer", Status = Enum.Status.Active, Order = 1 },
                new Proficiency { Id = new Guid("d67b3c14-da66-4ebd-a5f9-6087b33f4649"), Name = "Expert", Status = Enum.Status.Active, Order = 2 },
                new Proficiency { Id = new Guid("55bf6696-fc88-4b9e-a01f-8670d4d627c1"), Name = "Proficient", Status = Enum.Status.Active, Order = 3 },
                new Proficiency { Id = new Guid("ac095f03-1349-48aa-94aa-ab8f23021f30"), Name = "Novice", Status = Enum.Status.Active, Order = 4 },
                new Proficiency { Id = new Guid("6e22f4b3-dedd-40f4-99b1-1a419afb0415"), Name = "No Experience", Status = Enum.Status.Active, Order = 5 }
            );
        }

        private static void SeedUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), FirstName = "Muhammad Khabir", LastName = "Uddin", Email = "khabir.aiub@gmail.com", CreatedDate = DateTime.Now, Phone = "+8801914328355", UserName = "khabir", Status = Enum.Status.Active },
                new User { Id = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), FirstName = "Alexander", LastName = "Torrenegra", Email = "Torrenegra@gmail.com", CreatedDate = DateTime.Now, Phone = "+565464564565", UserName = "torrenegra", Status = Enum.Status.Active },
                new User { Id = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), FirstName = "Alex", LastName = "Martinez", Email = "Martinez@gmail.com", CreatedDate = DateTime.Now, Phone = "+456456456456", UserName = "martinez", Status = Enum.Status.Active },
                new User { Id = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), FirstName = "Jessie", LastName = "Uddin", Email = "Rex@gmail.com", CreatedDate = DateTime.Now, Phone = "+44564564562", UserName = "rex", Status = Enum.Status.Active }
            );
        }

        private static void SeedSkill(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), Name = "Software Development", Description = "Software Development", Status = Enum.Status.Active },
                new Skill { Id = new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), Name = "Web Development", Description = "Web Development", Status = Enum.Status.Active },
                new Skill { Id = new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), Name = "Full Stack Development", Description = "Full Stack Development", Status = Enum.Status.Active },
                new Skill { Id = new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), Name = "Rest API", Description = "Rest API", Status = Enum.Status.Active },
                new Skill { Id = new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), Name = "C#", Description = "C#", Status = Enum.Status.Active },
                new Skill { Id = new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"), Name = "ASP.NET", Description = "ASP.NET", Status = Enum.Status.Active },
                new Skill { Id = new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), Name = "React", Description = "React", Status = Enum.Status.Active },
                new Skill { Id = new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"), Name = "JavaScript", Description = "JavaScript", Status = Enum.Status.Active },
                new Skill { Id = new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"), Name = "Back End", Description = "Back End", Status = Enum.Status.Active },
                new Skill { Id = new Guid("2f9831e8-7eff-4659-aec5-ddc903135a06"), Name = "Java", Description = "Java", Status = Enum.Status.Active },
                new Skill { Id = new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), Name = "DevOps", Description = "DevOps", Status = Enum.Status.Active },
                new Skill { Id = new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), Name = "Node.js", Description = "Node.js", Status = Enum.Status.Active },
                new Skill { Id = new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"), Name = "Vue.js", Description = "Vue.js", Status = Enum.Status.Active },
                new Skill { Id = new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"), Name = "Ruby", Description = "Ruby", Status = Enum.Status.Active },
                new Skill { Id = new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), Name = "Azure", Description = "Azure", Status = Enum.Status.Active }
            );
        }

        private static void SeedOrganization(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().HasData(
                new Organization { Id = new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), Name = "Torre", PublicId = "Torre", Status = Enum.Status.Active },
                new Organization { Id = new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), Name = "AmericanInternationUniversityBangladesh", PublicId = "American Internation University Bangladesh", Status = Enum.Status.Active },
                new Organization { Id = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), Name = "7 Medical Systems", PublicId = "7MedicalSystems", Status = Enum.Status.Active },
                new Organization { Id = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), Name = "Aprosoft", PublicId = "Aprosoft", Status = Enum.Status.Active },
                new Organization { Id = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), Name = "Brain Station 23", PublicId = "BrainStation23", Status = Enum.Status.Active },
                new Organization { Id = new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), Name = "Hashkloud", PublicId = "Hashkloud", Status = Enum.Status.Active },
                new Organization { Id = new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), Name = "Microsoft", PublicId = "Microsoft", Status = Enum.Status.Active }
            );
        }
        //private static void SeedUserSkill(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserSkill>().HasData(
        //        new UserSkill { Id = new Guid("e50dd2c7-4f49-4976-86fa-86932742b996"), Proficiency = 1, SkillId = new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("b5467767-51ae-4f0c-8225-bb454654ccbb"), Proficiency = 1, SkillId = new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("d6808ca1-11e0-4b33-b0d6-20ab5d76318d"), Proficiency = 1, SkillId = new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("284a8584-d011-4327-9053-f33bf79abac9"), Proficiency = 1, SkillId = new Guid("750ee1f7-4658-433c-8002-fd83c2c16732"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("912ea50b-a487-4e0d-866a-d4d77a07f00e"), Proficiency = 1, SkillId = new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("4e936507-d7d7-4105-9c7a-30a6517d8c14"), Proficiency = 1, SkillId = new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("6671c34f-1467-4e16-8ca3-e9c118e74148"), Proficiency = 1, SkillId = new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("3c2d4c16-6c44-4c3c-89fc-77ec96014d52"), Proficiency = 1, SkillId = new Guid("65cd41a7-6b3b-4c05-9fcc-3ca364b2b841"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("c6f91676-e32d-4302-ab28-5ec92ce19bf8"), Proficiency = 1, SkillId = new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("3245ee35-f529-4a4d-bb5d-1881c14b9139"), Proficiency = 1, SkillId = new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("d4cc59ec-6edb-47f3-8dad-ae7aac97f5dd"), Proficiency = 1, SkillId = new Guid("c09d1c06-41fb-48ae-8c76-70f66edc8804"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("d23c451c-8c90-40b5-be27-c775bf4dbb53"), Proficiency = 1, SkillId = new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("85aedcb0-5d83-4a03-b7ad-69b2f9abafe3"), Proficiency = 1, SkillId = new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("82cd0811-3e2c-44e6-8911-7f2e0f0d3119"), Proficiency = 1, SkillId = new Guid("eab66851-38a4-4f05-b9eb-4727950145e6"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("803ad574-1417-4fe4-bd31-54c63ba9eca1"), Proficiency = 1, SkillId = new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("df4c2ad4-6898-456e-9dfe-5d30262138d7"), Proficiency = 1, SkillId = new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("34d37e90-9772-4c2f-be8e-11ba983b7d1a"), Proficiency = 1, SkillId = new Guid("78335ce5-1e40-4f27-bb6f-136de91d523b"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("66570d6a-15ae-4e32-b0ff-000e5788a3a8"), Proficiency = 1, SkillId = new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("24025fff-dc2d-4159-872a-e3861d917cbc"), Proficiency = 1, SkillId = new Guid("95a0cd63-9bcd-4e18-8ac5-a96a3b6e5cb5"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("d36e9de1-2dd8-4b09-861a-80bebb73be25"), Proficiency = 1, SkillId = new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("d0d16f74-3443-4713-b837-28b8277eff0e"), Proficiency = 1, SkillId = new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("ea549560-6e86-4b37-adfc-8d81576add14"), Proficiency = 1, SkillId = new Guid("d1a7df8f-f94b-449f-86ae-246c3d1bd6e8"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("86b9ee6a-ce3c-4047-b5cf-c794f347b917"), Proficiency = 1, SkillId = new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("7f7d41bb-2c61-4508-99dc-9739643d32ff"), Proficiency = 1, SkillId = new Guid("3d9331b5-40cd-47cb-885a-02d3653ee50c"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("81f2a23f-0ab4-46e2-a389-a42202892817"), Proficiency = 1, SkillId = new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("3a8393ac-e689-46c9-b5e0-94e8ab95f245"), Proficiency = 1, SkillId = new Guid("3d652a05-25a9-4d81-84f6-43237170db0c"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("988343f2-1d55-4249-b484-e1aaba04e84f"), Proficiency = 1, SkillId = new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("47fedd01-8cde-4244-bd46-ff593fbe1788"), Proficiency = 1, SkillId = new Guid("2f9831e8-7eff-4659-aec5-ddc903135a06"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("53228fdd-336e-464c-849d-fcb409d8cb04"), Proficiency = 1, SkillId = new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("9c9832c1-6c2e-4fb1-a233-837e2ebc1084"), Proficiency = 1, SkillId = new Guid("fbb42887-8c85-4e15-b40f-7f14579be6e6"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("445a962c-8284-4ded-8929-3d5f851496f4"), Proficiency = 1, SkillId = new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("f14666fe-ebd9-4ee1-9167-ee827d3e44e2"), Proficiency = 1, SkillId = new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("5f8375a7-11c9-41a1-9efa-9023e5066836"), Proficiency = 1, SkillId = new Guid("9d21ad81-dd79-4cfe-8029-99658ce8488d"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("1d0b6b3e-be6a-413c-80d5-9630b3e55f5a"), Proficiency = 1, SkillId = new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("763ff707-2dd3-45eb-9e09-0753e5b8a829"), Proficiency = 1, SkillId = new Guid("6e66fb3d-d540-459b-b3c3-7d9ad834588e"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("bc9649ec-e639-4f88-b68d-b1ff3ae3a35e"), Proficiency = 1, SkillId = new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("ef959467-b2c1-44fe-8b73-3ba74024b860"), Proficiency = 1, SkillId = new Guid("e98253b2-2ae3-477c-8841-344fe706ac1b"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), Status = Enum.Status.Active },

        //        new UserSkill { Id = new Guid("fb8c4bfc-48c0-4ee3-bfd1-38bda0c2eccd"), Proficiency = 1, SkillId = new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("7bee2d52-e5f9-4db4-be75-f0d53a7e181f"), Proficiency = 1, SkillId = new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), Status = Enum.Status.Active },
        //        new UserSkill { Id = new Guid("7447e741-30d5-4067-9086-5f545dc528f9"), Proficiency = 1, SkillId = new Guid("0eebe5e0-04c8-4eea-9d93-ef75bba84686"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), Status = Enum.Status.Active }
        //    );
        //}
        private static void SeedUserOrganization(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOrganization>().HasData(
                new UserOrganization { Id = new Guid("accc4577-ade3-4293-9404-415623d1ff46"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("c0718d07-adac-4b9b-97fd-4e7cedaa44d6"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), Status = Enum.Status.Active }, //aiub
                new UserOrganization { Id = new Guid("2e7ff23e-9476-4a55-a13e-a6d8c1166bca"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("4efd764f-b15e-4fb1-9603-c53bf07ce468"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("b35113d5-f2c5-4109-8c63-8bd17085360f"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("0368a824-b091-4ea4-bd2e-a62d14802791"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("b4667b5c-7f55-4d51-b110-309a6642fcfa"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), Status = Enum.Status.Active },

                new UserOrganization { Id = new Guid("17d89680-fef6-4793-aa4a-9aa46340adc8"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("f27da8e3-718f-4bdf-bfaf-e2214fe79a1b"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("5c6fd1ed-0e04-4e3d-80d4-e1060740a5ba"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("076d7c47-3be2-4aa3-8fb1-ed5be14d5e82"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), Status = Enum.Status.Active },

                new UserOrganization { Id = new Guid("2e1c8c3a-e8c2-4df6-b345-bbf08f8b8daf"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("515d1297-9a92-4fd6-8c17-3f7a807c9ed6"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("8df3381e-b33d-4e89-860b-b25fd036162d"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), Status = Enum.Status.Active },

                new UserOrganization { Id = new Guid("3e239fe6-a066-4ece-bc91-947fcc28fac7"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), Status = Enum.Status.Active },
                new UserOrganization { Id = new Guid("20fed92b-bf7f-4096-b8e5-10fe3d235011"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), Status = Enum.Status.Active }
            );
        }

        private static void SeedUserExperience(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().HasData(
                new Experience { Id = new Guid("d673ab55-e968-45b5-ab33-598f9f9537d1"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), FromYear = "2019", FromMonth = "Sep", ToYear = "2021", ToMonth = "Jul", Rank = 7, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("ba436729-d248-45fa-8755-c20d8335b1c9"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), FromYear = "2007", FromMonth = "Jan", ToYear = "2011", ToMonth = "Jul", Rank = 1, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Education }, //aiub
                new Experience { Id = new Guid("c54e1acb-f388-414a-98a3-c3fbf512575d"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), FromYear = "2017", FromMonth = "Dec", ToYear = "2019", ToMonth = "Jul", Rank = 6, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("a18be9fb-28ea-4e30-8bbc-c214199d2657"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), FromYear = "2015", FromMonth = "Aug", ToYear = "2017", ToMonth = "Nov", Rank = 5, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("45ace798-fcec-4c95-bfd0-ffaafd80814d"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), FromYear = "2013", FromMonth = "Nov", ToYear = "2015", ToMonth = "Jul", Rank = 4, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("a4eaa797-0c28-42a0-b3d0-f8bc30ef341d"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("53fd3177-8954-434e-a41d-e93ee8962c6e"), FromYear = "2012", FromMonth = "Aug", ToYear = "2013", ToMonth = "Oct", Rank = 3, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("4021a280-9885-403d-955e-1c041db425b9"), UserId = new Guid("407fcd19-a1be-4dd4-b28c-cd6a7da11748"), OrganizationId = new Guid("c1bf1539-a695-4722-ad97-47529029fe96"), FromYear = "2011", FromMonth = "Sep", ToYear = "2012", ToMonth = "Jul", Rank = 2, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },

                new Experience { Id = new Guid("f37a4c61-3123-4660-8c7a-ba693bfc2b0e"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("e5b5d7d2-02f6-4ebf-9523-d8bf8e42eb9f"), FromYear = "2015", FromMonth = "Jan", ToYear = "2022", ToMonth = "Jan", Rank = 4, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("8cd498a9-7f9f-42b2-9177-77fa8797193a"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("c438aeba-7757-46f0-aae0-205bec5b7fe5"), FromYear = "2000", FromMonth = "Jan", ToYear = "2004", ToMonth = "Jul", Rank = 1, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Education },
                new Experience { Id = new Guid("25486295-fd51-4542-9187-a57bff7b3ca7"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), FromYear = "2009", FromMonth = "Aug", ToYear = "2014", ToMonth = "Dec", Rank = 3, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("24f96c26-1590-42b9-a97d-25bf60c9a7c8"), UserId = new Guid("50f9ee73-8522-4303-8422-957fa1537bc4"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), FromYear = "2005", FromMonth = "Jan", ToYear = "2009", ToMonth = "Jul", Rank = 2, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },

                new Experience { Id = new Guid("9fca72a8-10f5-42db-86f1-df454657de90"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), FromYear = "2019", FromMonth = "Jan", ToYear = "2021", ToMonth = "Jul", Rank = 3, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("734c4986-fdca-4006-a055-f0f4edbc8741"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), FromYear = "2015", FromMonth = "Apr", ToYear = "2018", ToMonth = "Dec", Rank = 2, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("efc029e8-b75e-4e6a-847c-348a05f6575e"), UserId = new Guid("30095048-1935-44e2-bef9-b450b8e34135"), OrganizationId = new Guid("f2b388df-350a-44da-b27a-c674955902ae"), FromYear = "2010", FromMonth = "Jan", ToYear = "2015", ToMonth = "Mar", Rank = 1, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },

                new Experience { Id = new Guid("a70971dd-845b-425a-98bf-dd6ee5e23f7d"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), OrganizationId = new Guid("04872838-77e5-442b-9432-5346de7c38c0"), FromYear = "2020", FromMonth = "Feb", ToYear = "2021", ToMonth = "Jul", Rank = 2, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job },
                new Experience { Id = new Guid("67cc76b5-2571-455c-aa7c-87f60336a7b2"), UserId = new Guid("404321a7-3229-4bfa-b795-e9c616ca99a6"), OrganizationId = new Guid("d64c44e1-2a56-475a-8a6c-32e391b6d113"), FromYear = "2018", FromMonth = "Jan", ToYear = "2020", ToMonth = "Jan", Rank = 1, Highlighted = true, Status = Enum.Status.Active, Category = Enum.OrganizationCategory.Job }
            );
        }
    }
}
