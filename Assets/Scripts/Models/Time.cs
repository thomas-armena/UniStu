using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TimeOfDay
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
    public TimeOfDay TimeOfDay { get; private set; }

    public Time(int semester = 1, int dayOfSemester = 1, TimeOfDay timeOfDay = TimeOfDay.Morning)
    {
        Semester = semester;
        DayOfSemester = dayOfSemester;
        TimeOfDay = timeOfDay;
    }

    public void IncrementTime()
    {
        // TODO: Implement this
    }
}

