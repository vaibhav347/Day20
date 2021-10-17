using System;

namespace Day21MoodAnalyzerUseCasee3
{
    class Program
    {
        static void Main(string[] args)
        {
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
