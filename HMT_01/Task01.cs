/*Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.
Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]».*/
namespace Decision
{
    using System;

    public class Program
    {
        public static void MessageEnable(double x, double y, string text)
        {
            Console.WriteLine('\n' + $"Точка [{x}; {y}] принадлежит фигуре [{text}]" + '\n' + '\n');
        }

        public static void MessageDisable(double x, double y, string text)
        {
            Console.WriteLine('\n' + $"Точка [{x}; {y}] не принадлежит фигуре [{text}]" + '\n' + '\n');
        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите букву графика (а - к)");
                string contur = string.Concat(Console.ReadLine());

                ////фигура А
                if (contur == "а" || contur == "А")
                {
                    if ((x * x) + (y * y) <= 1)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура Б
                if (contur == "б" || contur == "Б")
                {
                    if (((Math.Abs(x * x) + Math.Abs(y * y)) <= 1) && (Math.Abs(x * x) + Math.Abs(y * y)) >= 0.25)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура В
                if (contur == "в" || contur == "В")
                {
                    if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура Г
                if (contur == "г" || contur == "Г")
                {
                    if ((Math.Abs(x) + Math.Abs(y)) <= 1)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура Д
                if (contur == "д" || contur == "Д")
                {
                    if (((Math.Abs(x) + 0.5) * Math.Abs(y)) <= 0.5)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура Е
                if (contur == "е" || contur == "Е")
                {
                    if (((x >= 0) && ((x * x) + (y * y) <= 1)) || ((x < 0) && (x >= -2) && (Math.Abs(x) + (2 * Math.Abs(y)) <= 2)))
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура Ж
                if (contur == "ж" || contur == "Ж")
                {
                    if (((y + (2 * x)) <= 2) && ((y - (2 * x)) <= 2) && (y >= -1) && (y <= 2))
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура З
                if (contur == "з" || contur == "З")
                {
                    if ((y <= 1) && (y >= -2) && (x <= 1) && (x >= -1) && (Math.Abs(x) + Math.Abs(y - 1)) >= 1)
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура И
                if (contur == "и" || contur == "И")
                {
                    if (((y > 0) && (x + y <= 0) && (y - (2 * x) <= 3)) || ((y <= 0) && ((y - (2 * x)) <= 3) && ((x - (3 * y)) <= 1)))
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }

                ////фигура К
                if (contur == "к" || contur == "к")
                {
                    if (((y >= 1) && (x <= 1)) || ((y >= 1) && (x >= 1)) || ((x <= y) && (x > -1) && (x < 1)) || ((x + y >= 0) && ((x > -1) && (x < 1))))
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }

                    throw new ApplicationException();
                }
                else
                {
                    Console.WriteLine('\n' + $"Графика с буквой '{contur}' не существует!" + '\n');
                    Console.ReadKey();
                }
            }
            catch (ApplicationException)
            {
                Console.WriteLine();
            }
            catch (SystemException ex)
            {
                Console.WriteLine('\n' + $"Ошибка ввода данных: {ex}!" + '\n');
            }
        }        
    }
}
