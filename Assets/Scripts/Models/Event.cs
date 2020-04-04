
public class Event : StatChanger
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Item(string name, string description, int healthChange = 0,
        int gradeChange = 0, int hungerChange = 0, int socialChange = 0, int macCoinsChange)
    {
        Name = name;
        Description = description;

        // Properties inherited from StatChanger
        HealthChange = healthChange;
        GradeChange = gradeChange;
        HungerChange = hungerChange;
        SocialChange = socialChange;
        MacCoinsChange = macCoinsChange;
    }

}
