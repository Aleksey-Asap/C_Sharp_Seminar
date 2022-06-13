// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру. 
//  3 -> Среда 5 -> Пятница
int n = int.Parse(Console.ReadLine());
if (n == 3)
{
    Console.WriteLine("Среда");
}
else
    if (n == 5)
    {
    Console.WriteLine("Пятница");
    }
    else
    {
    Console.WriteLine("остальные дни недели");
    }