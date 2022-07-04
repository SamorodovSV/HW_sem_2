// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// // 918 -> 1
// Console.Write("Введите трехзначное число:");
// int x = Convert.ToInt32(Console.ReadLine());
// int a1 = x / 10 % 10;
// Console.Write(x + " -> " + a1);





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// void SearchForTheNumberThree ( int number){ 
// if (number < 100)
// {
//     Console.Write( number + "-> "+ "Третьей цифры нет");
// }
// else if (number >= 100 & number < 1000)
// {
//     int a1 = number % 10;
//     Console.Write( number + "-> "+ a1);
// }
// else if (number >= 1000 & number < 10000)
// {
//      int a1 = number  / 10 % 10;
//     Console.Write( number + "-> "+ a1);
// }
// else if (number >= 10000 & number < 100000)
// {
//      int a1 = number  / 100 % 10;
//     Console.Write( number + "-> "+ a1);
// }
// else if (number >= 100000 & number < 1000000)
// {
//      int a1 = number  / 1000 % 10;
//     Console.Write( number + "-> "+ a1);
// }
// else
// {
//     Console.Write( number + "-> "+ "Введено много символов. ");
// }

// }

// Console.Write("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// SearchForTheNumberThree(x);




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введите порядковый номер дня недели:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0 & number <=5)
// {
//     Console.Write( number + "-> "+ "нет. Это будний день");
// }
// else if (number == 6 || number == 7)
// {
//     Console.Write( number + "-> "+ "Да. Это выходной день");
// }
// else
// {
//     Console.Write( number + "-> "+ "Дня недели с таким номером не существует");
// }