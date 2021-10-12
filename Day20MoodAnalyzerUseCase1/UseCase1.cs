using System;
using System.Collections.Generic;
using System.Text;

namespace Day21MoodAnalyzerUseCase1
{
    public class UseCase1
    {
        public string analyzeMood(string msg)
        {
            if (msg.Contains("happy"))
                return "happy";
            else if (msg.Contains("sad"))
                return "sad";
            else
                return "Unpredictable mood";
            
        }
    }
}
