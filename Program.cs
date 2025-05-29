using DesignPatternsFinal2.Singleton;

namespace DesignPatternsFinal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = Gun.getInstance();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                if (keyInfo.Key == ConsoleKey.F)
                {
                    gun.FireBullet();
                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    gun.FreshReload();
                }
                if (keyInfo.Key == ConsoleKey.T)
                {
                    gun.CoatWithFlame();
                }
                if (keyInfo.Key == ConsoleKey.G)
                {
                    gun.CoatWithExplosive();
                }
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
