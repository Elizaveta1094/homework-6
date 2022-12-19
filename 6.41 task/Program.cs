// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] FillArray(int size)
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(-100,100);
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int count = 0;
Console.WriteLine(string.Join(", ", array));
for(int i = 0; i < array.Length; i++)
{
if(array[i] > 0)
{
count ++;
}
}
Console.WriteLine(count);