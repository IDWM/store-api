using Bogus;
using Microsoft.EntityFrameworkCore;
using store_api.Src.Models;

namespace store_api.Src.Data
{
    public class Seeder
    {
        public static async Task SeedData(DataContext context)
        {
            if (await context.Stores.AnyAsync())
                return;

            var storeIds = 1;
            var storeFaker = new Faker<Store>()
                .RuleFor(s => s.Id, f => storeIds++)
                .RuleFor(s => s.Name, f => f.Company.CompanyName())
                .RuleFor(s => s.City, f => f.Address.City());

            var stores = storeFaker.Generate(10);
            await context.Stores.AddRangeAsync(stores);
            await context.SaveChangesAsync();

            var productIds = 1;
            var productFaker = new Faker<Product>()
                .RuleFor(p => p.Id, f => productIds++)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Price, f => float.Parse(f.Commerce.Price(1, 10000)))
                .RuleFor(p => p.StoreId, f => f.PickRandom(stores).Id);

            var products = productFaker.Generate(50);
            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }
}
