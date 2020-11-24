using System;

namespace дз
{
    class Задание_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите делимое ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите делитель ");
            string b = Console.ReadLine();
            var a1=Convert.ToInt32(a);
            var b1 = Convert.ToInt32(b);
            if((a1 is System.Int32)&&(b1 is System.Int32)&&(b1!=0)) 
            {
                double a2 = a1;
                double b2 = b1;
                Console.WriteLine(a2/b2);
            }
            else
            {
                Console.WriteLine("Некорректные данные ");
            }
        }
    }
}
