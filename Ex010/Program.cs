/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);

if(number >= 100 && number <= 999)
{
    int result = Math.Abs(number / 10 % 10); 
    Console.WriteLine($"Вторая цифра трехзначного числа {result}");
}
else
{
    Console.WriteLine($"Данные не верные ");
}
