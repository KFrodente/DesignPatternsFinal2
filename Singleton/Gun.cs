
using DesignPatternsFinal2.Decorator;

namespace DesignPatternsFinal2.Singleton
{
    internal class Gun
    {
        private Gun() { }

        private static Gun? instance;

        private IBullet bullet;

        public static Gun getInstance()
        {
            if (instance == null)
            {
                instance = new Gun();
            }
            
            return instance;
        }


        public void FireBullet()
        {
            if (bullet == null)
            {
                Console.WriteLine("MUST RELOAD WITH 'R' BEFORE FIRING!");
            }
            else
            {
                Console.Write("FIRED ");
                bullet.getType();
            }
        }


        public void FreshReload()
        {
            Console.WriteLine("RELOADING");
            bullet = new BasicBullet();
        }

        public void CoatWithFlame()
        {
            Console.WriteLine("BULLET COATED IN FLAME");
            bullet = new FlameBullet(bullet);
        }

        public void CoatWithExplosive()
        {
            Console.WriteLine("BULLET COATED IN EXPLOSIVE");
            bullet = new ExplosiveBullet(bullet);
        }
    }
}
