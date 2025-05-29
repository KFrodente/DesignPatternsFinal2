using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal2.Decorator
{
    internal class FlameBullet : BulletDecorator
    {
        public FlameBullet(IBullet bullet) : base(bullet)
        {
        }

        public override void getType()
        {
            Console.Write("FLAME ");
            base.getType();
        }
    }
}
