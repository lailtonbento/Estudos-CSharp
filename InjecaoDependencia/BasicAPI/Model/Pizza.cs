namespace basicapi.Model;

public class Pizza
{

    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsGlutenFree { get; set; }

    public Pizza(int id, string name, bool isGlutenFree)
    {
        Id = id;
        Name = name;
        IsGlutenFree = isGlutenFree;
    }
}