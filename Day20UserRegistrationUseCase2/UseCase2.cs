using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20UserRegistrationUseCase2
{
    public class UseCase2
    {
        public void insertData()
        {
            Regex reg = new Regex("^([A-Z]+[A-Za-z])");
            Console.WriteLine("Enter Last name");
            string fname = Console.ReadLine();
            if (reg.IsMatch(fname) && fname.Length >= 3)
                Console.WriteLine("Your last name is : " + fname);
            else
                Console.WriteLine("Enter Valid Last Name");

        }

    }
}
