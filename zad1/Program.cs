//Console.Write("Введите число 1: ");

//int number1 =int.Parse (Console.ReadLine()!) ;

//Console.Write("Введите число 2: ");
//int number2 =int.Parse (Console.ReadLine()!) ;

//int sqr = number2*number2;
//if (sqr==number1) {
   //Console.WriteLine("Первое число является квадратом второго"); 
//}
//else 
//{
  // Console.WriteLine("Первое число не является квадратом второго"); 
//}
 
//задача

//Console.Write("Введите номер дня недели: ");
//int number1 = int.Parse (Console.ReadLine()!);
//if (number1 == 1) {
 //   Console.WriteLine("Понедельник");
//}
//if (number1 == 2) {
  //  Console.WriteLine("вторник");
//}
//if (number1 == 3) {
    //Console.WriteLine("среда");
//}
//if (number1 == 4) {
  //  Console.WriteLine("четверг");
//}
//if (number1 == 5) {
 //   Console.WriteLine("пятница");
//}
//if (number1 == 6) {
  //  Console.WriteLine("суббота");
//}
//if (number1 == 7) {
   // Console.WriteLine("воскресенье");
//}

// задача

//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

//Console.Write("Введите число 1: ");
//int number1 =int.Parse (Console.ReadLine()!) ;
//for (int i = -number1; i <= number1; i++)
//{
//    Console.Write($"{i}");
//}


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите трёхзначное число: ");
int number1 =int.Parse (Console.ReadLine()!) ;
number1 = number1 % 10;
Console.WriteLine ($"Крайние число {number1}");
