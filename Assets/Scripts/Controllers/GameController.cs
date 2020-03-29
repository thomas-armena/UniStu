using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    public Button shopButton;
    public Button appearanceButton;
    public MainWindowController mainWindowController;

    // Start is called before the first frame update
    void Start()
    {
        shopButton.onClick.AddListener(HandleShopButtonClick);
        appearanceButton.onClick.AddListener(HandleAppearanceButtonClick);
    }

    void HandleShopButtonClick()
    {
        mainWindowController.currentView = View.Shop;
    }

    void HandleAppearanceButtonClick()
    {
        mainWindowController.currentView = View.CharacterCreation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
