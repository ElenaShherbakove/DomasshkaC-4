//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Step(int A, int B)
{
int step = 1;
for(int i = 1; i <= B; i++)
{
step = step * A; 
}
return step;
}
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Возведение А в степень В: " + Step(A,B));