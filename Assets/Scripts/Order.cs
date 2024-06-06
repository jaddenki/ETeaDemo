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
    public string CustomerName { get; set; }
    public Flavor FlavorChoice { get; set; }
    public SugarLevel SugarChoice { get; set; }
    public Topping ToppingChoice { get; set; }
}
