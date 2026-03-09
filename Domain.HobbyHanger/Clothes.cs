using Domain.HobbyHanger.Enums;

namespace Domain.HobbyHanger;
using System;

public class Clothes : Product
{
    public Conditions Condition { get; set; }
    public Gender Gender { get; set; }
    public ClothesCategory Category { get; set; }
    
    // For navigation properties we need to make a variable for the primary key
    public required string MeasurementsId { get; set; }
    // Then we call the table so that we can link the primary key to the variable we just made
    public required Measurements Measurements { get; set; } = null!;
}