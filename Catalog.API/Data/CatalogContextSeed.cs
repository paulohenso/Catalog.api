using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }
        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "acfff9c4db744bdd95c66094",
                    Name = "IPhone 14",
                    Description = "smart phone da aple",
                    Image = "product-1.jpge",
                    Price = 120.00M,
                    Category = "smartphones"
                },
                new Product()
                {
                    Id = "549ccfe46763402fa0ae7916",
                    Name = "Samsung Galaxy S22",
                    Description = "smart phone samsung",
                    Image = "product-2.jpge",
                    Price = 100.00M,
                    Category = "smartphones"
                },
                new Product()
                {
                    Id = "459b4cc17632411ca1a3bfae",
                    Name = "Ipad Air",
                    Description = "tablet aple",
                    Image = "product-3.jpge",
                    Price = 90.00M,
                    Category = "tablets"
                },
                new Product()
                {
                    Id = "83021b2524b349959701aa34",
                    Name = "Samsung Galaxy Tab",
                    Description = "tablet samsung",
                    Image = "product-4.jpge",
                    Price = 90.00M,
                    Category = "tablets"
                },
                new Product()
                {
                    Id = "c955c353fe9e48a28a10efcc",
                    Name = "Tv Lg",
                    Description = "smart tv lg",
                    Image = "product-5.jpge",
                    Price = 160.00M,
                    Category = "smarttvs"
                },
            };
        }
    }
}