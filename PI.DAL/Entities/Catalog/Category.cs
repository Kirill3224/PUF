namespace PI.DAL.Entities.Catalog;

public class Category : BaseEntity
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;

    public ICollection<Product> Products { get; private set; }

    protected Category()
    {
        Products = new List<Product>();
    }

    private Category(string name, string description)
    {
        Name = name;
        Description = description;
        Products = new List<Product>();
    }

    public static Category Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Category name cannot be null or empty.", nameof(name));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Category description cannot be null or empty.", nameof(description));

        return new Category(name, description);
    }
}