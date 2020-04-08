using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{

    public Dropdown dropdown;
    public OutputMessageController outputMessageController;


    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate {
            HandleDropDownChange(dropdown);
        });

        foreach (Item item in Inventory.ShopItems)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item.Name + " $"+item.Price });
        }
    }

    void HandleDropDownChange(Dropdown change)
    {
        if (dropdown.value > 0)
        {
            Item boughtItem = Inventory.ShopItems[dropdown.value - 1];
            if (GameData.Instance.CharacterStats.MacCoins > boughtItem.Price)
            {
                string updateString = GameData.Instance.CharacterStats.ApplyStatChanges(boughtItem);
                outputMessageController.message = "Bought item: " + boughtItem.Name + "\n" + boughtItem.Description + "\n" + updateString;
            }

        }

        dropdown.value = 0;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
