using System.ComponentModel;
using System.Security.Cryptography;

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



        }
    }
}
