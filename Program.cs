//Напишите цикл, который принимает на вход 2 числа (А и Б) и возводит число А в натуральную степеть Б. 
// 3,5 -> 243, 2,4 ->16
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int firstnum = a;
 for (int i = 1; i < b; i++)
   {
    firstnum = firstnum * a;
   }
Console.WriteLine("Число А в натуральной степени числа Б равна: " + firstnum);