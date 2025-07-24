using System.Text;

namespace OnlineOrdering;

public class Order
{
    private readonly List<Product> _products = new();
    public Customer Customer { get; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product) => _products.Add(product);

    public decimal GetTotalPrice()
    {
        decimal subtotal = 0m;
        foreach (var p in _products)
        {
            subtotal += p.GetTotalCost();
        }
        decimal shipping = Customer.LivesInUSA() ? 5m : 35m;
        return subtotal + shipping;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder("=== PACKING LABEL ===\n");
        foreach (var p in _products)
        {
            sb.AppendLine(p.GetPackingLine());
        }
        return sb.ToString().TrimEnd();
    }

    public string GetShippingLabel()
        => $"=== SHIPPING LABEL ===\n{Customer.Name}\n{Customer.GetShippingAddress()}";
}
