using System;

namespace ConsolePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = "hello";
            Console.WriteLine(o);//hello
            AssignValue(ref o);
            Console.WriteLine(o);//hello
            Console.ReadLine();
        }

        public static void AssignValue(ref object o)
        {
            o = "World";
        }
    }

    public class ChildClass : ParentClass
    {
        public override int GetInteger()
        {
            int a;
            try
            {
                a = 1;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            return a;
        }

        public override string GetString()
        {
            string b = string.Empty;
            try
            {
                b = "Hello";
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            return b;
        }
    }

    public class Child1Class : IMethod
    {
        public string GetString()
        {
            return "World";
        }

        public int GetInteger()
        {
            return 1;
        }

    }

    public abstract class ParentClass
    {
        public abstract string GetString();
        public abstract int GetInteger();
    }

    public interface IMethod
    {
        string GetString();
        int GetInteger();
    }
}
