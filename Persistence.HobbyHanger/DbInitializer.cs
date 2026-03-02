using System.Drawing;
using Domain.HobbyHanger;

namespace Persistence.HobbyHanger;

public class DbInitializer
{
    public static async Task SeedData(HobbyHangerDbContext context)
    {
        if (context.Clothes.Any()) return;

        var clothes = new List<Clothe>
        {
            new ()
            {
                Name = "Yankees Jersey",
                Description = "Authentic pinstripe home jersey, size Medium.",
                Price = 40.00,
                Brand = "Nike",
                Size = ClothingSize.Medium,
                Condition = Conditions.LikeNew,
                Gender = Gender.Male,
                Date = DateTime.UtcNow
            },

            // 2. Using explicit new Clothes()
            new ()
            {
                Name = "Vintage Leather Jacket",
                Description = "90s era oversized black leather jacket.",
                Price = 85.50,
                Brand = "ThriftFinds",
                Size = ClothingSize.Large,
                Condition = Conditions.Used,
                Gender = Gender.Unisex,
                Date = DateTime.UtcNow
            },

            // 3. Another new() item
            new ()
            {
                Name = "Summer Floral Dress",
                Description = "Lightweight sundress with sunflower pattern.",
                Price = 25.00,
                Brand = "H&M",
                Size = ClothingSize.Small,
                Condition = Conditions.New,
                Gender = Gender.Female,
                Date = DateTime.UtcNow
            },

            // 4. A "Bad Condition" item for testing filters
            new ()
            {
                Name = "Distressed Work Jeans",
                Description = "Heavy duty denim with some paint stains.",
                Price = 15.00,
                Brand = "Levi's",
                Size = ClothingSize.XLarge,
                Condition = Conditions.Used,
                Gender = Gender.Male,
                Date = DateTime.UtcNow
            }
        };

        context.Clothes.AddRange(clothes);
        
        await context.SaveChangesAsync();
    }
}