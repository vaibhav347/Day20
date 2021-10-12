using System;

namespace Day21MoodAnalyzerUseCase1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase1 obj = new UseCase1();
            string msg = obj.analyzeMood("I am in sad mood");
            Console.WriteLine(msg);
        }
    }
}
