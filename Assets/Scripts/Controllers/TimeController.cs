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
    public RandomEventsController randomEventsController;
    public MainWindowController mainWindowController;
    public OutputMessageController outputMessageController;



    // Start is called before the first frame update
    void Start()
    {
        timeNumber = 0.2f;

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
            mainWindowController.currentView = View.GameOver;
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
                    randomEventsController.randomEventOccur();
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
                mainWindowController.currentView = View.GameOver;
            } else if (gpa >= 4 && semesterCount < 8)
            {
                Debug.Log("Semester Passed! Starting a new semester!");
                GameData.Instance.CurrentTime.NewSemester();
                GameData.Instance.CharacterStats.NewSemester();
                outputMessageController.message = "Semester Passed! Starting a new semester!";

            } else if (gpa >= 4 && semesterCount == 2)
            {
                // Need a function here for Game Passed
                mainWindowController.currentView = View.GameOver;
                Debug.Log("asdfasdfasdfasdfasdfasdf");

            }
        }

        semesterText.text = "Semester: " + GameData.Instance.CurrentTime.Semester.ToString();
        daysText.text = "Day of Semesterr: " + GameData.Instance.CurrentTime.DayOfSemester.ToString();
        partOfDayText.text = "Time Of Day: " + GameData.Instance.CurrentTime.TimeOfDay.ToString();

    }
}
