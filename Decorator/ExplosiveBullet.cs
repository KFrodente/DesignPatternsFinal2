using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal2.Decorator
{
    internal class ExplosiveBullet : BulletDecorator
    {
        public ExplosiveBullet(IBullet bullet) : base(bullet)
        {
        }

        public override void getType()
        {
            Console.Write("EXPLOSIVE ");
            base.getType();
        }
    }
}
