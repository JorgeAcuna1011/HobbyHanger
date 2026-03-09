using System.Drawing;
using Domain.HobbyHanger;
using Domain.HobbyHanger.Enums;

namespace Persistence.HobbyHanger;

public class DbInitializer
{
    public static async Task SeedData(HobbyHangerDbContext context)
    {
        if (context.Clothes.Any()) return;

        var measurements = new List<Measurements>
        {
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), WaistSize = 32, InseamSize = 30, MeasurementType = MeasurementType.WaistInseam },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), WaistSize = 34, InseamSize = 32, MeasurementType = MeasurementType.WaistInseam },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), LetterSize = LetterSize.L, MeasurementType = MeasurementType.Alpha },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), LetterSize = LetterSize.M, MeasurementType = MeasurementType.Alpha },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), WaistSize = 30, InseamSize = 30, MeasurementType = MeasurementType.WaistInseam },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), LetterSize = LetterSize.S, MeasurementType = MeasurementType.Alpha },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), MeasurementType = MeasurementType.NotApplicable },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), LetterSize = LetterSize.XL, MeasurementType = MeasurementType.Alpha },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), WaistSize = 36, InseamSize = 34, MeasurementType = MeasurementType.WaistInseam },
            new Measurements { MeasurementsId = Guid.NewGuid().ToString(), LetterSize = LetterSize.M, MeasurementType = MeasurementType.Alpha }
        };

        var clothes = new List<Clothes>
        {
            new Clothes { Name = "Vintage Levi's 501", Brand = "Levi's", Price = 85.00, Category = ClothesCategory.Bottom, Condition = Conditions.Excellent, Gender = Gender.Male, MeasurementsId = measurements[0].MeasurementsId, Measurements = measurements[0], Description = "Classic straight leg denim.", Date = DateTime.UtcNow },
            new Clothes { Name = "Wrangler Cowboy Cut", Brand = "Wrangler", Price = 45.00, Category = ClothesCategory.Bottom, Condition = Conditions.Good, Gender = Gender.Male, MeasurementsId = measurements[1].MeasurementsId, Measurements = measurements[1], Description = "Authentic western wear.", Date = DateTime.UtcNow },
            new Clothes { Name = "90s Oversized Flannel", Brand = "St. Johns Bay", Price = 35.00, Category = ClothesCategory.Top, Condition = Conditions.Good, Gender = Gender.Unisex, MeasurementsId = measurements[2].MeasurementsId, Measurements = measurements[2], Description = "Soft, worn-in heavy flannel.", Date = DateTime.UtcNow },
            new Clothes { Name = "Champion Reverse Weave Hoodie", Brand = "Champion", Price = 60.00, Category = ClothesCategory.Knitwear, Condition = Conditions.Excellent, Gender = Gender.Unisex, MeasurementsId = measurements[3].MeasurementsId, Measurements = measurements[3], Description = "Heavyweight 90s era hoodie.", Date = DateTime.UtcNow },
            new Clothes { Name = "Carhartt Double Knee Pants", Brand = "Carhartt", Price = 120.00, Category = ClothesCategory.Bottom, Condition = Conditions.Excellent, Gender = Gender.Male, MeasurementsId = measurements[4].MeasurementsId, Measurements = measurements[4], Description = "Faded black workwear pants.", Date = DateTime.UtcNow },
            new Clothes { Name = "Single Stitch Tour Tee", Brand = "Hanes", Price = 150.00, Category = ClothesCategory.Top, Condition = Conditions.Excellent, Gender = Gender.Unisex, MeasurementsId = measurements[5].MeasurementsId, Measurements = measurements[5], Description = "Rare 1992 concert t-shirt.", Date = DateTime.UtcNow },
            new Clothes { Name = "Vintage Trucker Hat", Brand = "Patagonia", Price = 25.00, Category = ClothesCategory.Top, Condition = Conditions.Fair, Gender = Gender.Unisex, MeasurementsId = measurements[6].MeasurementsId, Measurements = measurements[6], Description = "Mesh back snapback.", Date = DateTime.UtcNow },
            new Clothes { Name = "80s Members Only Jacket", Brand = "Members Only", Price = 55.00, Category = ClothesCategory.Outerwear, Condition = Conditions.Good, Gender = Gender.Male, MeasurementsId = measurements[7].MeasurementsId, Measurements = measurements[7], Description = "Iconic racer style jacket.", Date = DateTime.UtcNow },
            new Clothes { Name = "Dickies 874 Work Pants", Brand = "Dickies", Price = 40.00, Category = ClothesCategory.Bottom, Condition = Conditions.New, Gender = Gender.Male, MeasurementsId = measurements[8].MeasurementsId, Measurements = measurements[8], Description = "Classic skate pants.", Date = DateTime.UtcNow },
            new Clothes { Name = "Nike Center Swoosh Crewneck", Brand = "Nike", Price = 95.00, Category = ClothesCategory.Knitwear, Condition = Conditions.Excellent, Gender = Gender.Unisex, MeasurementsId = measurements[9].MeasurementsId, Measurements = measurements[9], Description = "Vintage 90s center logo.", Date = DateTime.UtcNow }
        };

        context.AddRange(measurements);
        context.Clothes.AddRange(clothes);
        
        await context.SaveChangesAsync();
    }
}