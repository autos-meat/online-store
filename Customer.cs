using System;
using System.Collections.Generic;

public class Customer
{
    public string Name { get; }
    private List<Order> orders = new List<Order>();

    public Customer(string name)
    {
        Name = name;
    }

    public Order PlaceOrder(ShoppingCart shoppingCart)
    {
        Order order = new Order(shoppingCart);
        orders.Add(order);
        return order;
    }

    public void DisplayOrder(Order order)
    {
        Console.WriteLine($"Order for customer {Name}:");
        Console.WriteLine("Products in the order:");

        foreach (var entry in order.ShoppingCart.Products)
        {
            Console.WriteLine($"{entry.Key.Name} - Quantity: {entry.Value}");
        }

        Console.WriteLine($"Total: ${order.ShoppingCart.CalculateTotal()}");
    }
}
