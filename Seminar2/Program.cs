//#1

// int getNumber(){
//     Random rand = new Random();
//     int num = rand.Next(10,100);
//     return num;}


// int r1 = getNumber();
// Console.WriteLine(r1);

// int first = r1/10;
// int second = r1%10;
// if(first>second) Console.WriteLine(first); 
// if(first<second) Console.WriteLine(second); 
// if(first==second) Console.WriteLine(first); 

//#2

// int num = new Random().Next(100,1000);
//  Console.WriteLine(num);
//  int num1 = num/100;
//  int num2 = num%10;

//  int num3 = num1*10 + num2;
//  Console.WriteLine(num3);

//#3

// Console.WriteLine("Enter the number1");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);
// Console.WriteLine("Enter the number2");
// string str2 = Console.ReadLine();
// int num2 = Convert.ToInt32(str2);

// func(num1 , num2);

// void func(int numb1, int numb2){
//     if(numb1%numb2==0) Console.WriteLine("yes");
//     else Console.WriteLine(numb1%numb2);
// }

//#4

// Console.WriteLine("Enter the number1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3= num2*num2;
// int num4= num1*num1;
// func(num1 , num2);

// void func(int numb1, int numb2){
//     if(numb1==num3 || numb2==num4) Console.WriteLine("yes1");
//     else Console.WriteLine("no");
// }

//Dom1
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Enter the number1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// func(num1);

// void func(int numb1){
//     if(numb1%7==0 && numb1%23==0) Console.WriteLine("yes");
//     else Console.WriteLine("no");
// }

//Dom2
// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


// Console.Write("Введите координаты точки X и Y через пробел: ");
//  string[] coordinates  = Console.ReadLine().Split(' ');
//  int x = Convert.ToInt32(coordinates[0]);
//  int y = Convert.ToInt32(coordinates[1]);

//  if(x>0 && y>0) Console.WriteLine("1");
//  else if (x < 0 && y > 0)
// Console.WriteLine("2");
// else if (x < 0 && y < 0)
// Console.WriteLine("3");
// else if (x > 0 && y < 0)
// Console.WriteLine("4");
// else
// Console.WriteLine("Точка находится на оси координат");

//Dom3
// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int first = num/10;
// int second = num%10;
// if(first>second) Console.WriteLine(first); 
// if(first<second) Console.WriteLine(second); 
// if(first==second) Console.WriteLine(first); 


//Dom4
// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// if (num < 10)
// {
// Console.WriteLine(num);
// }
// else
// {
// while (num > 0)
// {
// int currentDigit = num % 10;
// num = num/10;
// if (num > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }


