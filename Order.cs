using System;
using System.Collections.Generic;

public class Order
{
    public ShoppingCart ShoppingCart { get; }

    public Order(ShoppingCart shoppingCart)
    {
        ShoppingCart = shoppingCart;
    }
}
