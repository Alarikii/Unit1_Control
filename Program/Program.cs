void PrintArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + "   ");
        
    }
    Console.WriteLine();
}

// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
string[] array = { "hello", "2", "world", ":-)" };
PrintArray(array);
string[] array2 = new string[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}
array2 = array2.Where(x => !string.IsNullOrEmpty(x)).ToArray();

PrintArray(array2);


