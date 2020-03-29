using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{ 
    public static GameData instance = new GameData();
    public CharacterAppearance characterAppearance;
    public Stats stats;
    public Time time;

    private GameData()
    {
        characterAppearance = new CharacterAppearance();
        stats = new Stats();
        time = new Time();
    }

}
