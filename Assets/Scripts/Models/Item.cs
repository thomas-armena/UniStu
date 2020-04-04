
public class Item : StatChanger
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Item(string name, string description, int price,  
        int healthChange = 0, int gradeChange = 0, int hungerChange = 0, int socialChange = 0)
    {
        Name = name;
        Description = description;
        HealthChange = healthChange;
        GradeChange = gradeChange;
        HungerChange = hungerChange;
        SocialChange = socialChange;
        MacCoinsChange = price;
    }

}

