Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
double x = 0;
double y = 0;
if (k1 == k2 && b1 == b2)
{
   Console.WriteLine(" Эти прямые совпадают"); 
}
if (k1 == k2)
{
    
   Console.WriteLine(" Прямые параллельны! Они не пересекаются!");  

}

else
{
double intersectionXOfStraightLines(double k1, double b1, double k2, double b2)
{
   
    x = (b2 - b1) / -(k2 - k1);
    x = Math.Round(x,3);
    return x;
}
double intersectionYOfStraightLines(double k1, double b1)
{
    
    y = k1*x +b1;
    y = Math.Round(y,3);
    return y;
}
Console.WriteLine();
Console.Write("Точка пересечения данных прямых: (" + intersectionXOfStraightLines(k1, b1,k2,b2) + ";");
Console.Write(intersectionYOfStraightLines(k1, b1) + ")");
}