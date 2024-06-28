using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1 - Write a program that takes a number from the user
            // then print yes if that number can be divided by 3 and 4 otherwise print no.


            ///   int Number;
            ///   bool flag;
            ///   do
            ///   {
            ///       Console.Write("Enter the Number: ");
            ///       flag = int.TryParse(Console.ReadLine(), out Number);
            ///   } while (!flag);
            ///   if( Number%3 == 0 && Number % 4 == 0)
            ///   {
            ///       Console.WriteLine("yes,the number can divded on 3 and 4 ");
            ///   } else
            ///       Console.WriteLine("no,the number can't divded on 3 and 4 ");

            #endregion

            #region Q2
            //2- Write a program that allows the user to insert an integer
            //then print negative if it is negative number otherwise print positive.

            ///   int Number;
            ///   bool flag;
            ///   do
            ///   {
            ///       Console.Write("Enter the Number: ");
            ///       flag = int.TryParse(Console.ReadLine(), out Number);
            ///   } while (!flag);
            ///   if( Number<0)
            ///   {
            ///       Console.WriteLine("it is negative number ");
            ///   } else
            ///       Console.WriteLine("it is positive number ");

            #endregion

            #region Q3
            //3- Write a program that takes 3 integers from the user
            //then prints the max element and the min element.

            ///     int Number01;
            ///     int Number02;
            ///     int Number03;
            ///     bool flag;
            ///     do
            ///     {
            ///         Console.Write("Enter the Number01: ");
            ///         flag = int.TryParse(Console.ReadLine(), out Number01);
            ///     } while (!flag);
            ///     do
            ///     {
            ///         Console.Write("Enter the Number02: ");
            ///         flag = int.TryParse(Console.ReadLine(), out Number02);
            ///     } while (!flag);
            ///    do
            ///    {
            ///        Console.Write("Enter the Number03: ");
            ///        flag = int.TryParse(Console.ReadLine(), out Number03);
            ///    } while (!flag);
            ///
            ///  int max = Number01 > Number02 ? (Number01 > Number03 ? Number01 : Number02) : (Number02 > Number03 ? Number02 : Number03);
            ///  Console.WriteLine($"the max number is: {max}");

            #endregion

            #region Q4
            //4 - Write a program that allows the user to insert an integer number
            //then check If a number is even or odd.


            /// int Number;
            ///      bool flag;
            ///      do
            ///      {
            ///          Console.Write("Enter the Number: ");
            ///          flag = int.TryParse(Console.ReadLine(), out Number);
            ///      } while (!flag);
            ///      if(Number%2==0)
            ///        Console.WriteLine("the Number is even ");
            ///      else
            ///        Console.WriteLine("the Number is odd");

            #endregion

            #region Q5
            //5- Write a program that takes character from the user then
            //if it is a vowel chars (a,e,I,o,u) then print (vowel)
            //otherwise print (consonant).


            ///   string Number;
            ///   int num=5;
            ///  bool flag = true;
            ///        do
            ///        {
            ///            Console.Write("Enter the Number: ");
            ///            Number= Console.ReadLine()!;
            ///            int.TryParse(Number, out num);
            ///            if(num == 0 && Number.Length == 1)
            ///              flag = false;
            ///        } while ( flag );
            ///
            ///        if(Number == "a" || Number == "e" || Number == "i" || Number == "o" || Number == "u")
            ///          Console.WriteLine("the char is vowel ");
            ///        else
            ///          Console.WriteLine(" consonant");

            #endregion

            #region Q6
            //6- Write a program that allows the user to insert an integer
            //then print all numbers between 1 to that number.

            ///     int Number;
            ///     bool flag;
            ///     do
            ///     {
            ///         Console.Write("Enter the Number: ");
            ///         flag = int.TryParse(Console.ReadLine(), out Number);
            ///     } while (!flag);
            ///
            ///     for (int i = 1; i <= Number; i++)
            ///      Console.WriteLine(i);

            #endregion

            #region Q7
            //7- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.

            // Prompt the user to enter an integer
            ///  start:
            ///  Console.Write("Enter an integer: ");
            ///  int number;
            ///  if (!int.TryParse(Console.ReadLine(), out number))
            ///  {
            ///      Console.WriteLine("Error: Invalid input. Please enter an integer.");
            ///      goto start;
            ///  }
            ///
            ///  Console.WriteLine($"Multiplication table for {number}:");
            ///  for (int i = 1; i <= 12; i++)
            ///  {
            ///      Console.WriteLine($"{number} x {i} = {number * i}");
            ///  }

            #endregion

            #region Q8
            //8- Write a program that allows to user to insert number then
            //print all even numbers between 1 to this number

            /// start:
            ///     Console.Write("Enter an positive integer: ");
            ///     int number;
            ///     if (!int.TryParse(Console.ReadLine(), out number) || number<0)
            ///     {
            ///         Console.WriteLine("Error: Invalid input. Please enter an integer.");
            ///         goto start;
            ///     }
            ///
            ///     for (int i = 0; i <= number; i++) 
            ///     {
            ///         if (i % 2 == 0)
            ///         { Console.WriteLine(i);} 
            ///
            ///     }

            #endregion

            #region Q9
            // 9 - Write a program that takes two integers then prints the power.


            ///       int Number01;
            ///       int Number02;
            ///       bool flag;
            ///       do
            ///       {
            ///           Console.Write("Enter the Number01: ");
            ///           flag = int.TryParse(Console.ReadLine(), out Number01);
            ///       } while (!flag);
            ///       do
            ///       {
            ///           Console.Write("Enter the Number02: ");
            ///           flag = int.TryParse(Console.ReadLine(), out Number02);
            ///       } while (!flag);
            ///
            ///  
            ///  double result = Math.Pow(Number01, Number02);
            ///
            ///  
            ///  Console.WriteLine($"{Number01}  power  {Number02} is: {result}");

            #endregion

            #region Q10
            //10- Write a program to enter marks of five subjects
            //and calculate total, average and percentage.




            ///    double total =0;
            ///    double average;
            ///    double percentage;
            ///    double subjectMark;
            ///    bool flag;
            ///
            ///    Console.WriteLine("Enter marks of subjects from 100 (full mark = 100) ");
            ///
            ///    for (int i = 0; i < 5; i++)
            ///    {
            ///         do
            ///         {
            ///             Console.Write($"Enter the Number of subject{i+1}: ");
            ///             flag = double.TryParse(Console.ReadLine(), out subjectMark);
            ///
            ///            if( flag && subjectMark <= 100 && subjectMark >= 0)
            ///                flag= false;
            ///            else 
            ///                flag = true;   
            ///
            ///         } while (flag);
            ///
            ///        total = total + subjectMark;
            ///
            ///    }
            ///
            ///     average = total / 5;
            ///     percentage = total / 500 * 100;
            ///
            ///
            ///    Console.WriteLine("\nResults:");
            ///    Console.WriteLine($"Total marks: {total}");
            ///    Console.WriteLine($"Average marks: {average:F2}");
            ///    Console.WriteLine($"Percentage: {percentage:F2}%");


            #endregion

            #region Q11

            ///    int monthNumber;
            ///       bool flag;
            ///       do
            ///       {
            ///           Console.Write("Enter the month Number: ");
            ///           flag = int.TryParse(Console.ReadLine(), out monthNumber);
            ///           if ( flag && monthNumber < 1 && monthNumber > 12)
            ///           flag=false;
            ///           else
            ///            flag = true;
            ///
            ///       } while (flag );
            ///    
            ///    int daysInMonth;
            ///    switch (monthNumber)
            ///    {
            ///        case 1:
            ///        case 3:
            ///        case 5:
            ///        case 7:
            ///        case 8:
            ///        case 10:
            ///        case 12:
            ///            daysInMonth = 31;
            ///            break;
            ///        case 4:
            ///        case 6:
            ///        case 9:
            ///        case 11:
            ///            daysInMonth = 30;
            ///            break;
            ///        case 2:
            ///            daysInMonth = 28; 
            ///            break;
            ///        default:
            ///            daysInMonth = -1; // Invalid month number
            ///            break;
            ///    }
            ///         Console.WriteLine($"Days in Month {monthNumber}: {daysInMonth}");



            #endregion

            #region Q12

            ///   double num1, num2, result;
            ///   string op;
            ///
            ///    first:
            ///   Console.Write("Enter the first number: ");
            ///   if (!double.TryParse(Console.ReadLine(), out num1))
            ///   {
            ///       Console.WriteLine("Invalid input. Please enter a valid number.");
            ///       goto first;
            ///   }
            ///
            ///   
            ///   second:
            ///   Console.Write("Enter the operator (+, -, *, /): ");
            ///   op = Console.ReadLine()!;
            ///   if (op == "+" || op == "-" || op == "*" || op == "/"  )
            ///   {
            ///       Console.WriteLine("it valid operator");
            ///   }
            ///   else 
            ///   {
            ///       Console.WriteLine("Invalid input. Please enter a valid operator.");
            ///       goto second;
            ///   }
            ///
            ///   third:
            ///   Console.Write("Enter the second number: ");
            ///   if (!double.TryParse(Console.ReadLine(), out num2))
            ///   {
            ///       Console.WriteLine("Invalid input. Please enter a valid number.");
            ///       goto third;
            ///   }
            ///
            ///   
            ///   switch (op)
            ///   {
            ///       case "+":
            ///           result = num1 + num2;
            ///           Console.WriteLine($"Result: {num1} + {num2} = {result}");
            ///           break;
            ///       case "-":
            ///           result = num1 - num2;
            ///           Console.WriteLine($"Result: {num1} - {num2} = {result}");
            ///           break;
            ///       case "*" :
            ///           result = num1 * num2;
            ///           Console.WriteLine($"Result: {num1} * {num2} = {result}");
            ///           break;
            ///       case "/" :
            ///           if (num2 == 0)
            ///           {
            ///               Console.WriteLine("Error: Division by zero.");
            ///               return;
            ///           }
            ///           result = num1 / num2;
            ///           Console.WriteLine($"Result: {num1} / {num2} = {result}");
            ///           break;
            ///       default:
            ///           Console.WriteLine("Error: Invalid operator.");
            ///           return;
            ///   }
            ///
            #endregion

            #region Q13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.

            ///    start:
            ///    Console.Write("enter string to reverse it:");
            ///    string originalString =Console.ReadLine()!;
            ///    if (string.IsNullOrEmpty(originalString))
            ///    {
            ///        Console.WriteLine("error,Enter a valid srting");
            ///        goto start;
            ///    }
            ///    char[] charArray = originalString.ToCharArray();
            ///    Array.Reverse(charArray);
            ///    string reversedString = new string(charArray);
            ///    Console.WriteLine(reversedString);


            #endregion

            #region Q14
            //14- Write a program to allow the user to enter int and
            //print the REVERSED of it.



            ///    int userInput;
            ///       bool flag;
            ///       do
            ///       {
            ///           Console.Write("Enter an integer: ");
            ///           flag = int.TryParse(Console.ReadLine(), out userInput);
            ///       } while (!flag);
            /// 
            ///    int reversedNumber = 0;
            /// 
            ///    while (userInput != 0)
            ///    {
            ///        int digit = userInput % 10;
            ///        reversedNumber = reversedNumber * 10 + digit;
            ///        userInput /= 10;
            ///    }
            /// 
            ///    Console.WriteLine("The reversed integer is: " + reversedNumber);



            #endregion

            #region Q15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            // Test Data :
            //Input starting number of range: 1
            //Input ending number of range: 50
            //
            //Expected Output :
            //The prime number between 1 and 50 are:
            //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47



            ///    int number;
            ///    bool flag;
            ///    do
            ///    {
            ///        Console.Write("Enter an entger from 1 to 50: ");
            ///        flag = int.TryParse(Console.ReadLine(), out number);
            /// 
            ///    } while (!flag || number < 1 || number > 50);
            ///
            ///    switch (number)
            ///    {
            ///        case 2:
            ///        case 3:
            ///        case 5:
            ///        case 7:
            ///        case 11:
            ///        case 13:
            ///        case 17:
            ///        case 19:
            ///        case 23:
            ///        case 29:
            ///        case 31:
            ///        case 37:
            ///        case 41:
            ///        case 43:
            ///        case 47:
            ///            Console.WriteLine($"the number is prime: {number} ");
            ///            break;
            ///        default:
            ///            Console.WriteLine($"the number is not prime:  {number}");
            ///            break;
            ///
            ///
            ///    }


            #endregion

            #region Q16

            ///     int decimalNumber;
            ///        bool flag;
            ///        do
            ///        {
            ///            Console.Write("Enter a number to convert ");
            ///            flag = int.TryParse(Console.ReadLine(), out decimalNumber);
            ///        } while (!flag);
            ///
            ///     string binary = "";
            ///     while (decimalNumber > 0)
            ///     {
            ///         binary = (decimalNumber % 2) + binary;
            ///         decimalNumber /= 2;
            ///     }
            ///
            ///     string binaryNumber = binary;
            ///     Console.WriteLine($"The Binary  is : {binaryNumber}.");


            #endregion

            #region Q17
            // 17 - Create a program that asks the user to input
            // three points(x1, y1), (x2, y2), and(x3, y3),
            // and determines whether these points lie on a single straight line.


            ///     Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            ///     double x1 = double.Parse(Console.ReadLine());
            ///     double y1 = double.Parse(Console.ReadLine());
            ///
            ///     Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            ///     double x2 = double.Parse(Console.ReadLine());
            ///     double y2 = double.Parse(Console.ReadLine());
            ///
            ///     Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            ///     double x3 = double.Parse(Console.ReadLine());
            ///     double y3 = double.Parse(Console.ReadLine());
            ///
            ///     double slope1 = (y2-y1) / (x2-x1);
            ///     double slope2 = (y3 - y2) / (x3 - x2);
            ///     if(slope1==slope2)
            ///         Console.WriteLine("the points lie on straight line");
            ///     else
            ///         Console.WriteLine("this points not lie on straight line");


            #endregion

            #region Q18

            ///            int hoursWorked;
            ///               bool flag;
            ///               do
            ///               {
            ///                   Console.Write("Enter the time taken to complete the task (in hours): ");
            ///                   flag = int.TryParse(Console.ReadLine(), out hoursWorked);
            ///               } while (!flag);
            ///
            ///
            ///      string efficiencyLevel;
            ///
            ///      switch (hoursWorked)
            ///      {
            ///          case int n when (n >= 2 && n <= 3):
            ///              efficiencyLevel = "Highly Efficient";
            ///              break;
            ///          case int n when (n > 3 && n <= 4):
            ///              efficiencyLevel = "Increase Speed";
            ///              break;
            ///          case int n when (n > 4 && n <= 5):
            ///              efficiencyLevel = "Provide Training";
            ///              break;
            ///          case int n when (n > 5):
            ///              efficiencyLevel = "Leave the Company";
            ///              break;
            ///          default:
            ///              efficiencyLevel = "Invalid Input";
            ///              break;
            ///      }
            ///
            ///      Console.WriteLine($"Efficiency Level: {efficiencyLevel}");

            #endregion

            #region Q19
            //19- . Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and
            //shows the identity table of size n * n.


            ///   start:
            ///  Console.Write("Enter the size of the identity matrix (n): ");
            ///   if( !int.TryParse(Console.ReadLine(),out int n))
            ///  {
            ///      Console.WriteLine("error, invalid size of the identity matrix ");
            ///      goto start;
            ///  }
            ///  for (int i = 0; i < n; i++)
            ///  {
            ///      for (int j = 0; j < n; j++)
            ///      {
            ///          if (i == j)
            ///          {
            ///              Console.Write("1 ");
            ///          }
            ///          else
            ///          {
            ///              Console.Write("0 ");
            ///          }
            ///      }
            ///      Console.WriteLine();
            ///  }
            #endregion

            #region Q20
            //20- Write a program in C# Sharp to find the sum of all elements of the array.

            ///     int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            ///     int sum = 0;
            ///     for (int i = 0; i < numbers.Length; i++)
            ///     {
            ///         sum += numbers[i];
            ///     }
            ///     Console.WriteLine("the sum of array is: "+sum);
            #endregion

            #region Q21
            //21- Write a program in C# Sharp to merge two arrays of the same size
            //sorted in ascending order...



            /// int[] numbers01 = {5,4,3,2,1,0};
            /// int[] numbers02 = {6,7,8,9,10,11};
            /// int[] numbers03 = new int[numbers01.Length + numbers02.Length];
            ///  numbers01.CopyTo(numbers03, 0);
            ///  numbers02.CopyTo(numbers03, numbers01.Length);
            /// Array.Sort(numbers03);
            /// Console.WriteLine("the merge array in ascending order");

            /// for (int i = 0; i < numbers03.Length; i++)
            /// {
            ///     Console.WriteLine($"the number03[{i}]: {numbers03[i]}");
            /// }

            #endregion

            #region Q22
            //22- Write a program in C# Sharp to count the frequency of each element of an array.



            #endregion

            #region Q23
            //23- Write a program in C# Sharp to find maximum and minimum element in an array

        ///    int[] array;
        ///    int size;
        ///    int ReadElement;
        ///    int max;
        ///    int min;
        ///    bool flag;
        ///
        ///    do 
        ///    {
        ///        Console.Write("Enter the size of array: ");
        ///        flag = int.TryParse(Console.ReadLine(), out size);
        ///    }while (!flag);
        ///
        ///    array = new int[size];
        ///    Console.WriteLine("Enter elements of array");
        ///    for (int i = 0; i < size; i++)
        ///    {
        ///        do
        ///        {
        ///            Console.Write($"Enter array[{i}]: ");
        ///            flag = int.TryParse(Console.ReadLine(), out ReadElement);
        ///        } while (!flag);
        ///        //this code is repeated => (function)
        ///        array[i]= ReadElement;
        ///    }
        ///
        ///    max = array[0];
        ///    min = array[0];
        ///
        ///    for (int i = 0; i < size; i++)
        ///    {
        ///        max = max < array[i] ? array[i] : max;
        ///        min = min > array[i] ? array[i]:min ;
        ///    }
        ///
        ///    Console.WriteLine($"the max element in array is {max}");
        ///    Console.WriteLine($"the min element in array is: {min}");



            #endregion









        }

    }
}
