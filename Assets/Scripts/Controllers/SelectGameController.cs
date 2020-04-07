using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectGameController : MonoBehaviour
{
    public Button newGameButton;
    public Button loadButton;
    public MainWindowController mainWindowController;

    // Start is called before the first frame update
    void Start()
    {
        newGameButton.onClick.AddListener(HandleNewGameButtonClick);
        loadButton.onClick.AddListener(HandleLoadButtonClick);
    }

    void HandleNewGameButtonClick()
    {
        mainWindowController.currentView = View.CharacterCreation;
    }

    void HandleLoadButtonClick()
    {
        bool result = GameData.Instance.loadGameData();
        // Only Continue to the Game screen if there was something to load.
        if (result)
        {
            mainWindowController.currentView = View.Game;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}