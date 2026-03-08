namespace Domain.HobbyHanger;
using System;

public class Clothes : Product
{
    public ClothingSize? Size { get; set; }
    public int? NumberSize { get; set; }
    public Conditions Condition { get; set; }
    public Gender Gender { get; set; }
    public ClothesCategory Category { get; set; }
    // Fetch for specific categories of clothing?
}