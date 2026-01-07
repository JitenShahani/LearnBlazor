namespace LearnBlazor.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Range (1, 1000)]
    public double Price { get; set; }

    public bool IsActive { get; set; }

    public IEnumerable<Product_Prop> ProductProperties { get; set; } = [];

    [EnumDataType (typeof (ProductCategory))]
    public ProductCategory Category { get; set; }

    [Required (ErrorMessage = "The {0} field is required.")]
    [Display (Name = "Available After")]
    public DateOnly? AvailableAfter { get; set; }
}

public enum ProductCategory
{
    [Description ("Starter & Appetizer")]
    Starter,
    Entree,
    Dessert,
    Drink,
    [Description ("Palate Cleanser")]
    PalateCleanser
}