using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum View
{
    SelectGame,
    Game,
    Shop,
    CharacterCreation,
    Camera
}

public class MainWindowController : MonoBehaviour
{

    public GameObject selectGameView;
    public GameObject gameView;
    public GameObject shopView;
    public GameObject characterCreationView;
    public GameObject cameraView;

    public View currentView;

    void Start()
    {
        
    }

    void OnApplicationQuit()
    {
        GameData.Instance.saveGameData();
    }

    void Update()
    {
        selectGameView.SetActive(this.currentView == View.SelectGame);
        gameView.SetActive(this.currentView == View.Game);
        shopView.SetActive(this.currentView == View.Shop);
        characterCreationView.SetActive(this.currentView == View.CharacterCreation);
        cameraView.SetActive(this.currentView == View.Camera);
    }
}