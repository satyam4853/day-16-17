﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class RegexPattern
    {
        static string message = "Hello <<name>>, We have your full name as <<full name>> in our system.Your contact number is 91-xxxxxxxxxx.Please, let us know in case of any clarification Thank you BridgeLabz 01/01/2016 .";

        public void CustomRegexMessage()
        {
            string patternName = "^[A-Za-z]*$";
            string patternFullName = "^[A-Za-z ]*$";
            string patterPhoneNumber = "^[0-9]{2}[ ][0-9]{10}";
            string patternDate = "^[0-9]{2}-[0-9]{2}-[0-9]{4}";

            Regex regexForName = new Regex(patternName);
            Regex regexForFullName = new Regex(patternFullName);
            Regex regexForPhone = new Regex(patterPhoneNumber);
            Regex regexDate = new Regex(patternDate);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            if (regexForName.IsMatch(name))
            {
                message = message.Replace("<<name>>", name);
            }
            else
            {
                Console.WriteLine("Your name format is wrong");
            }
            //*******************************************FUll Name************************************************
            Console.WriteLine("Enter your Full name");
            string fullName = Console.ReadLine();
            if (regexForFullName.IsMatch(fullName))
            {
                message = message.Replace("<<full name>>", fullName);
            }
            else
            {
                Console.WriteLine("Your full name format is wrong");
            }

            //********************************Phone number*********************************
            Console.WriteLine("Enter your Phone number");
            string phno = Console.ReadLine();
            if (regexForPhone.IsMatch(phno))
            {
                message = message.Replace("91-xxxxxxxxxx", phno);
            }
            else
            {
                Console.WriteLine("Phone number format is wrong");
            }
            //************************Date******************************
            Console.WriteLine("Enter the date");

            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (regexDate.IsMatch(date))
            {

                message = message.Replace("01/01/2016", date);
            }
            else
            {
                Console.WriteLine("Date format is wrong");
            }

            //************************
            Console.WriteLine(message);

        }

    }
}
