using System;

namespace OpenGE
{
    namespace Utilities
    {
        public class Debug
        {
            public static void Log(object message)
            {
                Console.WriteLine(message.ToString());
            }

        }
    }
}