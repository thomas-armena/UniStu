using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
    public static Dictionary<string, Item> ShopItems = new Dictionary<string, Item>()
    {
        {"Willy Dog", new Item("Willy Dog", "A quick cheap meal", 5, hungerChange: 5) },
        {"Textbook", new Item("Textbook", "People still buy textbooks?", 80, gradeChange: 3, socialChange:-3) },
        {"Airpods", new Item("Airpods", "Don't let people think you're broke", 300, socialChange: 20) },
    };
}