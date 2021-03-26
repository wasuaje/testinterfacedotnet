using System;

namespace testinterfacedotnet
{

 class Testing : ITestInterface
    {
        private int Entero;
        public bool IsworkDone(string str)
        {
            if (str == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public string Mystring(string str)
        {
            return $"my string returned{str}";
        }
        public void MyProcess()
        {
            Console.WriteLine("Process done!");
        }
        public int MyIntegerField{
            get
            {
                 return Entero+12030;
             }
            set
            {
                Entero = value;
            }
            }
        public string MyStringField{get; set;}
    }
}