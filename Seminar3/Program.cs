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
// Console.WriteLine("Dom1");
// int[] arr = new int[10];

// void FillArray(){
//     for(int i=0; i<arr.Length; i++){
//     arr[i] = new Random().Next(1,101);
//     Console.Write($"\t'{arr[i]}'");}
// }
// FillArray();
// Console.WriteLine();
// int answer = FindArray(arr);
// Console.WriteLine($"Количество чисел в промежутке от 20 до 90: '{answer}'");


// int FindArray (int[] array){
//     int count =0;
//     for(int i =0; i< array.Length; i++){
//         if(array[i]>=20 && array[i]<=90){
//         count++;}
//     }
//     return count;
// }

//#Dom2
// Console.WriteLine("\n Dom2");
// int[] arr1 = new int[10];

// void FillArray1(){
//     for(int i=0; i<arr1.Length; i++){
//     arr1[i] = new Random().Next(1,50);
//     Console.Write($"\t'{arr1[i]}'");
//    }
// }
// FillArray1();
// Console.WriteLine();
// FindArray1(arr1);
// void FindArray1 (int[] array){
//     int count1 =0;
//     for(int i =0; i< array.Length; i++){
//         if(array[i]%2==0){
//         count1++;}
//     }
//     Console.WriteLine($"Количество четных чисел в массиве: '{count1}'");
// }

//#Dom3
// Console.WriteLine("\n Dom3");
// double[] arr2 = new double[10];

// void FillArray2(){
//     for(int i=0; i<arr2.Length; i++){
//     arr2[i] = new Random().NextDouble()*10;
//     Console.Write($"\t'{Math.Round(arr2[i], 3)}'");
//    }
// }
// FillArray2();
// Console.WriteLine();
// Console.WriteLine(FindDiference(arr2));

// string FindDiference (double[] array){
//     double max = array[0], min = array [0];
//     for(int i =1; i< array.Length; i++){
//         if(array[i]>max) max=array[i];
//         if(array[i]<min) min=array[i];
//     }
//     double diff = max - min;
//     return $"Максимальное значение {Math.Round(max, 3)} \n Минимальное значение {Math.Round(min, 3)} \n Разница между максимальным и минимальными элементами массива: {Math.Round(diff, 3)}";
// }

//#Dom4
// Console.WriteLine("Dom4");
// Console.Write("Введите число в диапазоне от 1 до 100 000: "); 
// string num = Console.ReadLine();
// int size = num.Length;
// int number = Convert.ToInt32(num);

// int[] array = new int[size];
// MakeAndPrintArray(array);

// void MakeAndPrintArray(int[] arr){
// for(int i=arr.Length-1; i>=0; i--){
//     arr[i] = number%10;
//     number= number/10;
// }
// for(int i = 0; i<arr.Length; i++){
//     Console.Write($"\t '{arr[i]}'");
// }
// }
