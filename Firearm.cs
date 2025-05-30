using comando;

public class Firearm: Ifirearm, Imanufacturer, IWeapon
{
    public string manufacturer { set; get; }
    public string name { get; set; }
    public int number_of_balls { get; set; }
    public Firearm(string name, string manufacturer, int number_of_balls)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.number_of_balls = number_of_balls;
    }
    public void Shoot()
    {
        Console.WriteLine("shooting");
        number_of_balls -= 1;
        Console.WriteLine($"{number_of_balls}");
    }
    public void Use()
    {
        Console.WriteLine("i am a Firearm");
    }
}