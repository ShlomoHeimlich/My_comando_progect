using System.Collections.Generic;
namespace comando
{
    public class factory
    {
        public List<AirComando> list_AirComando = new List<AirComando>();
        public List<SeaCommando> list_SeaCommando = new List<SeaCommando>();
        public List<Commando> list_comands = new List<Commando>();
        public void Factory_Commando(string name, string kod)
        {
            list_comands.Add(new Commando(name, kod));
        }
        
        public void Factory_SeaCommando(string name, string kod)
        {
            list_SeaCommando.Add(new SeaCommando(name, kod));
        }
        
        public void Factory_AirComando(string name, string kod)
        {
            list_AirComando.Add(new AirComando(name, kod));
        }
    }
}