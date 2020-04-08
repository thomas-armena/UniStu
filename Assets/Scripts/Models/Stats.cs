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
        int health = 50, int grade = 8, int hunger = 50, int social = 50, int macCoins = 4000)
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
        Health = Mathf.Clamp(Health+statChanger.HealthChange, -999999, 100);
        Grade = Mathf.Clamp(Health + statChanger.GradeChange, -999999, 12);
        Hunger = Mathf.Clamp(Health + statChanger.HungerChange, -999999, 100);
        Social = Mathf.Clamp(Health + statChanger.SocialChange, -999999, 100);
        MacCoins = Mathf.Clamp(Health + statChanger.MacCoinsChange, -999999, 9999999);
    }

    public void NewSemester()
    {
        Health = 50;
        Grade = 8;
        Hunger = 50;
        Social = 50;
        MacCoins = 4000;
    }
}
