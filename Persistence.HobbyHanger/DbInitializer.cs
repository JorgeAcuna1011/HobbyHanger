using System.Drawing;
using Domain.HobbyHanger;

namespace Persistence.HobbyHanger;

public class DbInitializer
{
    public static async Task SeedData(HobbyHangerDbContext context)
    {
        if (context.Clothes.Any()) return;

        var Clothes = new List<Clothes>
        {
            new Clothes {
                Name = "Vintage Graphic Tee",
                Description = "Single-stitch cotton black t-shirt with faded print.",
                Price = 45.00,
                Category = ClothesCategory.Top,
                Size = ClothingSize.Large,
                Condition = Conditions.Good,
                Gender = Gender.Unisex
            },
            new Clothes {
                Name = "Fisherman Cable Knit",
                Description = "Heavy cream-colored wool sweater.",
                Price = 75.00,
                Category = ClothesCategory.Sweater,
                Size = ClothingSize.Medium,
                Condition = Conditions.LikeNew,
                Gender = Gender.Female
            },
            new Clothes {
                Name = "Classic Denim Trucker",
                Description = "Dark wash denim jacket with metal buttons.",
                Price = 85.00,
                Category = ClothesCategory.Jacket,
                Size = ClothingSize.Small,
                Condition = Conditions.Used,
                Gender = Gender.Male
            },
            new Clothes {
                Name = "High-Waist Mom Jeans",
                Description = "Light blue tapered denim with relaxed fit.",
                Price = 60.00,
                Category = ClothesCategory.Jean,
                Size = ClothingSize.Large,
                Condition = Conditions.Fair,
                Gender = Gender.Female
            },
            new Clothes {
                Name = "Canvas Field Coat",
                Description = "Rugged tan outerwear with corduroy collar.",
                Price = 110.00,
                Category = ClothesCategory.Outerwear,
                Size = ClothingSize.XLarge,
                Condition = Conditions.Good,
                Gender = Gender.Male
            },
            new Clothes {
                Name = "Corduroy Trousers",
                Description = "Brown wide-leg corduroy pants.",
                Price = 55.00,
                Category = ClothesCategory.Bottom,
                Size = ClothingSize.Medium,
                Condition = Conditions.Used,
                Gender = Gender.Unisex
            },
            new Clothes {
                Name = "Striped Polo Shirt",
                Description = "Vintage knit polo with horizontal stripes.",
                Price = 35.00,
                Category = ClothesCategory.Top,
                Size = ClothingSize.Small,
                Condition = Conditions.Good,
                Gender = Gender.Male
            },
            new Clothes {
                Name = "Varsity Bomber Jacket",
                Description = "Wool body with leather sleeves and patched logos.",
                Price = 150.00,
                Category = ClothesCategory.Jacket,
                Size = ClothingSize.XXLarge,
                Condition = Conditions.LikeNew,
                Gender = Gender.Unisex
            },
            new Clothes {
                Name = "Mohair Cardigan",
                Description = "Soft, fuzzy textured sweater in emerald green.",
                Price = 95.00,
                Category = ClothesCategory.Sweater,
                Size = ClothingSize.Medium,
                Condition = Conditions.New,
                Gender = Gender.Female
            },
            new Clothes {
                Name = "Workwear Overalls",
                Description = "Heavy-duty blue denim with adjustable straps.",
                Price = 80.00,
                Category = ClothesCategory.Bottom,
                Size = ClothingSize.Large,
                Condition = Conditions.Poor,
                Gender = Gender.Unisex
            }
        };

        context.Clothes.AddRange(Clothes);
        
        await context.SaveChangesAsync();
    }
}