using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float timeNumber;

    public Text semesterText;
    public Text daysText;
    public Text partOfDayText;

    public Event rent = new Event("Rent", "Rent taken from your account", macCoinsChange: -500);

    // Start is called before the first frame update
    void Start()
    {
        timeNumber = 10;

        semesterText.text = "Semester: "+GameData.Instance.CurrentTime.Semester.ToString();
        daysText.text = "Day of Semesterr: "+GameData.Instance.CurrentTime.DayOfSemester.ToString();
        partOfDayText.text = "Time Of Day: "+GameData.Instance.CurrentTime.TimeOfDay.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        semesterText.text = "Semester: "+GameData.Instance.CurrentTime.Semester.ToString();
        daysText.text = "Day of Semesterr: "+GameData.Instance.CurrentTime.DayOfSemester.ToString();
        partOfDayText.text = "Time Of Day: "+GameData.Instance.CurrentTime.TimeOfDay.ToString();

        timeNumber -= UnityEngine.Time.deltaTime;
        System.Console.WriteLine((int)System.Math.Round(timeNumber));

        if ((int)System.Math.Round(timeNumber) == 0)
        {
            GameData.Instance.CurrentTime.IncrementTime();
            timeNumber = 10;
            
            if (GameData.Instance.CurrentTime.DayOfSemester == 4 || 
            GameData.Instance.CurrentTime.DayOfSemester == 8 || 
            GameData.Instance.CurrentTime.DayOfSemester == 12 || 
            GameData.Instance.CurrentTime.DayOfSemester == 16)
            {
                GameData.Instance.CharacterStats.ApplyStatChanges(rent);
                RandomEventsController.randomEventOccur();
            }
        }

    }
}
