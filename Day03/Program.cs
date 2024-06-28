using System.Text;

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

         #region Evolution of switch 8.0 and 9.0
            //switch Expertion
            #region Example01

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
            #endregion

            #region Example02
            ///  Person person = new Person();
            ///  person.Id = 5;
            ///  person.Name = "yasta";
            ///   switch(person)
            ///   {
            ///       case { Id: 1, Name: "mohamed" }:
            ///  Console.WriteLine("hello ya mohamed");
            ///           break;
            ///         case { Id: >1 and <10 , Name: "mohamed" }: //new
            ///  Console.WriteLine("hello ya mohamed");
            ///         break;
            ///     case Person when person.Id == 5 && person.Name == "yasta":
            ///  Console.WriteLine("hello yasta");
            ///           break;
            ///     default:
            ///  Console.WriteLine("not found");
            ///           break;
            ///   }

            #endregion

            #region Example03
            /// Person person = new Person() { Id=100 ,Name = "hema" };
            /// string message = person switch
            /// {
            ///     { Id: < 100 and > 50, Name: "hema" } => "hema your id between 50 and 100",
            ///     { Id: > 100 and < 150, Name: "hema" } => "hema your id between 100 and 200",
            ///     { Id:  100 , Name: "hema" } => "hema your id is 100"
            ///
            /// };
            /// Console.WriteLine(message);

            #endregion

            #endregion

         #region Conditional Statements 2.loop statements
            /*
             * for => to repeat code a number of times
             *     => to loop on elements in collection like array
             *     
             * while => to repeat code based on condition
             * Do While => to repeat code that will repeat once atleast
             * for each => to loop on collection 
             *          => make نسخه from array
             */

            // example
            /// for(int i=0; i<20; i++)
            /// {
            ///     Console.WriteLine("hello world");
            /// }
            #endregion

         #region For && For each 

            /*
             *in for loop i have fully controll on array
             *i can break and continue 
             *which can't in foreach
             */

            ///  int[] numbers = [1, 2, 3 , 4 ,5 ,6 ,7 ,8 ,9,10];
            ///  for (int i = 0; i < numbers.Length; i++)
            ///  {
            ///      Console.WriteLine(numbers[i]);
            ///  }
            ///
            ///  Console.WriteLine("*************************");
            ///
            ///  foreach (int number in numbers)
            ///  {
            ///      Console.WriteLine(number);
            ///  }

            #endregion

         #region do while and while
            //Q.check the enter number is even
            int number;
            bool flag;

            #region Example on do while
            ///do
            ///{
            ///    Console.Write("enter an even number: ");
            ///    flag = int.TryParse(Console.ReadLine(), out number);
            ///} while (number % 2 == 1 || !flag); 
            #endregion


            #region Example on while
            ///  Console.Write("enter an even number: ");
            ///  flag = int.TryParse(Console.ReadLine(), out number);
            ///
            ///  while (number % 2 == 1 || !flag)
            ///  {
            ///      Console.Write("enter an even number: ");
            ///      flag = int.TryParse(Console.ReadLine(), out number);
            ///
            ///  }
            ///
            ///  Console.WriteLine($"the even number you entered is {number}");
            ///   
            #endregion


            #endregion

         #region String
            //string is a class [reference type], internally is an array of chars
            //string is an immutable type -->can't be changed [internally is an array of chars:array is fixed length]
            string Name;
            //Declare for reference of type "string"
            //this reference 'name' is refering to the default value of reference type = null
            //clr will allocate 4 bytes as stack for the reference 'name'
            //clr will allocate 0 bytes at heap

            Name = new string("hema");
            //clr will allocate 8 bytes at heap 2 bytes for each char
            //call constractor
            //load string if the 2 string with same value will get the same hash code  
            //   Name = "ahmed"; // this is syntax suger
            //   string Name02 = "ahmed";
            //   Console.WriteLine($"namem.hash code: {Name.GetHashCode()}");
            //   Console.WriteLine($"namem.hash code: {Name.GetHashCode()}");


            //example
            ///  string message01 = "ahmed";
            ///  Console.WriteLine($"ahmed hash code: {message01.GetHashCode()}");
            ///  message01 = "hamed";
            ///  Console.WriteLine($"hamed hash code: {message01.GetHashCode()}");
            ///  string message02 = "hemaa";
            ///  Console.WriteLine($"ahmed hash code: {message01.GetHashCode()}");
            ///  Console.WriteLine($"hemaa hash code: {message02.GetHashCode()}");
            ///  Console.WriteLine("*****after equality******");
            ///  message02 = message01;
            ///  Console.WriteLine($"ahmed hash code: {message01.GetHashCode()}");
            ///  Console.WriteLine($"hemaa hash code: {message02.GetHashCode()}");


            #endregion

         #region StringBuilder
            StringBuilder message;
            //Declare for reference of type "stringBuilder"
            //this reference 'message' is refering to the default value of reference type = NULL
            //clr will allocate 4 byte at stack for the reference 'message'
            //clr will allocate 0 byte at heap

            message = new StringBuilder("hello");
           // Console.WriteLine($"hash code before change: {message}");
           // message.Append(" hema");
           // Console.WriteLine($"hash code after change: {message}");

            #region StringBuilder method
          ///  message.Append('\n');//to add on it
          ///  message.AppendLine();//to add line to it
          ///  message.AppendFormat($"{0} {1} {true} A");//to add with formate
          ///  message.Replace("hello", "hala");//to replace string with string
          ///  message.Clear();//to clear it 
          ///  message.AppendJoin(";", "ali", "ali");//as concat with sperator
          ///  message.Insert(0,"ali ");//to insert based on index
          ///  Console.WriteLine(message);
            #endregion
            #endregion

         #region Array 1 D array
         int[] numbers;
         //declare for reference of type (array of integer) 
         //this reference 'number' is refering to the default value of reference type=NULL
         //this refernce 'number' can refer to object of type "array of integer "
         //clr will allocate 4 bytes at stack for the reference [uninitalized]
         //clr will allocate 0 bytes at HEAP

         numbers = new int[3];
         //clr will allocate 12 bytes at heap (4 bytes for each element => int)
         //will by initialized with the default value of int = 0
         numbers[0] = 1;
         numbers[1] = 2;
         numbers[2] = 3;
            //to display array data
            ///   Console.WriteLine(numbers[0]);
            ///   Console.WriteLine(numbers[1]);
            ///   Console.WriteLine(numbers[2]);
            ///   Console.WriteLine("length " + numbers.Length + " dimentional "+numbers.Rank);
            ///
            ///   for (int i = 0; i < numbers.Length; i++)
            ///   {
            ///       Console.WriteLine(numbers[i]);
            ///   }


            #endregion

         #region Array 2 D array
            int[,] student = new int[3,5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] students = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            //clr will allocate 60bytes at heap
            //clr will allocate values with default value 0


            //to enter this elements
            for (int i = 0; i < students.GetLength(0)/*3*/; i++)
            {
                Console.WriteLine($"Enter values of student NO.[{i+1}]");

                for (int j = 0; j < students.GetLength(1)/*3*/; /*j++*/) 
                {
                    Console.Write($"Enter value of student NO{i} for materal NO.[{j+1}]: ");
                    //  students[i,j]=int.Parse(Console.ReadLine()); //tocheck all senairos
                    j = int.TryParse(Console.ReadLine(), out students[i, j]) ? ++j:j ;

                }
       
            }
            Console.WriteLine("\n  display array \n");
            //to display them
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"students[{i}, {j}]: {students[i, j]} ");

                }
                Console.WriteLine("\n*************");

            }
            #endregion

            #region array 2 D judged array
            int[][] marks = new int[3][];
            marks[0] = new int[3] { 1, 2, 3 };
            marks[1] = new int[2] { 1,  3 };
            marks[2] = new int[1] { 1 };



            #endregion


        }
 }
}
