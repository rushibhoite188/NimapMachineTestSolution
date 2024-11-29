using NimapMachineTestSolution.Models;
using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext() : base("name=NimapMachineTestDB")
    {

    }
}