using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomEventsController : MonoBehaviour
{

    public RandomEvents randomEventsList;
    public static Event[] events;
    public OutputMessageController outputMessageController;

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

    public void randomEventOccur()
    {
        Event eventToOccur = events[Random.Range(0, 11)];
        string updateString = GameData.Instance.CharacterStats.ApplyStatChanges(eventToOccur);
        outputMessageController.message = eventToOccur.Name + "\n" + eventToOccur.Description + "\n" + updateString;
        // Write to console for now, should be sending to output messege
        Debug.Log(eventToOccur.Name + "\n" + eventToOccur.Description);
    }
}
