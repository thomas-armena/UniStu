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
    public int semester;
    public int dayOfSemester;
    public TimeOfDay timeOfDay;

    public Time()
    {
        this.semester = 1;
        this.dayOfSemester = 1;
        this.timeOfDay = TimeOfDay.Morning;
    }
}

