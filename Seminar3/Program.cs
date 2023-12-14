// ##1
// int[] arr = new int[10];
// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// int count = 0;
//  for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,5);
//     Console.Write($"\t'{arr[i]}'");
//     if(arr[i]==num)
//     count++;}

// Console.Write($"\n Это число встречается в массиве '{count}' раз");

// int[] arr = new int[10];

// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(-10,10);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }
// FillArray();
// Console.WriteLine("\n Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());

// bool FindNubmer(int num , int[] array) 
// {
//     for(int i=0; i < array.Length; i++){
//     if(array[i]==num){
//     return true;}
// }
// return false;
// }

// if(FindNubmer(number, arr)){
//     Console.WriteLine("True");
// }
// else 
// Console.WriteLine("False");
// bool a = FindNubmer(number, arr);
// Console.WriteLine($"{a}");


//#2
// int[] arr = new int[10];


// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(-10,10);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }
// FillArray();
// Console.WriteLine();
// PositiveArray(arr);

// void PositiveArray(int[] array){
//     for(int i = 0; i< array.Length; i++){
//        arr[i] = arr[i] * (-1);
//        Console.Write($"\t'{arr[i]}'");
//     }
// }

//#3
// int[] arr = new int[10];

// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,10);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }
// FillArray();
// Console.WriteLine();
// MultiplicArray(arr);

// void MultiplicArray (int[] array){
//     for(int i =0; i< array.Length / 2; i++){
//         int multi = array[i] * array[array.Length - 1 - i];
//         Console.Write($"\t '{multi}'");
//     }
// }

//#Dom1
// int[] arr = new int[10];

// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,101);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }
// FillArray();
// Console.WriteLine();
// FindArray(arr);

// void FindArray (int[] array){
//     int count =0;
//     for(int i =0; i< array.Length; i++){
//         if(array[i]>=20 && array[i]<=90){
//         count++;}
//     }
//     Console.WriteLine($"Количество чисел в промежутке от 20 до 90: '{count}'");
// }

//#Dom2
// int[] arr = new int[10];

// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,50);
//     Console.Write($"\t'{arr[i]}'");
//    }
// }
// FillArray();
// Console.WriteLine();
// FindArray(arr);
// void FindArray (int[] array){
//     int count =0;
//     for(int i =0; i< array.Length; i++){
//         if(array[i]%2==0){
//         count++;}
//     }
//     Console.WriteLine($"Количество четных чисел в массиве: '{count}'");
// }

//#Dom3

