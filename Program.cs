// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

Console.WriteLine("Start");
int A = 2;
int B = 4;
 int Power = 1;
for (int i = 1 ; i <= B; i ++)
{
    Power = Power * A;
}
Console.WriteLine(Power);
Console.WriteLine("END");

