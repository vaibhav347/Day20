using System;

namespace Day21MoodAnalyzerUseCase2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer obj = new MoodAnalyzer();
            MoodAnalyzer obj2 = new MoodAnalyzer("I am in sad mood");
            string msg = obj2.analyzeMood();
            Console.WriteLine(msg);
        }
    }
}
