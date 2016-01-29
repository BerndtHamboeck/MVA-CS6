using System;

namespace CSBefore6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }
}


//Example 2
//using System;

//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
//            Console.WriteLine(employee.ID);
//            Console.ReadLine();
//        }
//    }

//    public class Employee
//    {
//        public Employee()
//        {
//            ID = Guid.NewGuid();
//        }

//        public Guid ID { get; set; }
//    }

//}



//Example 3
//using System;
//using System.Collections.Generic;

//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var stars = new Dictionary<string, string>()
//            {
//                 { "Lionel Messi", "Argentinien" },
//                 { "Cristiano Ronaldo", "Portugal" },
//                 { "David Alaba", "Österreich" }
//            };

//            foreach (KeyValuePair<string, string> keyValuePair in stars)
//            {
//                Console.WriteLine(keyValuePair.Key + ": " +
//                keyValuePair.Value + "\n");
//            }

//            Console.ReadLine();
//        }
//    }
//}

//Example 4
//using System;

//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string firstName = "Berndt";
//            string lastName = "Hamböck";

//            Console.WriteLine("Name : " + firstName + " " + lastName);
//            Console.WriteLine("Name : {0} {1}", firstName, lastName);

//            Console.ReadLine();
//        }
//    }
//}

//Example 5
//using System;

//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = null;
//            DoSomething(name);
//            Console.ReadLine();
//        }

//        public static void DoSomething(string nameParam)
//        {
//            if (nameParam == null)
//                throw new ArgumentException("name is null");
//        }
//    }
//}

//Example 6
//using static System.Console;

//namespace CSBefore6
//{
//    class Program
//    {
//        private static double MultiplyNumbers(double num1, double num2)
//        {
//            return num1 * num2;
//        }

//        static void Main(string[] args)
//        {
//            double num1 = 5;
//            double num2 = 10;

//            WriteLine(MultiplyNumbers(num1, num2));
//            ReadLine();
//        }
//    }
//}

//Example 7
//using System;
//using static System.Console;


//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var httpStatusCode = 404;
//            Write("HTTP Error: ");

//            try
//            {
//                throw new Exception(httpStatusCode.ToString());
//            }
//            catch (Exception ex)
//            {
//                if (ex.Message.Equals("500"))
//                    Write("Bad Request");
//                else if (ex.Message.Equals("401"))
//                    Write("Unauthorized");
//                else if (ex.Message.Equals("402"))
//                    Write("Payment Required");
//                else if (ex.Message.Equals("403"))
//                    Write("Forbidden");
//                else if (ex.Message.Equals("404"))
//                    Write("Not Found");
//            }

//            ReadLine();
//        }
//    }
//}

//Example 8
//none

//Example 9
//using System;
//using System.Net;
//using System.Threading.Tasks;

//namespace CSBefore6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CallWebSite();
//        }

//        private static async void CallWebSite()
//        {
//            WebClient wc = new WebClient();
//            Task<string> downloadTask = wc.DownloadStringTaskAsync(new Uri("http://badurl"));
//            downloadTask = downloadTask.ContinueWith(
//                t =>
//                {
//                    return wc.DownloadStringTaskAsync(new Uri("http://fallbackurl")).Result;
//                }, TaskContinuationOptions.OnlyOnFaulted);

//            var result = await downloadTask;
//        }
//    }

//}