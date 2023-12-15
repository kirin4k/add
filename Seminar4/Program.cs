//#1
// int[] arr = new int[10];
// FillArray();
// Console.WriteLine($" \n Количесвто простых чисел в массиве: '{FindIsPrime(arr)}'");


// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,101);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }



// bool IsPrime (int num){
//     for(int i =2; i<num; i++){
//         if(num%i==0) 
//         return false;
//     }
//     return true;
// }

// int FindIsPrime(int[] array){
//     int count = 0;
//     for(int i = 0; i<array.Length; i++){
//         if(IsPrime(array[i])){
//             count++;
//         }
//     }
//     return count;
// }

//#2

// Console.WriteLine("Задайте количество цифр в массиве");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = FillArray(num); 

// Console.WriteLine();
// Console.WriteLine($"Количество чисел заканчивающихся на 1 и целочисленно делящихся на 7: '{CountNumber(array)}'");

// int[] FillArray(int size){
//     int[] arr = new int[size];
//     for(int i=0 ; i< arr.Length; i++){
//     arr[i] = new Random().Next(1,300);
//     Console.Write($"\t '{arr[i]}'");}
//     return arr;
// }

// int CountNumber(int[] array){
//     int count = 0;
//     for(int i =0 ; i<array.Length; i++){
//         if((array[i]>=10) && (array[i]%10==1 && array[i]%7==0)){
//                 Console.WriteLine($"\t Цифра '{array[i]}'");
//                 count++;
//         }

//     }
//     return count;
// }

//#Dom1
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
        
// while(true){
//     string str = "q", str1 = "Q";
//     Console.WriteLine("Enter the number");
//         string num = Console.ReadLine();
//         if(IsPrime1(num, str, str1)){
//         Console.WriteLine("Цикл завершен");
//         break;}
//             int size = num.Length;
//             int number = Convert.ToInt32(num);
//             int[] arr = new int[size];
//     if(IsPrime(arr, number)){
//         Console.WriteLine("Цикл завершен");
//         break;}
// }

// bool IsPrime (int[] list, int number){
//     for (int i = list.Length - 1; i >= 0; i--){
//         list[i] = number % 10;
//         number /= 10;}
//     int sum =0;
//     for(int i=0; i< list.Length; i++){
//         sum = sum + list[i];
//     }
//     if(sum%2==0) {
//     return true;}
//     return false;}

// bool IsPrime1 (string num, string str, string str1){
//     if(num == str || num==str1){
//     return true;}
//     return false;
// }

//#Dom2
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] arr = new int[10];

// FillArray(arr);
// Console.WriteLine();
// Console.WriteLine("Кол-во четных чисел в массиве: " + FindArray(arr));

// void FillArray(int[] array){
//     for(int i=0; i<array.Length; i++){
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i]+ ",");}
// }

// int FindArray(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++){
//     if(array[i]%2==0)     count++;
//         }
//     return count;
// }

//#Dom3
// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// int[] arr = new int[7];

// FillArray(arr);
// Console.WriteLine();
// int[] arr2 = UppendArray(arr);
// PrintArray(arr2);

// void FillArray(int[] array){
//     for(int i=0; i<array.Length; i++){
//     array[i] = new Random().Next(1,30);
//     Console.Write(array[i]+ ",");} }

// int[] UppendArray(int[] list){
//     for(int i=0; i<list.Length/2; i++){
//         int temp = list[i];
//         list[i]= list[list.Length - 1 - i];
//         list[list.Length - 1 - i] = temp;}
//     return list;}

// void PrintArray (int[] array){
//     for(int i=0; i< array.Length; i++){
//         Console.Write(array[i] + ",");} }