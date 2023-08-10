// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = GetNum ("Введите первое значение промежутка");
int n = GetNum ("Введите последнее значение промежутка");
int sum = SummNumb(m,n);

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {sum}");

int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int SummNumb(int m, int n)
{
    if (m <= n)
       return m + SummNumb(m + 1 , n);
    else
    return 0;
}