using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{

    public Button closeButton;
    public MainWindowController mainWindowController;

    // Start is called before the first frame update
    void Start()
    {
        closeButton.onClick.AddListener(HandleCloseButtonClick);
    }

    void HandleCloseButtonClick()
    {
        mainWindowController.currentView = View.Game;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
