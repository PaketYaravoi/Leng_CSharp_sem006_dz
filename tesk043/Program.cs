// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями  a = k1 * x + b1, b = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string massage)
{
    Console.Write(massage);
    string stringInput = Console.ReadLine()!;
    double result = Convert.ToDouble(stringInput);
    return result;     
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double differenceK = k2 - k1;
    double differenceB = b2 - b1;
    differenceK = -differenceK;
    double X = differenceB / differenceK;
    double Y = k1 * X + b1;
    double[] answer = new double [2] {X, Y};
    return answer;
}

double b1 = Prompt("Введите b1: ");   // смещение по оси x
double k1 = Prompt("Введите k1: ");   // угол наколона прямой a
double b2 = Prompt("Введите b2: ");   // смещение по оси y
double k2 = Prompt("Введите k2: ");   // угол наколона прямой b

double[] answer =  IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine(answer[0]);
Console.WriteLine(answer[1]);



