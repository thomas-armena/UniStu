using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterCreationController : MonoBehaviour
{

    public Button doneButton;
    public MainWindowController mainWindowController;

    // Start is called before the first frame update
    void Start()
    {
        doneButton.onClick.AddListener(HandleDoneButtonClick);
    }

    void HandleDoneButtonClick()
    {
        mainWindowController.currentView = View.Game;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
