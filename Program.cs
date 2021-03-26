using System;

namespace testinterfacedotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Testing test = new Testing();
            Console.WriteLine(test.MyIntegerField);
            test.MyIntegerField = 3;
            Console.WriteLine(test.MyStringField);
            test.MyStringField = "My String 323";
            Console.WriteLine(test.MyStringField);
            Console.WriteLine(test.MyIntegerField);
            Console.WriteLine(test.IsworkDone("yes"));
            Console.WriteLine(test.IsworkDone(""));
            Console.WriteLine(test.Mystring("returing string"));
            test.MyProcess();

        }
    }
   
}
