public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    //  to get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:";
        foreach (var product in _products)
        {
            label += $"Product: {product.GetProductName()}, ID: {product.GetProductID()}\n";
        }
        return label;
    }

    //  get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerDetails()}";
    }

    // calculate the total cost
    public double GetTotalCost()
    {
        double totalProductCost = 0;

        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
}
