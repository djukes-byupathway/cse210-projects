using System;
using System.Globalization;

public class Product
{
    string _name;
    string _productId;
    double _price;
    int _quantity;

    public Product(string name, string productid, double price, int quantity)
    {
        _name = name;
        _productId = productid;
        _price = price;
        _quantity = quantity;
    }

    public double getTotalCost()
    {
        double total = _price * _quantity;

        return total;
    }

public string getProductDetails()
    {
        return $"Item:{_productId}-{_name} Qty: {_quantity} @ {_price.ToString("C", new CultureInfo("en-US"))} each, total cost: {getTotalCost().ToString("C", new CultureInfo("en-US"))}";
    }


}