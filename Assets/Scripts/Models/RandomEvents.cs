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
            new Event("Breakup", "Your significant other breaks up with you", healthChange: -20),
            new Event("Assignment Extension", "Prof gives the class an extension on an assignment", gradeChange: 5, socialChange: 5),
            new Event("Rough Midterm", "Midterm does not resemble at all the practise midterms", gradChange: -10, healthChange: -5),
            new Event("Leaky roof", "Your ceiling in your student house starts leaking", healthChange: -5),
            new Event("Grocery Day", "Its Tuesday so 10% off at Fortinos", hungerChange: 10, healthChange: 5, MacCoinsChange: -20),
            new Event("Flat tire", "Your run over a broken beer bottle on your bike", healthChange: -5, MacCoinsChange: -10),
            new Event("Sick Midterm", "A pretty bad cold comes upon you during midterm season", healthChange: -20, gradeChange: -10, socialChange: -10),
            new Event("Death", "There is a sudden death in the family.", healthChange: -5, gradeChange: -10)
            new Event("A nice friend", "A friend buys your food!", socialChange: 5, hungerChange: 5),
            new Event("Group Carry", "Your group member carries you for a project", gradeChange: 10, socialChange: 5)
        };
    }
}
