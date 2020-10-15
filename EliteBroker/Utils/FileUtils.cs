using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace EliteBroker.Utils
{
    public class FileUtils
    {
        public static void WaitForFileAccess(string fullPath)
        {
            while (true)
            {
                try
                {
                    using (StreamReader stream = new StreamReader(fullPath))
                    {
                        break;
                    }
                }
                catch
                {
                    Thread.Yield();
                }
            }
        }
    }
}
