// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


System.Console.WriteLine("Введите числа m и n (через , или пробел):");
char[] separators = { ' ', ',', ';' };
int[] mn = Array.ConvertAll(Console.ReadLine()!.Split(separators), int.Parse);

if (mn[0] > mn[1])
    (mn[0], mn[1]) = (mn[1], mn[0]);
System.Console.Write("Четные числа диапазона : ");
Task(mn[0], mn[1]);



void Task(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0 & m > 0) System.Console.Write(m + " ");
    Task(m + 1, n);
}



