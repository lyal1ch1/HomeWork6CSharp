
Console.WriteLine("Сколько чисел вы хотите ввести?");
int length = int.Parse(Console.ReadLine()!);
int count = 0;
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите " + (i+1) + "-ое число");
    int num = int.Parse(Console.ReadLine()!);
    if (num > 0)
    {
        count++;
    }
}
if (count % 10 == 0 || count % 10 >= 5)
{
   Console.WriteLine("Вы ввели " + count + " чисел больше 0"); 
} 
if (count % 10 == 1)
{
 Console.WriteLine("Вы ввели " + count + " число больше 0");
} 
if (count % 10 > 1 && count % 10 < 5 )
{
 Console.WriteLine("Вы ввели " + count + " числа больше 0");
} 
