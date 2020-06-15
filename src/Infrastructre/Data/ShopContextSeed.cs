using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructre.Data
{
    public class ShopContextSeed
    {
        public static async Task SeedAsync(ShopContext shopContext)
        {
            shopContext.Database.Migrate();
            if (!await shopContext.Categories.AnyAsync())
            {
                shopContext.Categories.AddRange(GetCategories());
                await shopContext.SaveChangesAsync();
            }
            if (!await shopContext.Brands.AnyAsync())
            {
                shopContext.Brands.AddRange(GetBrands());
                await shopContext.SaveChangesAsync();
            }
            if (!await shopContext.Products.AnyAsync())
            {
                shopContext.Products.AddRange(GetProducts());
                await shopContext.SaveChangesAsync();
            }
        }
        static IEnumerable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category
                {
                   
                   CategoryName = "2 in 1"
                },
                new Category
                {
                 
                   CategoryName = "Laptop"
                },
                new Category
                {
                   
                   CategoryName = "Gaming Notebook"
                },
                 new Category
                {
                   
                   CategoryName = "UltraBook"
                }
            };
        }
        static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    
                    CategoryId = 1,
                    BrandId = 1,
                    ProductName = "LENOVO IDEAPAD C340",
                    Description = "CORE İ3 10110U 2.1GHZ-4GB-128GB SSD-14\"-INT-TOUCH-W10",
                    UnitPrice = 4599,
                    PhotoPath = "TeoriV2-106778-8_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 1,
                    BrandId = 1,
                    ProductName = "LENOVO YOGA C940",
                    Description = "CORE İ7 1065G7 1.3GHZ-16GB RAM-512GB SSD-14''-INT-TOUCH-W10",
                    UnitPrice = 13999,
                    PhotoPath = "TeoriV2-105261-7_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 1,
                    BrandId = 2,
                    ProductName = "HP ENVY X360 13-AR0003NT",
                    Description = "AMD RYZEN 5 3500U 2.1GHZ-8GB-512GB SSD-13.3\"-AMD-W10",
                    UnitPrice = 7899,
                    PhotoPath = "TeoriV2-104421-2_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 2,
                    BrandId = 1,
                    ProductName = "LENOVO IDEAPAD L3",
                    Description = "CORE İ5 10210U 1.6GHZ-4GB-256GB SSD-15.6\"-MX130 2GB-W10",
                    UnitPrice = 4499,
                    PhotoPath = "TeoriV2-107814-1_small.jpg"
                },
                new Product
                {
                   
                    CategoryId = 2,
                    BrandId = 3,
                    ProductName = "MACBOOK PRO TOUCH BAR",
                    Description = "CORE İ5 2.0GHZ-16GB-1TB SSD-RETINA 13\"-INT-SILVER",
                    UnitPrice = 17599,
                    PhotoPath = "TeoriV2-107655-1_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 2,
                    BrandId = 4,
                    ProductName = "ASUS X509JB",
                    Description = "CORE İ5 1035G1 1.0GHZ-8GB RAM-256GB SSD-15.6\"-MX110 2GB-W10",
                    UnitPrice = 5299,
                    PhotoPath = "TeoriV2-106885-1_small.jpg"
                },
                new Product
                {
                   
                    CategoryId = 2,
                    BrandId = 1,
                    ProductName = "LENOVO IDEAPAD S340",
                    Description = "CORE İ5 10210U 1.6GHZ-8GB-512GB SSD-15.6\"-MX250 2GB-W10",
                    UnitPrice = 6199,
                    PhotoPath = "TeoriV2-106777-1_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 2,
                    BrandId = 2,
                    ProductName = "HP 15-DA1116NT",
                    Description = "CORE İ5 8265U 1.6GHZ-8GB-1TB+128GB SSD-15.6\"-MX110 2GB-W10",
                    UnitPrice = 5599,
                    PhotoPath = "TeoriV2-106571-1_small.jpg"
                },
                new Product
                {
                   
                    CategoryId = 2,
                    BrandId = 5,
                    ProductName = "DELL XPS 13 7390",
                    Description = "CORE İ7 10510U 1.8GHZ-16GB RAM-512 SSD-INT-13.3\"W10 PRO",
                    UnitPrice = 15973,
                    PhotoPath = "TeoriV2-105824-2_small.jpg"
                },
                new Product
                {
                   
                    CategoryId = 2,
                    BrandId = 4,
                    ProductName = "ASUS X509FB",
                    Description = "CORE İ5 8265U 1.6GHZ-8GB RAM-256GB SSD-15.6\"-MX110 2GB-W10",
                    UnitPrice = 5043,
                    PhotoPath = "TeoriV2-105445-8_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 3,
                    BrandId = 4,
                    ProductName = "ASUS A15 TUF FA506IU",
                    Description = "AMD R7 4800H 2.9GHZ-16GB-512GB SSD-15.6''-GTX1660TI 6GB-W10",
                    UnitPrice = 10218,
                    PhotoPath = "TeoriV2-107585-2_small.jpg"
                },
                new Product
                {
                   
                    CategoryId = 3,
                    BrandId = 6,
                    ProductName = "MSI GF75",
                    Description = "CORE İ7 10750H 2.6GHZ-16GB-256GB SSD+ 1TB HDD-17.3\"-GTX1650 4GB-W10",
                    UnitPrice = 13583,
                    PhotoPath = "TeoriV2-106836_small.jpg"
                },
                new Product
                {
                    
                    CategoryId = 3,
                    BrandId = 2,
                    ProductName = "HP PAVILION 15-CX0039NT",
                    Description = "CORE İ5 8300H 2.3GHZ-16GB-512SSD-15.6\"-GTX1050TI 4GB-W10",
                    UnitPrice = 7499,
                    PhotoPath = "TeoriV2-104420-1_small.jpg"
                },
                new Product
                {
                  
                    CategoryId = 3,
                    BrandId = 1,
                    ProductName = "LENOVO LEGION Y740",
                    Description = "CORE İ7 9750H 2.6GHZ-32GB-1TB+1TB SSD-17.3\"-RTX2070 8GB-W10",
                    UnitPrice = 19999,
                    PhotoPath = "TeoriV2-103978-1_small.jpg"
                }
            };
        }
        static IEnumerable<Brand> GetBrands()
        {
            return new List<Brand> {
            new Brand {
              
              BrandName="Lenova"
            },
            new Brand {
              
              BrandName="Hp"
            },
            new Brand {
             
              BrandName="Apple"
            },
            new Brand {
            
              BrandName="Asus"
            },
            new Brand {
            
              BrandName="Dell"
            },
            new Brand {
              
              BrandName="MSI"
            }
            };
        }
    }
}
