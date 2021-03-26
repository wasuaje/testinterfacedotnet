
using System;

namespace testinterfacedotnet
{
    public interface ITestInterface
    {
        bool IsworkDone(string job);  

        string Mystring(string str);

        void MyProcess();

        int MyIntegerField{get; set;}

        string  MyStringField{get; set;}

    }
}