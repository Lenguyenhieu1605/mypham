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
                new Category() { Id =1, IsShowOnHome = true, ParentId = null, SortOrder = 1, Status= Status.Active},
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
            modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory() { ProductId = 1, CategoryId = 1 }

                );
                 


        }
    }
}
