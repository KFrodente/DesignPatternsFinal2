using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal2.Decorator
{
    internal class BasicBullet : IBullet
    {
        public void getType()
        {
            Console.Write("BULLET\n");
        }
    }
}
