using System;

namespace Day21MoodAnalyzerUseCase3
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase3 obj = new UseCase3();
            string msg = obj.analyzeMood("My mood is ok ok type");
            Console.WriteLine(msg);
        }
    }
}
