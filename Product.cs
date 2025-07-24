namespace OnlineOrdering;

public class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public decimal PricePerUnit { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal GetTotalCost() => PricePerUnit * Quantity;

    public string GetPackingLine() => $"{Name} (ID: {ProductId}) x{Quantity}";
}
