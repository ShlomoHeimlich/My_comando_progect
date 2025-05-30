using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
namespace comando
{
    public class enemie
    {
        string name;
        public int life = 100;
        bool status = true;
        string shout = "I am an enemy.";
        public enemie(string name)
        {
            this.name = name;
        }

    }
    public class creat_enemi
    {
        public List<enemie> list_enemi = new List<enemie>();
        public void Creat_enemi(string name)
        {

            list_enemi.Add(new enemie(name));
        }
    }
}

    



