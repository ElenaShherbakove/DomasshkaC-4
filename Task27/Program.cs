// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sum(int number)
{
int sum = 0;
while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
return sum;
}
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех цифрр в числе A = {Sum(A)}");