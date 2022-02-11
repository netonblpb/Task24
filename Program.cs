// Найти кубы чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


for (int i = 1; i <= num; i++)
{    
    Console.Write($"{i} в третьей степени равно {Math.Pow(i, 3)}");
    Console.WriteLine();        
}