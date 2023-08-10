// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = GetNum ("Введите число m");
int n = GetNum ("Введите число n");
int GetResult = Akermann(m,n);

Console.WriteLine($"m = {m} , n = {n} -> A (m,n) = {GetResult}");


int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int Akermann(int m, int n) 
{
    if (m == 0)
        return n + 1;
    if ( n==0 && m>0 )
        return Akermann(m - 1, 1);
    else
        return Akermann(m - 1, Akermann(m, n - 1));
}
    
        