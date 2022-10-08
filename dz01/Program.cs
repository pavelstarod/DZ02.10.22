Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine());

if (n%6 == 0) 
    Console.WriteLine("День недели выходной");
else if (n%7 == 0)
       Console.WriteLine("День недели выходной");
else 
        Console.WriteLine("День недели будний");