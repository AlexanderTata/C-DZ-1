/*Задача №1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/ 
// При этом добавим условие, что входящие два числа также не равны.

Console.WriteLine("Введите первое число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int second = Convert.ToInt32(Console.ReadLine());

if (number < second)                                    
{                                                                    
   Console.WriteLine ("Число max == second");
   Console.WriteLine ("Число min == number");
}    
else
{
    Console.WriteLine ("Число max == number");
    Console.WriteLine ("Число min == second");
}

/*Задача №2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
{   Console.WriteLine("Введите первое число ");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число ");
    int numberThree = Convert.ToInt32(Console.ReadLine());
    int max = numberOne;
    if (numberTwo > numberOne)
    {
        max = numberTwo;
    }
    else 
        {
        max = numberOne;
        } 
    if (numberThree < max)
        {
        max = numberThree;
        }
    else
        {
        max = numberOne;
        } 
    Console.WriteLine(max);
}
/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
