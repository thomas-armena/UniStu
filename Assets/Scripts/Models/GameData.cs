using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{ 
    public static GameData Instance = new GameData();
    public CharacterAppearance CharacterAppearance { get; set; }
    public Stats CharacterStats { get; set; }
    public Time CurrentTime { get; set; }

    private GameData()
    {
        CharacterAppearance = new CharacterAppearance();
        CharacterStats = new Stats();
        CurrentTime = new Time();
    }

}
