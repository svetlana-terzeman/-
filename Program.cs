using static System.Console;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введтите своё имя ");
            string name = ReadLine();
            WriteLine($"Hello, {name}!");
            
        }
    }
}
