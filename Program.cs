// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите K1: ");
// float K1 = float.Parse(Console.ReadLine()!);

// Console.Write("Введите K2: ");
// float K2 = float.Parse(Console.ReadLine()!);

// Console.Write("Введите B1: ");
// float B1 = float.Parse(Console.ReadLine()!);

// Console.Write("Введите B2: ");
// float B2 = float.Parse(Console.ReadLine()!);

// float X = (B2 - B1) / (K1 - K2);
// float Y = K1 * X + B1;

// Console.WriteLine($"Две прямые пересекутся в точке с координатами {X}; {Y}");


// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.Write("Введите количество чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];

void mas(int N)
{
for (int i = 0; i < N; i++)
{
Console.WriteLine($"Введите {i+1} число: ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int pos(int[] Array)
{
int i = 0;
int count = 0;
while (i < Array.Length)
{
if(Array[i] > 0)
count ++;
i ++;
}
return count;
}

mas(N);
Console.Write($"[{String.Join(", ",Array)}] Чисел > 0: {pos(Array)}");
