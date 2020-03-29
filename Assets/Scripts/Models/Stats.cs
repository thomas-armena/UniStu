using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    PartyAnimal,
    GymRat,
    Nerd
}

public class Stats
{
    public CharacterType characterType;
    public int health;
    public int grade;
    public int hunger;
    public int social;
    public int macCoins;

    public Stats()
    {
        this.characterType = CharacterType.PartyAnimal;
        this.health = 50;
        this.grade = 50;
        this.hunger = 50;
        this.social = 50;
        this.macCoins = 0;
    }
}
