using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEventsController : MonoBehaviour
{

    RandomEvents randomEventsList;
    Event[] events;
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

    public Event chooseRandomEvent()
    {
        return events[Random.Range(0, 11)];
    }

    public void randomEventOccur(Event eventToOccur)
    {
        
    }
}
