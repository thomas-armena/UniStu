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
        timeNumber = 1;

        semesterText.text = "Semester: " + GameData.Instance.CurrentTime.Semester.ToString();
        daysText.text = "Day of Semesterr: " + GameData.Instance.CurrentTime.DayOfSemester.ToString();
        partOfDayText.text = "Time Of Day: " + GameData.Instance.CurrentTime.TimeOfDay.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeNumber -= UnityEngine.Time.deltaTime;

        if (GameData.Instance.CharacterStats.Health < 0 ||
        GameData.Instance.CharacterStats.Hunger < 0 ||
        GameData.Instance.CharacterStats.Social < 0)
        {
            // Fail game function here!
            Debug.Log("Stats dropped to low, game failed");
        }

        if ((int)System.Math.Round(timeNumber) == 0)
        {
            GameData.Instance.CurrentTime.IncrementTime();
            
            if (GameData.Instance.CurrentTime.TimeOfDay == PortionOfDay.Morning)
            {
                if (GameData.Instance.CurrentTime.DayOfSemester == 4 || 
                GameData.Instance.CurrentTime.DayOfSemester == 8 || 
                GameData.Instance.CurrentTime.DayOfSemester == 12 || 
                GameData.Instance.CurrentTime.DayOfSemester == 16)
                {
                    GameData.Instance.CharacterStats.ApplyStatChanges(rent);
                    RandomEventsController.randomEventOccur();
                }
            }

            timeNumber = 1;
        }

        if (GameData.Instance.CurrentTime.DayOfSemester == 21)
        {
            int gpa = GameData.Instance.CharacterStats.Grade;
            int semesterCount = GameData.Instance.CurrentTime.Semester;

            if (gpa < 4)
            {
                // Need function here for Game Over
                Debug.Log("Failed Game!!");
            } else if (gpa >= 4 && semesterCount < 8)
            {
                Debug.Log("Semester Passed! Starting a new semester!");
                GameData.Instance.CurrentTime.NewSemester();
                GameData.Instance.CharacterStats.NewSemester();

            } else if (gpa >= 4 && semesterCount == 8)
            {
                // Need a function here for Game Passed
                Debug.Log("Game Passed");
            }
        }

        semesterText.text = "Semester: " + GameData.Instance.CurrentTime.Semester.ToString();
        daysText.text = "Day of Semesterr: " + GameData.Instance.CurrentTime.DayOfSemester.ToString();
        partOfDayText.text = "Time Of Day: " + GameData.Instance.CurrentTime.TimeOfDay.ToString();

    }
}
