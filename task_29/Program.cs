// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int DataInput(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(2, 8);
    }
    return array;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}
int[] array = new int[8];
array = FillArray(array);
PrintArray(array);
