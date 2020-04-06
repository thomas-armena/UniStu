using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterCreationController : MonoBehaviour
{

    public Button doneButton;
    public MainWindowController mainWindowController;
    public Button cameraButton;
    public Dropdown headDropdown;
    public Dropdown bodyDropdown;

    void Start()
    {
        doneButton.onClick.AddListener(HandleDoneButtonClick);
        cameraButton.onClick.AddListener(HandleCameraButtonClick);
    }

    void HandleDoneButtonClick()
    {
        mainWindowController.currentView = View.Game;
    }

    void HandleCameraButtonClick()
    {
        mainWindowController.currentView = View.Camera;
    }

    void Update()
    {
        GameData.Instance.CharacterAppearance.Head = headDropdown.value;
        GameData.Instance.CharacterAppearance.Body = bodyDropdown.value;

    }
}
