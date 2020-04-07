using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEventsController : MonoBehaviour
{

    public RandomEvents randomEventsList;
    public static Event[] events;
    // Random rnd = new Random();

    // Start is called before the first frame update
    void Start()
    {
        randomEventsList = new RandomEvents();
        events = randomEventsList.Events;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void randomEventOccur()
    {
        Event eventToOccur = events[Random.Range(0, 11)];
        GameData.Instance.CharacterStats.ApplyStatChanges(eventToOccur);

        // Write to console for now, should be sending to output messege
        Debug.Log(eventToOccur.Name + "\n" + eventToOccur.Description);
    }
}
