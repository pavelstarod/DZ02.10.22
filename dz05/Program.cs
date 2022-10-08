Console.WriteLine("Введите координаты x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("введите координаты z3: ");
double z2 = double.Parse(Console.ReadLine());



double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.WriteLine("Вывод расстояния между точками на плоскости: " + result);

double result2 = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine("Вывод расстояния между точками в пространстве: " + result2);

