// / Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Parse(string text){
    Console.Write(text);
    int output=Convert.ToInt32(Console.ReadLine());
    return output;
}
int m=Parse("Введите числа m ");
int n=Parse("Введите числа n ");

int SumNumber(int m,int n){
    if (m==n)
    return n;
    else return m + SumNumber(m + 1, n);
}
Console.Write($"Сумма от M до N равно {SumNumber(m,n)}");