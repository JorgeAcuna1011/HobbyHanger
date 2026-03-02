using System;
using Domain.HobbyHanger;
using Microsoft.EntityFrameworkCore;

namespace Persistence.HobbyHanger;

public class HobbyHangerDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Clothe> Clothes { get; set; }
}