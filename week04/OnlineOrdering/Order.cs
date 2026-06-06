using System.Runtime.CompilerServices;
using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer cust, List<Product> products)
    {
        _customer = cust;
        _products = products;
    }

    public string getPackingLabel()
    {
        string productsString = "";
        StringBuilder prodStrBldr = new StringBuilder();
        prodStrBldr.AppendLine(_customer.getName());

        foreach (var prod in _products)
        {
            prodStrBldr.AppendLine(prod.getProductDetails());

        }

        return prodStrBldr.ToString();
    }

    public string getShippingLabel()
    {
        return _customer.getShippingLabel();
    }

    public double getOrderTotal()
    {
        double shipping = getShippingCost();
        double total = 0;

        foreach (var prod in _products)
        {
            total = total + prod.getTotalCost();
        }
        

        total = total + shipping;

        return total;
    }

    public double getShippingCost()
    {
        double shipping;
        if (_customer.isDomestic())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }

}