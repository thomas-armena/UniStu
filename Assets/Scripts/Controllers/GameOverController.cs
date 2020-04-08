using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public Button restartButton;
    public MainWindowController mainWindowController;


    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(HandleRestartButtonClick);
    }

    void HandleRestartButtonClick()
    {
        GameData.Instance.resetGame();
        mainWindowController.currentView = View.CharacterCreation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
