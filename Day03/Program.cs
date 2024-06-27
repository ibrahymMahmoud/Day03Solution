namespace Demo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region control Statements 1.Conditional Statements [if , switch] Equality
            //Q.check if month number in first quarter using if
            ///   Console.Write("please enter an month numbers existed in 1st quarter: ");
            ///   int.TryParse(Console.ReadLine(), out int MonthNumber);
            ///   if(MonthNumber == 1)
            ///   {
            ///       Console.WriteLine("hello january");
            ///   }
            ///   else if (MonthNumber == 2)
            ///   {
            ///       Console.WriteLine("hello febraury");
            ///   }
            ///   else if (MonthNumber == 3)
            ///   {
            ///       Console.WriteLine("hello march");
            ///   }
            ///   else
            ///       Console.WriteLine("month not in first quarter");

            //Q.check if month number in first quarter using switch
            ///     Console.Write("please enter an month numbers existed in 1st quarter: ");
            ///     int.TryParse(Console.ReadLine(), out int MonthNumber);
            ///  switch (MonthNumber)
            ///  {
            ///
            ///      case 1:
            ///          Console.WriteLine("hello january");
            ///          break;
            ///      case 2:
            ///          Console.WriteLine("hello febrauary");
            ///          break;
            ///      case 3:
            ///          Console.WriteLine("hello march");
            ///          break;
            ///      default:
            ///          Console.WriteLine("entered month not in first quarter");
            ///          break;
            ///  }

            /*
             * when switching on varible of type numeric
             * compiler will generate jump table 
             * jump table consist of (uniqe key , value )
             * it take 1 step in compile time (more performance)*/

            #endregion

            #region control Statements 1.Conditional Statements [if , switch] more than and less than
            //Q.check age is greater than 22 (if)
            /// Console.Write("Enter your age: ");
            /// int.TryParse(Console.ReadLine(), out int Age);
            /// if (Age > 22) {
            ///     Console.WriteLine("your age more than 22");
            /// } else if (Age < 22)
            /// {
            ///     Console.WriteLine("your age is less than 22");
            /// }else
            ///     Console.WriteLine("your age is 22");

            //Q.check age is greater than 22 (switch)
         ///    Console.Write("Enter your age: ");
         ///    int.TryParse(Console.ReadLine(), out int Age);
         ///   switch(Age)
         ///   {
         ///       case > 22:
         ///           Console.WriteLine("your age is more than 22");
         ///           break;
         ///       case < 22:
         ///           Console.WriteLine("your age is less than 22");
         ///           break;
         ///       default:
         ///           Console.WriteLine("you age is 22");
         ///           break;
         ///   }

            #endregion

        }
    }
}
