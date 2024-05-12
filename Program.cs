// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Метод для ввода исходного массива
void input_array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine()!;
    }
}

// Метод для подсчета элементов исходного масиива длиной меньше, либо равной 3
int res_strings_mumber(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    return n;
}

// Метод для формирования массива элементов длиной меньше, либо равной 3
string[] resultArr(string[] array, int n)
{
    string[] Rezult_arr = new string[n];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Rezult_arr[j] = array[i];
            j++;
        }
    }
    return Rezult_arr;
}

// Метод для вывода результата
void print_array(string[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}


void Main()
{
    Console.Write("Введите количество элементов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[m];
    input_array(stringArray);
    print_array(resultArr(stringArray, res_strings_mumber(stringArray)));
}
Main();