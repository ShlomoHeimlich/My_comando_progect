using System;
using System.Runtime.InteropServices;
namespace comando
{

    public class AirComando : Commando
    {
        public AirComando(string name, string kod) : base(name, kod) { }
        public void writ()
        {
            Console.WriteLine("iiiii");
        }
        public override void Attack()
        {
            Console.WriteLine("air tocffff");
        }
    }
}
  