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
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 3,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 4,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 4,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 5,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 5,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 6,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 6,
                    Status = Status.Active
                },
                 new Category()
                 {
                     Id = 7,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 7,
                     Status = Status.Active
                 },
                new Category()
                {
                    Id = 8,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 8,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 9,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 9,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 10,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 10,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 11,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 11,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 12,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 12,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 13,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 13,
                    Status = Status.Active
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Son" },
                  new CategoryTranslation() { Id = 2, CategoryId = 2, Name = "Phấn nước" },
                  new CategoryTranslation() { Id = 3, CategoryId = 3, Name = "Má hồng" },
                  new CategoryTranslation() { Id = 4, CategoryId = 4, Name = "Phấn phủ" },
                  new CategoryTranslation() { Id = 5, CategoryId = 5, Name = "Chì kẻ mày" },
                  new CategoryTranslation() { Id = 6, CategoryId = 6, Name = "Che khuyết điểm" },
                  new CategoryTranslation() { Id = 7, CategoryId = 7, Name = "Kẻ viền mắt" },
                  new CategoryTranslation() { Id = 8, CategoryId = 8, Name = "Phấn mắt" },
                  new CategoryTranslation() { Id = 9, CategoryId = 9, Name = "Mascara" },
                  new CategoryTranslation() { Id = 10, CategoryId = 10, Name = "Tẩy trang" },
                  new CategoryTranslation() { Id = 11, CategoryId = 11, Name = "Sữa rửa mặt" }, 
                  new CategoryTranslation() { Id = 12, CategoryId = 12, Name = "Kem chống nắng" },
                  new CategoryTranslation() { Id = 13, CategoryId = 13, Name = "Mặt nạ" }
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

            modelBuilder.Entity<Slide>().HasData(
                new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
                new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
                new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
                new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
                new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
                new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
                );
        }
    }
}
