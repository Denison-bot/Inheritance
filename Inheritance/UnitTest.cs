using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class UnitTest
    {
        public void RunUnitTest()
        {
            Player player = new Player();
            player.UnitTest();
            Enemy enemy = new Enemy();
            enemy.UnitTest();
        }
    }
}
