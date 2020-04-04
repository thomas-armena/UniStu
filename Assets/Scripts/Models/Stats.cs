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
    public CharacterType CharacterType { get; set; }
    public int Health { get; set; }
    public int Grade { get; set; }
    public int Hunger { get; set; }
    public int Social { get; set; }
    public int MacCoins { get; set; }

    public Stats()
    {
        CharacterType = CharacterType.PartyAnimal;
        Health = 50;
        Grade = 50;
        Hunger = 50;
        Social = 50;
        MacCoins = 0;
    }

    public Stats(CharacterType characterType, int health, int grade, int hunger, int social, int macCoins)
    {
        CharacterType = characterType;
        Health = health;
        Grade = grade;
        Hunger = hunger;
        Social = social;
        MacCoins = macCoins;
    }

    public void ApplyStatChanges(StatChanger statChanger)
    {
        Health += statChanger.HealthChange;
        Grade += statChanger.GradeChange;
        Hunger += statChanger.HungerChange;
        Social += statChanger.SocialChange;
        MacCoins += statChanger.MacCoinsChange;
    }
}
