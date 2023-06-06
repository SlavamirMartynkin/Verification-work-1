//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//        длина которых меньше, либо равна 3 символам


string [] array = new string[5];
string[] FillArray(string [] array)
{
    int Length = array.Length;
    int index = 0;
    while (index < Length)
    {
        System.Console.Write("Введите строку: ");
        array[index] = Console.ReadLine();
        index++;
    }
    return array;
}


string[] NewArray(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++; 
    }
    
    string [] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
System.Console.WriteLine($"[{string.Join(", ", FillArray(array))}]");
System.Console.WriteLine($"[{string.Join(", ", NewArray(array))}]");


