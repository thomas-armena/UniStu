using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraController : MonoBehaviour
{

    public Button DoneButton;
    public Button Upload;
    public Button Explorer;
    public InputField PictureDirectory;
    public MainWindowController mainWindowController;
    public string Directory;

    void Start()
    {
        Upload.onClick.AddListener(HandleUploadClick);
        DoneButton.onClick.AddListener(HandleDoneButtonClick);
        Explorer.onClick.AddListener(HandleExplorerClick);
        PictureDirectory.onValueChanged.AddListener(HandleUploadDirectory);
    }

    void Update()
    {
        
    }

    void HandleDoneButtonClick()
    {
        mainWindowController.currentView = View.Game;
    }

    void HandleExplorerClick()
    {
        System.Diagnostics.Process.Start("explorer.exe");
    }

    void HandleUploadClick()
    {
        GameData.Instance.CharacterAppearance.Url = Directory;
    }

    void HandleUploadDirectory(string arg0)
    {
        Directory = arg0;
    }
}
