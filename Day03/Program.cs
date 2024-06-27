namespace Demo

{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
     class Program
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

            #region conditional statments if,switch (string datatype)
            //Q.enter name of spasefic names
            ///  Console.Write("enter your name: ");
            ///  string name = Console.ReadLine() ?? "no name";
            ///  if(name == "ahmed")
            ///      Console.WriteLine("hello ahmed");
            ///  else if (name == "mohamed")
            ///      Console.WriteLine("hello mohamed");
            ///  else if (name == "ali")
            ///      Console.WriteLine("hello ali");
            ///  else if (name == "hema")
            ///      Console.WriteLine("hello hema");
            ///  else if (name == "maged")
            ///      Console.WriteLine("hello maged");
            ///  else
            ///      Console.WriteLine("your name not found");

            // Q.enter name of spasefic names
            ///   Console.Write("enter your name: ");
            ///   string name = Console.ReadLine() ?? "no name";
            ///
            ///  switch(name)
            /// {
            ///     case "ahmed":
            ///         Console.WriteLine("hello ahmed");
            ///         break;
            ///     case "mohamed":
            ///         Console.WriteLine("hello mohamed");
            ///         break;
            ///     case "ali":
            ///         Console.WriteLine("hello ali");
            ///         break;
            ///     case "hema":
            ///         Console.WriteLine("hello hema");
            ///         break;
            ///     case "maged":
            ///         Console.WriteLine("hello maged");
            ///         break;
            ///     default:
            ///         Console.WriteLine("your name  not found");
            ///         break;
            ///
            /// }

            #endregion

            #region Evolution of switch c#7.0
            /// solve problem of limation types
            ///it supports comparing types out of the box
            ///when (do condition on case also)
            ///more than one condition it relased in the next version

            /// object input = new object();
            /// input = 5;
            /// switch (input) 
            /// {
            ///     case int localInput when localInput > 5:
            ///         Console.WriteLine("it type of int");
            ///         break;
            ///     case string localInput:
            ///         Console.WriteLine("it type of string");
            ///         break;
            ///     case Person person when person.Name=="ahmed"&&person.Id==200:
            ///         Console.WriteLine("it type of int");
            ///         break;
            ///     case Person localInput:
            ///         Console.WriteLine("it type of person");
            ///         break;
            ///     default:
            ///         Console.WriteLine("none of them");
            ///         break ;
            /// }
            /// 

            #region Example02
            ///  Console.Write("Enter your Age: ");
            ///  double age = double.Parse( Console.ReadLine()!);
            ///  switch (age) 
            ///  {
            ///      case double when age >= 20 && age <= 30:
            ///          Console.WriteLine("your age is between 20 and 30");
            ///          break;
            ///      case double when age > 30 && age <= 40:
            ///          Console.WriteLine("your age is between 30 and 40");
            ///          break;
            ///      default :
            ///          Console.WriteLine("your age not between 30 and 40");
            ///          break;
            ///  }

            #endregion


            #endregion

            #region switch with goto
            //give options based on your budget
            ///   Console.Write("Enter your budget: ");
            ///   double budget = double.Parse(Console.ReadLine()!) ;
            ///   switch(budget)
            ///   {
            ///       case 3000:
            ///           Console.WriteLine("have option 3");
            ///          // Console.WriteLine("have option 2");
            ///          // Console.WriteLine("have option 1");
            ///           goto case 2000;
            ///       case 2000:
            ///           Console.WriteLine("have option 2");
            ///           //Console.WriteLine("have option 1");
            ///           goto case 1000;
            ///       case 1000:
            ///           Console.WriteLine("have option 1");
            ///           break;
            ///       default:
            ///           Console.WriteLine("no options");
            ///           break ;
            ///   }

            ///  hamada:
            /// Console.WriteLine("retutn to label hamada");
            ///
            /// goto hamada; 
            ///
            /// habozo:
            /// Console.WriteLine("go to label hambozo");

            //it may used to return to label and in this exampel will 
            // infinite loop
            // but correct used of goto in switch
            // label will compile no need goto to call it

            #endregion

            #region Evolution of switch 8.0
            //switch Expertion

          ///  string message=string.Empty;
          ///  Console.Write("Enter your option: ");
          ///  int.TryParse(Console.ReadLine(), out int option);
          ///
          ///  message = option switch
          ///  {
          ///      1 => "using option 1",
          ///      2 => "using option 2",
          ///      3 => "using option 3",
          ///      4 => "using option 4",
          ///      5 => "using option 5",
          ///      _ => "not using this option"
          ///  };
          ///
          ///  Console.WriteLine(message);
          ///  

          ///  Person person = new Person();
          ///  person.Id = 5;
          ///  person.Name = "yasta";
          ///  switch(person)
          ///  {
          ///      case { Id: 1, Name: "mohamed" }:
          ///          Console.WriteLine("hello ya mohamed");
          ///          break;
          ///      case Person  when person.Id == 5 && person.Name=="yasta" :
          ///          Console.WriteLine("hello yasta");
          ///          break;
          ///      default:
          ///          Console.WriteLine("not found");
          ///          break;
          ///  }

            #endregion



        }
    }
}
