//#1
// Console.WriteLine("Enter number: ");
// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

// int sqrt = num*num;

// Console.WriteLine($" sqrt = {sqrt}");

//#2

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// Console.WriteLine("Enter the 2 number: ");
// string str2 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);
// int num2 = Convert.ToInt32(str2);

// if(num2 == num1*num1) Console.WriteLine("Yes, this is sqrt");
// else Console.WriteLine("No, this isnt sqrt");

//#3

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);

// switch(num1){
//     case 1: Console.WriteLine("Ponedelnik"); break;
//     case 2: Console.WriteLine("Vtornik"); break;
//     case 3: Console.WriteLine("Sreda"); break;
//     case 4: Console.WriteLine("Chetverg"); break;
//     case 5: Console.WriteLine("Piatnica"); break;
//     case 6: Console.WriteLine("Subbota"); break;
//     case 7: Console.WriteLine("Voskresenia"); break;
//     default: Console.WriteLine("Vvedite chislo ot 1 do 7"); break;
// }

//#4

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);

// int num2 = num1 * (-1);

// for(int i = num2; i<=num1; i++){
//     Console.WriteLine($"{i}");
// }

//#5

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);

// if(num1>99 && num1<=999) { int a = num1%10; Console.WriteLine(a);}
// else Console.WriteLine("Vvedite 3 znachnoe chislo: ");

//Dom#1

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);
// Console.WriteLine("Enter the 2 number: ");
// string str2 = Console.ReadLine();
// int num2 = Convert.ToInt32(str2);

// if(num1>num2) Console.WriteLine($"The first number '{num1}' is bigger than the second number '{num2}'");
// if(num1<num2) Console.WriteLine($"The first number '{num1}' is less than the second number '{num2}'");
// if(num1==num2) Console.WriteLine($"Both numbers are equal: '{num1}' = '{num2}'");

//Dom#2

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);
// Console.WriteLine("Enter the 2 number: ");
// string str2 = Console.ReadLine();
// int num2 = Convert.ToInt32(str2);
// Console.WriteLine("Enter the 3 number: ");
// string str3 = Console.ReadLine();
// int num3 = Convert.ToInt32(str3);

// int max = num1;

// if(num2>max) max=num2;
// if(num3>max) max=num3;
// Console.WriteLine($"Max number is: {max} ");

//Dom#3

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);

// if(num1%2==0) Console.WriteLine("Yes");
// else Console.WriteLine("No");

//Dom#4

// Console.WriteLine("Enter the 1 number: ");
// string str1 = Console.ReadLine();
// int num1 = Convert.ToInt32(str1);

// for(int i=1; i<=num1; i++){
//     if(i%2==0) Console.Write($"\t{i}");
// }