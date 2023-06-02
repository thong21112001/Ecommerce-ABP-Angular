using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EcommerceABP.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class EcommerceABPDbContextFactory : IDesignTimeDbContextFactory<EcommerceABPDbContext>
{
    public EcommerceABPDbContext CreateDbContext(string[] args)
    {
        EcommerceABPEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EcommerceABPDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new EcommerceABPDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EcommerceABP.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
