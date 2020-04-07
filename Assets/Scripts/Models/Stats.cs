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

public class Stats
{
    public CharacterType characterType;
    public int health;
    public int grade;
    public int hunger;
    public int social;
    public int macCoins;
    public int semesterCount;

    public Stats()
    {
        this.characterType = CharacterType.PartyAnimal;
        this.health = 50;
        this.grade = 50;
        this.hunger = 50;
        this.social = 50;
        this.macCoins = 0;
        this.semesterCount = 0;
    }

    public void setCharacterType(string type)
    {
        //this.characterType = CharacterType.
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public void setGrade(int grade)
    {
        this.grade = grade;
    }

    public void setHunger(int hunger)
    {
        this.hunger = hunger;
    }

    public void setSocial(int social)
    {
        this.social = social;
    }

    public void getDisplayInfo()
    {
        // return
    } 

    public void subtractMacCoins(int amount)
    {
        this.macCoins -= amount;
    }

    public void addMacCoints(int amount)
    {
        this.macCoins += amount;
    }

    public int getMacCoins()
    {
        return this.macCoins;
    }

    public int getSemesterCount()
    {
        return this.semesterCount;
    }
    
    public void incrementSemesterCount()
    {
        this.semesterCount += 1;
    }
}
