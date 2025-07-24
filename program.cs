using System.Text;
using OnlineOrdering;

namespace OnlineOrderingApp
{
    internal class Program
    {
        static void Main()
        {
            // ----- Pedido 1 - Cliente USA -----
            var addr1 = new Address("123 Main St", "Provo", "UT", "USA");
            var cust1 = new Customer("John Smith", addr1);

            var order1 = new Order(cust1);
            order1.AddProduct(new Product("USB-C Cable", "P1001", 3.99m, 5));
            order1.AddProduct(new Product("Wireless Mouse", "P2001", 19.90m, 1));
            order1.AddProduct(new Product("Notebook Sleeve", "P3001", 12.50m, 2));

            PrintOrder(order1);

            // ----- Pedido 2 - Cliente Internacional -----
            var addr2 = new Address("Av. Atlântica 456", "Rio de Janeiro", "RJ", "Brazil");
            var cust2 = new Customer("Caio Palladino", addr2);

            var order2 = new Order(cust2);
            order2.AddProduct(new Product("Mechanical Keyboard", "K1000", 75.00m, 1));
            order2.AddProduct(new Product("HDMI Cable", "C2020", 8.50m, 3));

            PrintOrder(order2);

            // (Opcional) Gerar HTML
            // var html = HtmlReportGenerator.BuildHtml(order1, order2);
            // File.WriteAllText("results.html", html, Encoding.UTF8);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintOrder(Order order)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"TOTAL: ${order.GetTotalPrice():0.00}\n");
        }
    }
}
