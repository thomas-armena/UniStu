using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum View
{
    SelectGame,
    Game,
    Shop,
    CharacterCreation
}

public class MainWindowController : MonoBehaviour
{

    public GameObject selectGameView;
    public GameObject gameView;
    public GameObject shopView;
    public GameObject characterCreationView;

    public View currentView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectGameView.SetActive(this.currentView == View.SelectGame);
        gameView.SetActive(this.currentView == View.Game);
        shopView.SetActive(this.currentView == View.Shop);
        characterCreationView.SetActive(this.currentView == View.CharacterCreation);
    }
}
