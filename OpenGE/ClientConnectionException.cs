using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenGE
{
    namespace Network
    {
        public class ClientConnectionException : Exception
        {
            public ClientConnectionException(string message) : base(message)
            {
                StackTrace st = new StackTrace(new StackFrame(true));
                StackFrame sf = st.GetFrame(0);
                Console.WriteLine("An exception was thrown in {0} at line {1} in the method {2} : " + message, sf.GetFileName(), sf.GetFileLineNumber(), sf.GetMethod());
            }
        }
    }
}
