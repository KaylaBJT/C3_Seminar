
Console.Write("Введите координату x для точки A: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату y для точки A: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату x для точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату y для точки B: ");
int yB = int.Parse(Console.ReadLine());
double distance = 0;



distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
Console.WriteLine(distance);