using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesignPatternsFinal2.Command
{
    internal class InputHandler
    {
        private Dictionary<ConsoleKey, Action> commands = new();

        public void BindCommand(ConsoleKey key, Action command)
        {
            commands[key] = command;
        }

        public void Listen()
        {
            while (true)
            {
                var key = Console.ReadKey(intercept: true).Key;

                if (commands.TryGetValue(key, out var command))
                {
                    command.Invoke();
                }
                else
                {
                    Console.WriteLine($"Unrecognized key: {key}");
                }
            }
        }
    }
}
