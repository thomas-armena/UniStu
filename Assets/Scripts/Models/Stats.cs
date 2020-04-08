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

    public string ApplyStatChanges(StatChanger statChanger)
    {
        Health = Mathf.Clamp(Health+statChanger.HealthChange, -999999, 100);
        Grade = Mathf.Clamp(Grade + statChanger.GradeChange, -999999, 12);
        Hunger = Mathf.Clamp(Hunger + statChanger.HungerChange, -999999, 100);
        Social = Mathf.Clamp(Social + statChanger.SocialChange, -999999, 100);
        MacCoins = Mathf.Clamp(MacCoins + statChanger.MacCoinsChange, -999999, 9999999);

        string update = "Stat Changes: \n";
        if (statChanger.HealthChange != 0) update += "Health change: " + statChanger.HealthChange + "\n";
        if (statChanger.GradeChange != 0) update += "Grade change: " + statChanger.GradeChange + "\n";
        if (statChanger.HungerChange != 0) update += "Hunger change: " + statChanger.HungerChange + "\n";
        if (statChanger.SocialChange != 0) update += "Social change: " + statChanger.SocialChange + "\n";
        if (statChanger.MacCoinsChange != 0) update += "MacCoins change: " + statChanger.MacCoinsChange + "\n";
        return update;


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
