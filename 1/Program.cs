// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Parse(string text){
    Console.Write(text);
    int n=Convert.ToInt32(Console.ReadLine());
    return n;
}
string text="Введите значение n ";
int n=Parse(text);

void PrintNumber(int n){
    if (n==1)
    {
        Console.Write(n);
        return;
    }
    Console.Write(n + ", ");
    PrintNumber(n-1);
}
PrintNumber(n);
