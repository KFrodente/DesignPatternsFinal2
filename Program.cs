using DesignPatternsFinal2.Command;
using DesignPatternsFinal2.Singleton;

namespace DesignPatternsFinal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = Gun.getInstance();
            InputHandler inputHandler = new InputHandler();

            inputHandler.BindCommand(ConsoleKey.F, () => gun.FireBullet());
            inputHandler.BindCommand(ConsoleKey.R, () => gun.FreshReload());
            inputHandler.BindCommand(ConsoleKey.T, () => gun.CoatWithFlame());
            inputHandler.BindCommand(ConsoleKey.G, () => gun.CoatWithExplosive());

            inputHandler.Listen();
        }
    }
}
