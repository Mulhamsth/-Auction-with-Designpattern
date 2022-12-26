using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    internal class LogWriter
    {
        // Singleton implementation
        private static StreamWriter sw;//Deklaration
        private static LogWriter Instance { get; set; } = null;
        private static readonly object Lock = new object();
        public static LogWriter GetInstance
        {
            get {
                lock (Lock)
                {
                    if (Instance == null)
                        Instance = new LogWriter();
                    return Instance;
                }
            }
        }

        private LogWriter() {
            //creating the log name automaticly
            string file = "Log_" + DateTime.Now.ToString().Replace('/', '_')
                + DateTime.Now.Millisecond.ToString() + ".txt";
            sw = new StreamWriter(file.Replace(':', '_'));//Initialisierung
        }

        public void LogDetails(string message)
        { 
            sw.WriteLine(message + "\t at "
                + DateTime.Now.ToString());
            sw.Flush();
        }
    }
}
