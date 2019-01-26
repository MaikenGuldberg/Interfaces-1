using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoStuff;

namespace DoStuff.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoThings myStuff = new DoHickey();
            Console.WriteLine("Do you want to do dickey or hickey?\nIf dickey type in d or if hickey type in h:");
            string input = Console.ReadLine();
            if (input.Equals("d"))
            {
                myStuff = new DoDickey();
            }
            myStuff.DoNothing();
            myStuff.DoSomething(3);
            myStuff.DoSomethingElse("Hallo world");
            Console.ReadLine();
        }
    }
}
