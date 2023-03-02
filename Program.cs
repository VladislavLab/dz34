// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetArray(int size, int MinValue, int MaxValue)
{
    int[] ResAr=new int[size];
    for(int i=0; i<size;i++)
    {
        ResAr[i]=new Random().Next(MinValue,MaxValue+1);
    }
    return ResAr;
}
int EvenNumberArray(int[] array)
{
    int result=0;
    foreach(int el in array)
    {
        if(el % 2 ==0) result++;
    }
    // for (int i=0;i<array.Length;i++)
    // {
    //     if(array[i]%2==0)result++;
    // }
    return result;
}
int[] array=GetArray(10,100,1000);
Console.Write(String.Join(", ", array));
int result=EvenNumberArray(array);
Console.WriteLine($"->{result} ");