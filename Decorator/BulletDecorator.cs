using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal2.Decorator
{
    internal abstract class BulletDecorator : IBullet
    {
        protected IBullet bullet;

        public BulletDecorator(IBullet bullet)
        {
            this.bullet = bullet;
        }

        public virtual void getType()
        {
            bullet.getType();
        }
    }
}
