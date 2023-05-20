// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int GetPositiveNumbers(int[] array)
{
    int count = 0;
    {
        for(int i=0; i< array.Length; i++)
        {
            if(array[i] >= 0)
            {
                count+=1;
            }
        }
    }
    return count;
}

// промт для ввода длинны массива и заполнения значениями 
int Prompt(string massage)
{
    System.Console.Write(massage);
    string stringInput = System.Console.ReadLine()!;
    int result = Int32.Parse(stringInput);
    return result;
}
// ввод массива 
int[] EnterArray(int Length )
{
    int[] array = new int [Length];
    int digit = 1;
    for(int i=0; i <array.Length; i++)
    {
        int numbers = Prompt($"Введите {digit} цифру в массиве: ");
        array[i] = numbers;
        digit++;
    }
    return array;
}
// печать массива в консоль
void PrintArray(int[] array)
{
    System.Console.Write("{");
    for(int i =0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length -1]}");
    System.Console.WriteLine("}");
}


int length = Prompt("Введите длинну массива: "); // ввод длины массива
int[] array = EnterArray(length);                // создание переменной для хранения массива на основании метода
PrintArray(array);                               // печать массива
Console.WriteLine(GetPositiveNumbers(array));    // печать результата функции по нахождению положительных чисел 