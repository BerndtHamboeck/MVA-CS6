//using System;
//using static System.Console;


//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Hello world!");
//            ReadLine();
//        }

//    }
//}


//Example 1
//using static System.Console;
//using static CS6.SomeOtherClass;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Hello world!");
//            HelloClass();
//            ReadLine();
//        }
//    }

//    static class SomeOtherClass
//    {
//        public static void HelloClass()
//        {
//            WriteLine("Hello universe!");
//        }
//    }
//}


//Example 2
//using System;
//using static System.Console;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
//            WriteLine(employee.ID);
//            ReadLine();
//        }
//    }

//    public class Employee
//    {
//        public Guid ID { get; set; } = Guid.NewGuid();
//    }

//}

//Example 3
//using System.Collections.Generic;
//using static System.Console;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var player = new Dictionary<string, string>()
//            {
//                ["Lionel Messi"] = "Argentinien",
//                ["Cristiano Ronaldo"] = "Portugal",
//                ["David Alaba"] = "Österreich"
//            };

//            foreach (KeyValuePair<string, string> keyValuePair in player)
//            {
//                WriteLine(keyValuePair.Key + ": " +
//                keyValuePair.Value + "\n");
//            }

//            ReadLine();
//        }
//    }
//}

//Example 4
using static System.Console;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string firstName = "Berndt";
//            string lastName = "Hamböck";

//            WriteLine($"Ich heisse {firstName} {lastName}!");

//            ReadLine();
//        }
//    }
//}

//Example 5

//using System;
//using static System.Console;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = null;
//            DoSomething(name);
//            ReadLine();
//        }

//        public static void DoSomething(string nameParam)
//        {
//            if (nameParam == null)
//                throw new ArgumentException(nameof(nameParam) + " is null");
//        }
//    }
//}


//using static System.Console;

//namespace CSBefore6
//{
//    class Program
//    {
//        private static double MultiplyNumbers(double num1, double num2)
//            => num1 * num2;

//        static void Main(string[] args)
//        {
//            double num1 = 5;
//            double num2 = 10;

//            WriteLine(MultiplyNumbers(num1, num2));
//            ReadLine();
//        }
//    }
//}


//Example 6
//using System;

//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var httpStatusCode = 404;
//            Write("Exception type: ");

//            try
//            {
//                throw new Exception(httpStatusCode.ToString());
//            }
//            catch (Exception ex) when (ex.Message.Equals("400"))
//            {
//                Write("Bad Request");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("401"))
//            {
//                Write("Unauthorized");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("402"))
//            {
//                Write("Payment Required");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("403"))
//            {
//                Write("Forbidden");
//                ReadLine();
//            }
//            catch (Exception ex) when (ex.Message.Equals("404"))
//            {
//                Write("Not Found");
//                ReadLine();
//            }

//            ReadLine();
//        }
//    }
//}

//Example 7
using System;
using System.Net;

namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWebSite();
        }

        private static async void CallWebSite()
        {
            WebClient wc = new WebClient();
            string result;
            try
            {
                result = await wc.DownloadStringTaskAsync(new Uri("http://badurl"));
            }
            catch
            {
                //pre C# 6 -> error CS1985: Cannot await in the body of a catch clause
                result = await wc.DownloadStringTaskAsync(new Uri("http://fallbackurl"));
            }
        }
    }
}

//Example 8
//using static System.Console;


//namespace CS6
//{
//    class Program
//    {
//        private static double MultiplyNumbers(double num1, double num2) => num1 * num2;
//        static void Main(string[] args)
//        {
//            double num1 = 5;
//            double num2 = 10;

//            WriteLine(MultiplyNumbers(num1, num2));
//            ReadLine();
//        }
//    }
//}

//Example 9
//using System;
//using static System.Console;


//namespace CS6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person();
//            if (person.Name == String.Empty)
//            {
//                person = null;
//            }

//            WriteLine(person?.Name ?? "Field is null.");

//            ReadLine();
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; } = "";
//    }
//}