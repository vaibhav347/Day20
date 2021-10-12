using System;
using System.Collections.Generic;
using System.Text;

namespace Day21MoodAnalyzerUseCase2._2
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string msg)
        {
            message = msg;
        }
        public string analyzeMood()
        {
            if (message.Contains("happy"))
                return "Happy";
            else if (message.Contains("sad"))
                return "Sad";
            else
                return "Unpredctable Mood";
        }
    }
}

