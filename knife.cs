using comando;

public class Knife: Icolor_and_weight, IMetal_type_knife, Imanufacturer, IWeapon
{
    public string color { get; set; }
    public int weight { get; set; }
    public string manufacturer { get; set; }
    public string type { get; set; }

    public Knife(string color, int weight, string manufacturer,string type)
    {

        this.color = color;
        this.weight = weight;
        this.manufacturer = manufacturer;
        this.type = type;
    }
    public void Use()
    {
        Console.WriteLine("i am a Knife");
    }

}
