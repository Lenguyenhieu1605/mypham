using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebMyPham.Data.EF
{
    class WebMyPhamDbContextFactory : IDesignTimeDbContextFactory<WebMyPhamDbContext>
    {

        public WebMyPhamDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WebMyPhamDb");

            var optionsBuilder = new DbContextOptionsBuilder<WebMyPhamDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebMyPhamDbContext(optionsBuilder.Options);
        }
    }
}
