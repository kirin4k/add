
using System.ComponentModel.Design;

int[,] arr = new int [3,3];

Random rand = new Random();

FillArray(arr);
Console.WriteLine();
NewArray(arr);
// SqrtArray(arr);
// int sum = FindSumArray(arr);
// Console.WriteLine(sum);

void FillArray(int[,] array){
for(int i=0; i< array.GetLength(0); i++){
    for(int j =0 ; j< array.GetLength(1); j++){
        array[i , j] = rand.Next(1,10);
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
}

// int FindSumArray(int[,] array){
//     int sum = 0;
// for(int i= 0; i < array.GetLength(0); i++){
//     for(int j = 0; j < array.GetLength(1); j++){
//         if(i==j){
//         sum = sum + array[i,j];
//     }   
//     }
//     }
//     return sum;
// }
    void NewArray (int[,] array){
    double [] list = new double[array.GetLength(0)];
    for(int i= 0; i < array.GetLength(0); i++){
        double average = 0;
        double sum = 0;
    for(int j = 0; j < array.GetLength(1); j++){
        sum = sum + array[i,j];
        average = sum/array.GetLength(1);
    } 
    list[i] = average;  
    }
    for(int i= 0; i < list.Length; i++){
        Console.Write(list[i] + ",");
    }
    }



// void SqrtArray(int[,] array){
// for(int i= 0; i < array.GetLength(0); i++){
//     for(int j = 0; j < array.GetLength(1); j++){
//         if(i%2==0 && j%2==0){
//             array[i,j] = array[i,j] * array[i,j];
//             // array[i,j] = b;
//     }   
//     Console.Write(array[i, j] + ";");
//     }
//      Console.WriteLine();
//     }
// }

// void PrintArray (int[,] array){
//     for(int i=0; i< array.GetLength(0); i++){
//     for(int j =0 ; j< array.GetLength(1); j++){
//         Console.Write(array[i, j] + ";");
//     }
//     Console.WriteLine();
// }
// }
