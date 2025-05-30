using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using System.Text.Json;

namespace comando
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Env.Load("C:\\Users\\HP\\Desktop\\c -sharp\\My_comando_progect\\.env");
            string apyKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            Console.WriteLine(apyKey);
            //Game game = new Game();
            //game.factory.Factory_Commando("HJ", "JHJ");
            //game.factory.Factory_AirComando("HJ", "JHJ");

            //game.enemyFactory.Creat_enemi("כעי");
            //game.wEAPON_FACTORY.WEAPON_FACTORY("m16","a",89);


            //Commando a1 = new Commando("mosh","1","Walk");
            ////a1.Attack();
            //Abstraction a2 = new Abstraction("mosh", "145678", "Walk");
            ////a2.Attack();
            //SeaCommando a3 = new SeaCommando("mosh", "145678", "Walk");
            ////a3.Attack();
            //Commando[] arr = new Commando[] { a1, a2, a3 };
            //foreach(Commando s in arr)
            //{
            //    s.Attack();
            //}
            ////a1.Walk();
            ////a1.Hide();
            ////a1.Attack();
            ////Weapon b1 = new Weapon("aa","s",100);
            ////b1.Shoot();
            //creat a1 = new creat();
            //a1.Creat_enemi("shlomo");
            //foreach(enemie s in a1.list_enemi)
            //{
            //    Console.WriteLine(s.life);
            //}
            //factory a1 = new factory();
            //a1.Factory_SeaCommando("shlomo", "1234");
            //a1.list_SeaCommando[0].Attack();
            //a1.list_SeaCommando[0].print();
            //factory a1 = new factory();
            //a1.Factory_SeaCommando("shlomo", "1234");
        }
    }
}



