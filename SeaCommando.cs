using System;
namespace comando
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string kod) : base(name, kod) { }
        public void print()
        {
            Console.WriteLine("aaaa");
        }
        public override void Attack()
        {
            Console.WriteLine("sea yammm");
        }
    }
}