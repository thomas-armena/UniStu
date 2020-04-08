using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
    // TODO: Add more items to the shop
    public static Item[] ShopItems = new Item[]
    {
        new Item("Willy Dog", "A quick cheap meal. hunger increased by 5.", 5, hungerChange: 5),
        new Item("Pinks", "So greasy but so good. Hunger increased by 10", 10, hungerChange: 10),
        new Item("Bistro", "Are you rich? Hunger increased by 20", 20, hungerChange: 20),

        new Item("Tylenol", "Health increased by 5.", 3, healthChange: 5),
        new Item("Pulse", "Health increased by 10.", 10, healthChange: 10, socialChange: 5),

        new Item("1280", "social increased by 30 but health decreased by 5", 25, healthChange: -5, socialChange: 30),
        new Item("Airpods", "Don't let people think you're broke", 20, socialChange: 20),

        new Item("Textbook", "People still buy textbooks?", 7, gradeChange: 10, socialChange:-3),
      
    };
}