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
            var skillId = new Guid("86a7856d-e263-45c5-beec-e511df45ae61");
            var userId = new Guid("e1f5e4dd-c883-4ad8-9c76-b15f254a0e45");
            var orgId = new Guid("085b5c6f-5fa5-45f0-a76b-9ede0904311c");

            SeedUser(modelBuilder, userId);
            SeedSkill(modelBuilder, skillId);
            SeedUserSkill(modelBuilder, skillId, userId);
            SeedOrganization(modelBuilder, orgId);
            SeedUserOrganization(modelBuilder, userId, orgId);
        }

        private static void SeedUser(ModelBuilder modelBuilder, Guid userid)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = userid, FirstName = "Muhammad Khabir", LastName = "Uddin", Email = "khabir.aiub@gmail.com", CreatedDate = DateTime.Now, Phone = "+8801914328355", UserName = "khabir" }
            );
        }

        private static void SeedSkill(ModelBuilder modelBuilder, Guid skillId)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = skillId, Name = "Software Development", Description = "Software Development" }
            );
        }

        private static void SeedOrganization(ModelBuilder modelBuilder, Guid orgId)
        {
            modelBuilder.Entity<Organization>().HasData(
                new Organization { Id = orgId, Name = "Torre", PublicId = "Torre" }
            );
        }
        private static void SeedUserSkill(ModelBuilder modelBuilder, Guid skillId, Guid userid)
        {
            modelBuilder.Entity<UserSkill>().HasData(
                new UserSkill { Id = new Guid("a28a70b7-c0ed-43e6-86bc-be78215617ef"), Proficiency = 1, SkillId = skillId, UserId = userid }
            );
        }
        private static void SeedUserOrganization(ModelBuilder modelBuilder, Guid userId, Guid orgId)
        {
            modelBuilder.Entity<User>().HasData(
                new UserOrganization { Id = new Guid("80d0da1c-a1fa-4a0b-9ffc-624566addc56"), UserId= userId, OrganizationId= orgId }
            ); 
        }
    }
}
