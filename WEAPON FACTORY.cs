using System.Collections.Generic;
using System.Xml.Linq;
namespace comando
{

    public class FACTORY_WEAPON
    {
          public  List<IWeapon> list_weapon = new List<IWeapon>();
          
        public void FACTORY_Firearm(string name, string manufacturer, int number_of_balls)
        {

            list_weapon.Add(new Firearm(name, manufacturer, number_of_balls));

        }
        public void FACTORY_Stone(string color, int weight)
        {

            list_weapon.Add(new Stone(color, weight));
        }
        public void Knife(string color, int weight, string manufacturer, string type)
        {

            list_weapon.Add(new Knife(color, weight, manufacturer, type));
        }

    }

}

