using System;

/*Программа должна выводить пользователю промежуточные вычисления (например, a, b, c и дискриминант (если вычисляли при помощи него) и корни (если есть)).*/

namespace decision
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                double a, b, c, d, x1, x2 = 0.0;               

                Console.WriteLine("Введите h: ");

                double h = double.Parse(Console.ReadLine());

                a = Math.Sqrt(((Math.Abs(Math.Sin(8 * h))) + 17) / Math.Pow((1 - Math.Sin(4 * h) * Math.Cos(h * h + 18)), 2));

                Console.WriteLine('\n' + $"Значение переменной a = {a}" + '\n');

                b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h))));

                Console.WriteLine($"Значение переменной b = {b}" + '\n');

                c = a * h * h * Math.Sin(b * h) + (b * h * h * h) * Math.Cos(a * h);

                Console.WriteLine($"Значение переменной c = {c}" + '\n');
                                
                d = (b * b) - (4 * a * c);

                x1 = (-b + Math.Sqrt(d)) / (2 * a);

                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                if (d >= 0)
                {
                    Console.WriteLine($"Дискриминант многочлена равен {d}!" + '\n' + '\n' + "Уравнение ax2 + bx + c = 0 имеет действительные корни!"  + '\n' + '\n' + $"Корень x1 = {x1}, Корень x2 = {x2}" + '\n' + '\n');                                    
                }
                else
                {
                    Console.WriteLine($"Дискриминант многочлена равен {d}!" + '\n' + '\n' + "Уравнение ax2 + bx + c = 0 действительных корней не имеет!" + '\n' + '\n');
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}" + '\n' + '\n' + "Необходимо устранить!");
            }
        }        
    }
}
