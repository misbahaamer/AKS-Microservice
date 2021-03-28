using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                     Name        = "IPhone x",
                     Summary     = "this is Iphone. phone company's biggest smart phone",
                     Description = "Iphone description",
                     ImageFile   = "product-1.png",
                     Price       = 950.00M,
                     Category    = "IOS"
                },
                new Product()
                {
                     Name        = "Samsung S10",
                     Summary     = "this is galaxy s10. phone company's biggest smart phone",
                     Description = "S10 description",
                     ImageFile   = "product-2.png",
                     Price       = 840,
                     Category    = "Andriod"
                },
                new Product()
                {
                     Name        = "Huawei Plus",
                     Summary     = "this is china phone. phone company's biggest smart phone",
                     Description = "Huawei description",
                     ImageFile   = "product-3.png",
                     Price       = 750.00M,
                     Category    = "Andriod"
                },
            };
        }
    }
}
