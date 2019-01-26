using System;

namespace DoStuff
{
    public class DoHickey: IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine(this.GetType().Name + ": :" + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public int DoSomething(int number)
        {
            Console.WriteLine(this.GetType().Name + ": :" + System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + number.ToString());
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine(this.GetType().Name + ": :" + System.Reflection.MethodBase.GetCurrentMethod().Name + ": " + input);
            return input;
        }
    }
}