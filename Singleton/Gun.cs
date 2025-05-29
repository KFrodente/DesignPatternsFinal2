
namespace DesignPatternsFinal2.Singleton
{
    internal class Gun
    {
        private Gun() { }

        private static Gun? instance;

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
            Console.WriteLine("bang bang!");
        }
    }
}
