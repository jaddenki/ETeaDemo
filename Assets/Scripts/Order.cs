using System;
using UnityEngine;

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
    
    // customer patience shit
    public float creationTime; 
    public float lifespan = 20f; 

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
            CustomerName = "Customer " + customerCt,
            FlavorChoice = randomFlavor,
            SugarChoice = randomSugar,
            ToppingChoice = randomTopping,
            creationTime = Time.time
        };

    }

    // wait wait iwati
    public override string ToString()
    {
        return $"Order for {CustomerName}: Flavor - {FlavorChoice}, Sugar - {SugarChoice}, Topping - {ToppingChoice}";
    }

    // byebye
    public bool IsExpired()
    {
        return (Time.time - creationTime) > lifespan;
    }
}
