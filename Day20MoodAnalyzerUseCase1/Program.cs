using System;

namespace Day21MoodAnalyzerUseCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase1 obj = new UseCase1();
            string msg=obj.analyzeMood("My mood is happy");
            Console.WriteLine(msg);
        }
    }
}
