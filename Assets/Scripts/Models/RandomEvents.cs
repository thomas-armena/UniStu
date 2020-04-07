using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents
{
    public Event[] Events { get; private set; }

    public RandomEvents()
    {
        Events = new Event[]
        {
            new Event("Coronavirus", "Time for social distancing.", socialChange: -20, gradeChange: 2),
            new Event("Free Food", "Free food at MUSC!", socialChange: 5, hungerChange: 10),
            new Event("Breakup", "Your significant other breaks up with you.", healthChange: -5, socialChange: -5),
            new Event("Assignment Extension", "Professor gives the class an extension on an assignment.", gradeChange: 1, socialChange: 5),
            new Event("Rough Midterm", "Midterm does not resemble at all the practise midterms.", gradeChange: -1),
            new Event("Leaky roof", "Your ceiling in your student house starts leaking.", healthChange: -5),
            new Event("Grocery Day", "Its Tuesday so 10% off at Fortinos.", hungerChange: 10, healthChange: 5, macCoinsChange: -100),
            new Event("Flat tire", "You run over a broken beer bottle on your bike.", healthChange: -5, macCoinsChange: -10),
            new Event("Sick Midterm", "A pretty bad cold comes upon you during midterm season.", healthChange: -10, gradeChange: -1, socialChange: -10),
            new Event("Death", "There is a sudden death in the family.", healthChange: -5, gradeChange: -1),
            new Event("A nice friend", "A friend buys your food!", socialChange: 7, hungerChange: 7),
            new Event("Group Carry", "Your group member carries you for a project.", gradeChange: 1, socialChange: 5),
            new Event("Gym", "Went to the gym three times in a row", healthChange: 20),
            new Event("Midterm Curve", "A tough midterm was curved!", healthChange: 5, gradeChange: 1),
            new Event("Midterm Cramming", "Your so busy cramming for a midterm you forget to eat", hungerChange: -10, socialChange: -5)
        };
    }
}
