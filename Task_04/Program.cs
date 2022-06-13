// 5. Напишите программу, которая на вход принимает
// одно число (N),
// а на выходе показывает все целые числа 
// в промежутке
// от -N до N. 
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/arithmetic-operators

// Console.WriteLine("Введите число ");
// int N = int.Parse(Console.ReadLine());
// int i = -N;
// while (i <= N)
// {
//     Console.Write(i + " ");
//     i++;
// }



// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает
// последнюю цифру этого числа.
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
if ((99 < A) & (A < 1000))
{
    Console.WriteLine(A % 10);
}
else
{
    Console.WriteLine("Необходимо ввести трехзначное число");
}