using System;
using CSharpGrammer.debug;

namespace CsharpGrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug debug = new Debug(10, 20);
            debug.AddAndPrint();
        }
    }
}