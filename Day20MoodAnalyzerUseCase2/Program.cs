using System;

namespace Day21MoodAnalyzerUseCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer obj = new MoodAnalyzer();
            MoodAnalyzer obj2 = new MoodAnalyzer("My mood is very happy");
            string msg=obj2.analyzeMood();
            Console.WriteLine(msg);
        }
    }
}
