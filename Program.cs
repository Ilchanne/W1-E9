Console.WriteLine("Введите ваш Вес");
double v = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ваш Рост (см)");
double r = Convert.ToDouble(Console.ReadLine());
r = r / 100;
double imt = Math.Round(v / Math.Pow(r, 2),2) ;
Console.WriteLine($"Имт равен {imt}");