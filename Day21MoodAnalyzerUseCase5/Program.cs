using System;
using System.Reflection;

namespace Day21MoodAnalyzerUseCasee3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Day21MoodAnalyzerUseCasee3.UseCase1);
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo method in mi)
            {
                Console.WriteLine(method);
            }
            UseCase1 obj = new UseCase1();
            try
            {
                obj.analyzeMood("My mood is null");
            }
            catch (MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
