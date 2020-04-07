using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    PartyAnimal,
    GymRat,
    Bookworm,
    CentroConnoisseur
}

[System.Serializable]
public class Stats
{
    public CharacterType CharacterType { get; private set; }
    public int Health { get; private set; }
    public int Grade { get; private set; }
    public int Hunger { get; private set; }
    public int Social { get; private set; }
    public int MacCoins { get; private set; }

    public Stats(CharacterType characterType = CharacterType.PartyAnimal, 
        int health = 50, int grade = 50, int hunger = 50, int social = 50, int macCoins = 4000)
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
