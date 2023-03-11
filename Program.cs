//Задача 2

Console.Clear();
Console.Write("BBедите число:  ");
int a =Convert.ToInt32(Console.ReadLine());

Console.Write("BBедите число:  ");
int b =Convert.ToInt32(Console.ReadLine());
int max;

  if (a > b)
            {
                Console.WriteLine($"Максимальное значение {max=a}");
                Console.WriteLine($"Минимальное значение {b}");               
               
            }
            else 
            {
                Console.WriteLine($"Максимальное значение {max = b}");
                Console.WriteLine($"Минимальное значение {a}");      
            }