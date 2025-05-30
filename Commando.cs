using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace comando
{

    public class Commando
    {
        private string name;
        public string kod { get; set; }
        public string[] tools = new string[] { "Hammer", "chisel", "rope", "bag", "water", "bottle" };
        public string status = "stend";
        public Commando(string name, string kod)
        {
            this.name = name;
            this.kod = kod;
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine(name);
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine(kod);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public void Walk()
        {
            Console.WriteLine("The commando is going.");
            this.status = "Walk";
        }
        public void Hide()
        {
            Console.WriteLine("The commando is hiding.");
            this.status = "Hide";
        }
        public virtual void Attack()
        {
            Console.WriteLine($"Commando {kod} Attacker");
        }
    }
}
    


