//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//
//0, 7, 8, -2, -2 -> 2
//
//-1, -7, 567, 89, 223-> 3


int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int[] CreateArrayInput(int size)// так как число M в задаче определяет пользователь, то создаем массив длиной в чило М
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        int index = i + 1;                           // пришлось добавить чтобы правильно печатал номер числа
        Console.WriteLine($"Введите {index} число");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

int SummPositNumbers(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) summ++;
    }
    return summ;
}

int m = UserInputInt("Введите количество чисел");
int[] array = CreateArrayInput(m);
int result = SummPositNumbers(array);
Console.WriteLine($" Количество положительных чисел равно {result}");
