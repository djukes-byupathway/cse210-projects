public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address addr)
    {
        _name = name;
        _address = addr;
    }

    public bool isDomestic()
    {
        return _address.isDomestic();
    }

    public string getShippingLabel()
    {
        return $"{_name}\n{_address.getAddress()}";
    }
    public string getName()
    {
        return _name;
    }
}

