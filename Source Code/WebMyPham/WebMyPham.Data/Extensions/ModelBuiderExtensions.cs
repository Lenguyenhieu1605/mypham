using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.Data.Entities;
using WebMyPham.Data.Enums;

namespace WebMyPham.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static List<ProductInCategory> ProductInCategories { get; private set; }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            //data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of ShopHD" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of ShopHD" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of ShopHD" }
                );
            //data seeding
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Status.Active },
                 new Category() { Id = 2, IsShowOnHome = true, ParentId = null, SortOrder = 2, Status = Status.Active }

                );
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 99000,
                   Price = 100000,
                   Stock = 0,
                   ViewCount = 0,

               });
            modelBuilder.Entity<ProductDetail>().HasData(
               new ProductDetail()
               {
                   Id = 1,
                   ProductId = 1,
                   Name = "Son 3CE",
                   Details = "Son 3CE Velvet Tint",
                   Description = "Son 3CE Velvet Tint"
               });

          modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory() { ProductId = 1, CategoryId = 1 }

                );
            //any guid
            var roleId = new Guid("0471FF08-3E9D-4C2E-9748-9A6252B55EEA");
            var adminId = new Guid("46064BFD-A12E-4CB6-8D63-6F0BA81AA70D");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "diem99spk@gmail.com",
                NormalizedEmail = "diemvo99spk@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "diem1234@"),
                SecurityStamp = string.Empty,
                FirstName = "Diem",
                LastName = "Vo",
                Dob = new DateTime(1999, 06, 08)
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId =adminId
            });

        }
    }
}
