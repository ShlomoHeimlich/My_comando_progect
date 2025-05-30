using comando;

public class Stone: Istone, Icolor_and_weight, IWeapon
{
    
    public string color { get; set; }
    public int weight { get; set; }
    public string status { get; set; }
    public int Number_of_strokes_remaining { get; set; }
    public int Number_of_hits_so_far { get; set; }

    public Stone(string color,int weight)
    {
        
        this.color = color;
        this.weight = weight;
        Number_of_strokes_remaining = 5;
        Number_of_hits_so_far = 0;
        status = "whole";

    }
    public void Use()
    {
        Console.WriteLine("i am a ston");
    }
}