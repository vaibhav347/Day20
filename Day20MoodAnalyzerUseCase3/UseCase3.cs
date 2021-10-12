using System;
using System.Collections.Generic;
using System.Text;

namespace Day21MoodAnalyzerUseCase3
{
    public class UseCase3
    {
        int num3, num1 = 5, num2 = 0;
        public string analyzeMood(string msg)
        {
            try
            {
                if (msg.Contains("happy"))
                    return "Happy";
                else

                    num3 = num1 / num2;
            }catch(Exception e)
            {
                Console.WriteLine("Invalid Mood : " + e.Message);
            }
            return "Please Enter Valid Mood";
        }
    }
}
