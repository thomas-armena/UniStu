using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PortionOfDay
{
    Morning,
    Noon,
    Evening,
    Night
}

[System.Serializable]
public class Time
{
    public int Semester { get; private set; }
    public int DayOfSemester { get; private set; }
    public PortionOfDay TimeOfDay { get; private set; }

    public Time(int semester = 1, int dayOfSemester = 1, PortionOfDay portionOfDay = PortionOfDay.Morning)
    {
        Semester = semester;
        DayOfSemester = dayOfSemester;
        TimeOfDay = portionOfDay;
    }

    public void IncrementTime()
    {

        switch (TimeOfDay)
        {
            case PortionOfDay.Morning:
                TimeOfDay = PortionOfDay.Noon;
                break;
            case PortionOfDay.Noon:
                TimeOfDay = PortionOfDay.Evening;
                break;
            case PortionOfDay.Evening:
                TimeOfDay = PortionOfDay.Night;
                break;
            case PortionOfDay.Night:
                DayOfSemester++;
                GameData.Instance.CharacterStats.ApplyStatChanges(new Event("Day update", "Day update", healthChange: Random.Range(-4, 3), gradeChange: Random.Range(-1, 2), hungerChange: Random.Range(-4, 3), socialChange: Random.Range(-4, 3), macCoinsChange: -10));
                TimeOfDay = PortionOfDay.Morning;
                break;
            default:
                break;
        }
    }

    public void NewSemester()
    {
        Semester++;
        DayOfSemester = 1;
        TimeOfDay = PortionOfDay.Morning;
    }
}
