using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTest unitTest = new UnitTest();
            unitTest.RunUnitTest();

            Console.WriteLine("Inheritance");
            Console.WriteLine();

            Player player = new Player();
            Enemy enemy = new Enemy();
            //GameCharacter gameCharacter = new GameCharacter(); 

            player.health = 100;
            Console.WriteLine("player health: " + player.health);
            player.TakeDamage(50);
            Console.WriteLine("player health: " + player.health);

            enemy.health = 50;
            Console.WriteLine("enemy health: " + enemy.health);
            enemy.TakeDamage(25);
            Console.WriteLine("enemy health: " + enemy.health);

            Console.ReadKey(true);
        }
    }
}
