// this is to generate one order? each customer calls this i assume?

using System;

public class GenerateOrder
{
    private static Random random = new Random();

    public static Order GenerateRandomOrder()
    {
        Order newOrder = new Order
        {
            FlavorChoice = (Flavor)random.Next(Enum.GetValues(typeof(Flavor)).Length),
            SugarChoice = (SugarLevel)random.Next(Enum.GetValues(typeof(SugarLevel)).Length),
            ToppingChoice = (Topping)random.Next(Enum.GetValues(typeof(Topping)).Length)
        };

        return newOrder;
    }
}