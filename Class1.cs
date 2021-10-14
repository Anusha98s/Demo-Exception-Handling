using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception_Handling
{
    class Class1
    {
    }
    [Serializable]
    public class StudentNotFoundException : Exception
    {
        public string StudentName { get; set; }
        public StudentNotFoundException() { }

        public StudentNotFoundException(string message) : base(message) {}

        //Console.WriteLine("Again base class method is defined in exception class");

        public StudentNotFoundException(string Message, Exception InnerException) : base(Message, InnerException) { }

        public StudentNotFoundException(string message, string studentName) 
        :this(message)
           
             {
                      StudentName = studentName;
    }
            
        
    }
}
