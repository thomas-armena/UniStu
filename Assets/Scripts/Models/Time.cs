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

public class Time
{
    public int Semester { get; private set; }
    public int DayOfSemester { get; private set; }
    public PortionOfDay TimeOfDay { get; private set; }

    public Time(int semester = 1, int dayOfSemester = 1, PortionOfDay portionOfDay = TimeOfDay.Morning)
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
                TimeOfDay = TimeOfDay.Noon;
                break;
            case PortionOfDay.Noon:
                TimeOfDay = TimeOfDay.Evening;
                break;
            case PortionOfDay.Evening:
                TimeOfDay = TimeOfDay.Night;
                break;
            case PortionOfDay.Night:
                DayOfSemester++;
                TimeOfDay = TimeOfDay.Morning;
                break;
            default:
                break;
        }

    }
}
