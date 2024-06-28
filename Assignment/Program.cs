using System.ComponentModel;
using System.Security.Cryptography;
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



        }
    }
}
