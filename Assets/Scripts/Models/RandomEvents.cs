using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RandomEvents
{
    public Event[] Events { get; private set; }

    public RandomEvents()
    {
        // TODO: Add more events and shuffle them
        Events = new Event[]
        {
            new Event("Coronavirus", "Time for social distancing", socialChange: -30, gradeChange: 10),
            new Event("Free food at MUSC", "Wooohoooo", socialChange: 5, hungerChange: 5),
        };
    }
}
