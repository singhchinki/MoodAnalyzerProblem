﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        // TC.4.1 Create MoodAnalyser Method to create object of MoodAnlyser class
        
        public static object CreateMoodAnalyser(string ClassName, string constructorName)
        {
            string pattern = @"." + constructorName + "s";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
          
         
        }
    }
}
