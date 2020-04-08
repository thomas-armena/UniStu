using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
    // TODO: Add more items to the shop
    public static Item[] ShopItems = new Item[]
    {
        new Item("Willy Dog", "A quick cheap meal.", 5, hungerChange: 5),
        new Item("Pinks", "So greasy but so good.", 10, hungerChange: 10),
        new Item("Bistro", "Are you rich?", 20, hungerChange: 20),

        new Item("Tylenol", "The cure all.", 3, healthChange: 5),
        new Item("Pulse", "Is is new years already?", 10, healthChange: 10, socialChange: 5),

        new Item("1280 bar", "Can't remember what happened but was fun.", 25, healthChange: -5, socialChange: 30),
        new Item("Airpods", "Don't let people think you're broke", 20, socialChange: 20),

        new Item("Textbook", "People still buy textbooks?", 7, gradeChange: 1, socialChange:-3),
      
    };
}