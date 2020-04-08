﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    public Button appearanceButton;
    public MainWindowController mainWindowController;

    // Start is called before the first frame update
    void Start()
    {
        appearanceButton.onClick.AddListener(HandleAppearanceButtonClick);
    }

    void HandleAppearanceButtonClick()
    {
        mainWindowController.currentView = View.CharacterCreation;
    }

    // Update is called once per frame
    void Update()
    {
        System.Console.WriteLine("TEst");
    }
}
