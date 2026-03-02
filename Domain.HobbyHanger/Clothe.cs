namespace Domain.HobbyHanger;
using System;

public class Clothe : Product
{
    public ClothingSize Size { get; set; }
    public Conditions Condition { get; set; }
    public Gender Gender { get; set; }
}