using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraController : MonoBehaviour
{

    public Button doneButton;
    public MainWindowController mainWindowController;


    void Start()
    {
        doneButton.onClick.AddListener(HandleDoneButtonClick);
    }

    void Update()
    {
        
    }

    void HandleDoneButtonClick()
    {
        mainWindowController.currentView = View.CharacterCreation;
    }
}
