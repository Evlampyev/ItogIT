void PrintArray(string[] array) //Вывод строкового массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string [] ChangeArray(string [] array) //Поиск и формирование нового массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string [] anatherArray = new string [count];
    count = 0;
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            anatherArray[count] = array[i];
            count++;
        }
}
return anatherArray;
}

Console.Write("Input number of element ");
int number = Convert.ToInt32(Console.ReadLine());
string[] mainArray = new string[number];

for (int i = 0; i < number; i++)
{
    Console.Write($"Input {i + 1} element of array: ");
    mainArray[i] = Console.ReadLine();
}

Console.WriteLine("Current array: ");
PrintArray(mainArray);
Console.WriteLine();

string [] newArray = ChangeArray(mainArray);
Console.WriteLine("Modified array: ");
PrintArray(newArray);


