using System;

namespace remote_containers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key");
            var key = Console.ReadKey();
            Console.WriteLine("Hello World! " + key.KeyChar);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
