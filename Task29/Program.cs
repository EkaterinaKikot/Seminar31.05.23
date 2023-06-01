Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
array[0] = 1;
array[1] = 2;
array[2] = 5;
array[3] = 7;
array[4] = 19;
array[5] = 6;
array[6] = 1;
array[7] = 33;
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
