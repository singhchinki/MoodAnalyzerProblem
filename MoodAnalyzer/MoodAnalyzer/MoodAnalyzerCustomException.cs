 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    /// <summary>
    /// For UseCase -3 MoodAnalysisExceptionException Class For Handling Exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        /// <summary>
        /// Parameterized constructor sts the ExceptionType
        /// </summary>
        private readonly ExceptionType type;
        /// <summary>
        /// Parameterized Constructor sets the Exception Type and message.
        /// Initializes a new instance of the <see cref="MoodAnalyzerCustomException"/> class.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyzerCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
