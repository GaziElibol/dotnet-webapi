using System;

namespace Core.Entities;

public class Product : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public required string PictureUrl { get; set; }
    public required String Type { get; set; }    
    public required String Brand { get; set; }
    public int QuantityInStock { get; set; }
}
