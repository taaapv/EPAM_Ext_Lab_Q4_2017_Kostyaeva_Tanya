using System;

/*Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.
Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]».*/

namespace decision
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите букву графика (а - к)");
                string contur = string.Concat(Console.ReadLine());
                                      
                if (contur == "а" || contur == "А") //фигура А
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

                if (contur == "б" || contur == "Б") //фигура Б
                {
                    if ((((Math.Abs(x * x) + Math.Abs(y * y)) <= 1) && (Math.Abs(x * x) + Math.Abs(y * y)) >= 0.25)) 
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }
                    throw new ApplicationException();
                }

                if (contur == "в" || contur == "В") //фигура В
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


                if (contur == "г" || contur == "Г") //фигура Г
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


                if (contur == "д" || contur == "Д") //фигура Д
                {
                    if ((Math.Abs(x) + 0.5 * Math.Abs(y)) <= 0.5)  
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }
                    throw new ApplicationException();
                }


                if (contur == "е" || contur == "Е") //фигура Е
                {
                    if ((x >= 0) && (x * x + y * y <= 1) || (x < 0) && (x >= -2) && (Math.Abs(x) + 2 * Math.Abs(y) <= 2))   
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }
                    throw new ApplicationException();
                }


                if (contur == "ж" || contur == "Ж") //фигура Ж
                {
                    if (((y + 2 * x) <= 2) && ((y - 2 * x) <= 2) && (y >= -1) && (y <= 2))   
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }
                    throw new ApplicationException();
                }

                if (contur == "з" || contur == "З") //фигура З
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

                if (contur == "и" || contur == "И") //фигура И
                {
                    if (((y > 0) && (x + y <= 0) && (y - 2 * x <= 3)) || ((y <= 0) && ((y - 2 * x) <= 3) && ((x - 3 * y) <= 1)))
                    {
                        MessageEnable(x, y, contur);
                    }
                    else
                    {
                        MessageDisable(x, y, contur);
                    }
                    throw new ApplicationException();
                }

                if (contur == "к" || contur == "к") //фигура К
                {
                    if (((y >= 1) && (x <= 1)) || ((y >= 1) && (x >=1 )) || ((x <= y) && (x > -1) && (x < 1)) || (x + y >= 0) && ((x > -1) && (x < 1)))
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
                              
            }
            catch (SystemException ex)
            {
                Console.WriteLine('\n' + $"Ошибка ввода данных: {ex}!" + '\n');
            }
        }
        
        static void MessageEnable (double x, double y, string text)
        {
            Console.WriteLine('\n' + $"Точка [{x}; {y}] принадлежит фигуре [{text}]" + '\n' + '\n');
        }
        
        static void MessageDisable (double x, double y, string text)
        {
            Console.WriteLine('\n' + $"Точка [{x}; {y}] не принадлежит фигуре [{text}]" + '\n' + '\n');
        }
    }
}      
    

