//Вариант 20
using System;

namespace DZ_1_Smirnov_uts21_var20
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, S, T, n = 0;
            do
            {
                Console.WriteLine("Введите скорость первого автомобиля: ");
                V1 = int.Parse(Console.ReadLine());
                if(V1<0)
                {
                    Console.WriteLine("Невозможные входные данные. Попробуйте еще раз.");
                }else
                {
                    n = 1;
                }

            } while (n != 1);

            n = 0;
            do
            {
                Console.WriteLine("Введите скорость второго автомобиля: ");
                V2 = int.Parse(Console.ReadLine());
                if (V2 < 0)
                {
                    Console.WriteLine("Невозможные входные данные. Попробуйте еще раз.");
                }
                else
                {
                    n = 1;
                }

            } while (n != 1);

            n = 0;
            do
            {
                Console.WriteLine("Введите первоначальное расстояние между автомобилями: ");
                S = int.Parse(Console.ReadLine());
                if (S <= 0)
                {
                    Console.WriteLine("Невозможные входные данные. Попробуйте еще раз.");
                }
                else
                {
                    n = 1;  
                }

            } while (n != 1);

            n = 0;
            do
            {
                Console.WriteLine("Введите время через которое вы хотите узнать расстояние между автомобилями: ");
                T = int.Parse(Console.ReadLine());
                if (T < 0)
                {
                    Console.WriteLine("Невозможные входные данные. Попробуйте еще раз.");
                }
                else
                {
                    n = 1;
                }

            } while (n != 1);
            float S1 = S - (T * (V1 + V2));
            
            if (S1 > 0)
            {
                Console.WriteLine($"До встречи автомобилей осталось {S1} километров");
            }
            if (S1 == 0)
            {
                Console.WriteLine($"В данный момент времени автомобили встретились");
            }
            if (S1 < 0)
            {
                Console.WriteLine($"Автомобили встретились и разъехались на {Math.Abs(S1)} километров");
            }

        }
    }
}
