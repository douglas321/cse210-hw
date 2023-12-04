using System;
using System.Collections.Generic;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA
    {
        get { return _country.ToLower() == "usa"; }
    }

    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSACustomer
    {
        get { return _address.IsUSA; }
    }

    public string GetShippingAddress()
    {
        return _address.GetAddressString();
    }
}

class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productID})";
    }
}

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        double shippingCost = _customer.IsUSACustomer ? 5 : 35;
        return totalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> packingLabels = new List<string>();
        foreach (Product product in _products)
        {
            packingLabels.Add(product.GetProductInfo());
        }
        return string.Join("\n", packingLabels);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetShippingAddress()}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Elon St", "Yaggatown", "Crater 1", "MOON");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("Flamethrower", 1, 250.89, 1);
        Product product2 = new Product("Tesla Truck", 2, 59999.99, 1);
        List<Product> products1 = new List<Product> { product1, product2 };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("456 Oak St", "Oakentown", "OK", "OakTree");
        Customer customer2 = new Customer("Lemon Lover", address2);
        Product product3 = new Product("Lemons", 3, 3.99, 100);
        List<Product> products2 = new List<Product> { product3 };
        Order order2 = new Order(customer2, products2);

        // Displaying results
        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 - Total Cost:");
        Console.WriteLine(order1.CalculateTotalCost());

        Console.WriteLine("\n========================\n");

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 - Total Cost:");
        Console.WriteLine(order2.CalculateTotalCost());
    }
}
