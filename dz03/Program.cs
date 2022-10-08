Console.WriteLine("Введите номер четверти: ");
int T = int.Parse(Console.ReadLine());

Console.WriteLine("Вывод диапазона координат: ");
if (T == 1)
    Console.WriteLine("x > 0 ; y > 0");
else if (T == 2)
    Console.WriteLine("x < 0 ; y > 0");
else if (T == 3)
    Console.WriteLine("x < 0 ; y < 0");
else
    Console.WriteLine("x > 0 ; y < 0");
