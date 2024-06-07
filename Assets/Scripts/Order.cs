/* hai if ur reading this im tryna be organized so
 * 
 * THIS SCRIPT IS FOR THE ORDER CLASS & DATA STRUCTURES WAHTEVEVER.
 * so it'll include the flavors, sugar levels, and toppings
 * 
 */

using System;

public enum Flavor
{
    Taro,
    Matcha,
    FruitTea,
    Thai
}

public enum SugarLevel
{
    ZeroPercent,
    TwentyFivePercent,
    FiftyPercent,
    OneHundredPercent
}

public enum Topping
{
    Tapioca,
    Pudding,
    AloeVera,
    LycheeJelly
}


public class Order
{
    private static int customerCt = 0;
    public string CustomerName { get; set; }
    public Flavor FlavorChoice { get; set; }
    public SugarLevel SugarChoice { get; set; }
    public Topping ToppingChoice { get; set; }

    public static Order GenerateRandomOrder()
    {
        // random random
        var random = new System.Random();
        Flavor randomFlavor = (Flavor)random.Next(Enum.GetValues(typeof(Flavor)).Length);
        SugarLevel randomSugar = (SugarLevel)random.Next(Enum.GetValues(typeof(SugarLevel)).Length);
        Topping randomTopping = (Topping)random.Next(Enum.GetValues(typeof(Topping)).Length);
        customerCt++;
        // make order
        return new Order
        {
            CustomerName = "Customer " + customerCt, // errr customer number? we could do names if uwant
            FlavorChoice = randomFlavor,
            SugarChoice = randomSugar,
            ToppingChoice = randomTopping
        };

    }

    // wait wait iwati
    public override string ToString()
    {
        return $"Order for {CustomerName}: Flavor - {FlavorChoice}, Sugar - {SugarChoice}, Topping - {ToppingChoice}";
    }
}
