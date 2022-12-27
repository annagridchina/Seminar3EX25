// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

Console.WriteLine("Start");
int A = 3;
int B = 5;
int Pow = 1;
for (int i = 1 ; i <= B; i ++)
{
    Pow = A * Pow;
}
Console.WriteLine(Pow);
Console.WriteLine("END");

