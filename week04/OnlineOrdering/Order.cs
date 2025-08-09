using System.Net.Http.Headers;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUsa() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder("Packing Label:");
        foreach (Product product in _products)
        {
            sb.AppendLine(product.GetLabel());
        }
        return sb.ToString();
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()} {_customer.GetAddress().GetFullAddress()}";
    }
}