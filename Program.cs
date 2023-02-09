//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};


int MAXLENGTH = 3;
		
string[] ShorArray1(string[] array)
{
    int length = array.Length;			
    string[] result = new string[length];
    int count = 0;

for (int i = 0; i < length; i++)
{
    if(array[i].Length <= MAXLENGTH)
    {
        result[count] = array[i];
        count++;
    }
}

Array.Resize(ref result, count);
return result;
}

void PrintArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("В массиве нет требуемых элементов");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}
		
void PrintTask(string[] array)
{
    Console.WriteLine("Дан массив:");
    PrintArray(array);
    string[] shortArray = ShorArray1(array);
    Console.WriteLine($"Полученный массив из элементов с символами <= {MAXLENGTH}:");
    PrintArray(shortArray);
    Console.WriteLine();
}
		
PrintTask(array1);
PrintTask(array2);
PrintTask(array3);
