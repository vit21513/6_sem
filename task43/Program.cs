//Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double b1 = UserInputInt("Введите b1");
double k1 = UserInputInt("Введите k1");
double b2 = UserInputInt("Введите b2");
double k2 = UserInputInt("Введите k2");


//double b1 = 2; double k1 = 5; double b2 = 4; double k2 = 9;  /// для проверки
if (b2 == b1 || k1 == k2) Console.WriteLine("Прямые не пересекаются");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"координаты точки пересечения составляют x = {x} y= {y}");
}
