using System.Text;

// //#1.1

// char[] chars = new char[] {'H','e','l','l','o','!'};
// string str = "";

//     for(int i=0; i< chars.Length; i++){
//         str += chars[i];
//     }
// Console.WriteLine(str);

// //#1.2

// char[] chars1 = new char[] {'H','e','l','l','o','!'};
// StringBuilder strB = new StringBuilder();

//     for(int i=0; i< chars1.Length; i++){
//         strB.Append(chars1[i]);
//     }
// Console.WriteLine(strB.ToString());


//#2

// string str = "Hello";
// char[] ch = new char[str.Length];
// Console.Write('[');
// for(int i=0; i<str.Length; i++){
//     ch[i] = str[i];
//     Console.Write($"'{ch[i]}',");
// }
// Console.Write(']');

//#3

// int[,] arr = FillArray(10,4);

// int[,] FillArray(int rows, int columns){
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i+j;
//             Console.Write($"{array[i,j]},");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

//#4
// string str = GetString();
// int count = Count(str);
// Console.WriteLine($"Количество гласных в строке: '{count}'");


// string GetString(){
//     Console.Write("Введите строку:  ");
//     string stri = Console.ReadLine();
//     return stri;
// }


// int Count(string stroka){
//     int count = 0;
//     for (int i = 0; i < stroka.Length; i++)
//     {
//         if(IsVowel(stroka[i])) 
//         count++;
//     }
//     return count;
// }

// bool IsVowel(char c){
//     string vowels = "aeouyiAEOUYI";
//     return vowels.Contains(c);
// }

//#5.1
// string str = GetString();
// NewString(str);

// string GetString(){
//     Console.Write("Введите строку:  ");
//     string stri = Console.ReadLine();
//     return stri;
// }

// void NewString(string stroka){
//     for (int i = stroka.Length-1; i>= 0; i--)
//     {
//        Console.Write(stroka[i]);
//     }
// }

//#5.2
// string str = GetString();
// string str1 = NewString(str);
// Console.WriteLine(str1);

// string GetString(){
//     Console.Write("Введите строку:  ");
//     string stri = Console.ReadLine();
//     return stri;
// }

// string NewString(string stroka){
//     string str = String.Empty;
//     for (int i = stroka.Length-1; i>= 0; i--)
//     {
//        str += stroka[i];
//     }
//     return str;
// }

// #Dom1
// char[,] ch = new char[2,5];
// FillArray(ch);
// PrintArray(ch);
// string str = NewString(ch);
// Console.WriteLine(str);

// void FillArray(char[,] ch){
// for(int i=0; i< ch.GetLength(0); i++){
//     for(int j =0 ; j< ch.GetLength(1); j++){
//         Console.WriteLine("Введите символ: ");
//         ch [i , j] = Convert.ToChar(Console.ReadLine());
//     }
// }
// }

// void PrintArray (char[,] array){
//     for(int i=0; i< array.GetLength(0); i++){
//     for(int j =0 ; j< array.GetLength(1); j++){
//         Console.Write(array[i, j] + ";");
//     }
//     Console.WriteLine();
// }
// }

// string NewString(char[,] ch){
//     StringBuilder strB = new StringBuilder();
//     for(int i=0; i< ch.GetLength(0); i++){
//         for (int j = 0; j < ch.GetLength(1); j++)
//         {
//             strB.Append(ch[i,j]);
//         }
//     }
//     return strB.ToString();
// }

// #Dom2

// string str = "HELLO WoRlD";
// string str1 = str.ToLower();
// Console.WriteLine(str1);

// #Dom3

// string input = "12321";
// Console.WriteLine(IsPalindrome(input) ? "Да" : "Нет");

// bool IsPalindrome(string str)
// {
// string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// return normalized.SequenceEqual(normalized.Reverse());
// }

// #Dom4
// string input = "Are you serious ?";
// string result = ReverseWords(input);
// Console.WriteLine(result);

// string ReverseWords(string str)
// {
// // Разделение строки на слова
// string[] words = str.Split(' ');
// // Обращение порядка слов
// Array.Reverse(words);
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);
// }