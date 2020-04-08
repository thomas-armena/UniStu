using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{

    public Text healthText;
    public Text gradeText;
    public Text hungerText;
    public Text socialText;
    public Text macCoinsText;
    public Text characterTypeText;

    void Start()
    {
        healthText.text = "Health: "+GameData.Instance.CharacterStats.Health.ToString();
        gradeText.text = "Grade: "+GameData.Instance.CharacterStats.Grade.ToString();
        hungerText.text = "Hunger: "+GameData.Instance.CharacterStats.Hunger.ToString();
        socialText.text = "Social: "+GameData.Instance.CharacterStats.Social.ToString();
        macCoinsText.text = "Mac Coins: "+GameData.Instance.CharacterStats.MacCoins.ToString();
        characterTypeText.text = "Character Type: " + getCharTypeName(GameData.Instance.CharacterStats.CharacterType);
    }

    void Update()
    {
        healthText.text = "Health: "+GameData.Instance.CharacterStats.Health.ToString();
        gradeText.text = "Grade: "+GameData.Instance.CharacterStats.Grade.ToString();
        hungerText.text = "Hunger: "+GameData.Instance.CharacterStats.Hunger.ToString();
        socialText.text = "Social: "+GameData.Instance.CharacterStats.Social.ToString();
        macCoinsText.text = "Mac Coins: "+GameData.Instance.CharacterStats.MacCoins.ToString();
        characterTypeText.text = "Character Type: " + getCharTypeName(GameData.Instance.CharacterStats.CharacterType);
    }

    string getCharTypeName(CharacterType characterType)
    {
        switch (characterType)
        {
            case CharacterType.PartyAnimal:
                return "Party Animal";
            case CharacterType.GymRat:
                return "Gym Rat";
            case CharacterType.Bookworm:
                return "Book Worm";
            case CharacterType.CentroConnoisseur:
                return "Centro Connoisseur";
            default:
                return "Party Animal";
        }
    }
}
