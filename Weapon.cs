using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace comando
{
    public interface Istone
    {
        string status { get; set; }
        int Number_of_strokes_remaining { get; set; }
        int Number_of_hits_so_far { get; set; }
    }
    public interface Icolor_and_weight
    {
        string color { get; set; }
        int weight { get; set; }
    }
    public interface IMetal_type_knife
    {
        string type { get; set; }
    }

    public interface Imanufacturer
    {
        string manufacturer { get; set; }
    }
    public interface Ifirearm
    {
        string name { get; set; }
        int number_of_balls { get; set; }
        public void Shoot();

}
    public interface IWeapon
    {
        void Use(); 
    }
}

