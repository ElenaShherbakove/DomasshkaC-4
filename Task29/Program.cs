// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index =0;
    while (index < length)
    {
    collection[index] = new Random().Next(0, 10);
    index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"[{string.Join(", ", coll)}]");
        position ++;
        break;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

