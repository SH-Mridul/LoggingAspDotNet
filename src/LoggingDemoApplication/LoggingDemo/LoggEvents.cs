using System.IO;
namespace LoggingDemo
{
    public static class LoggEvents
    {
        public static void LogToFile(string title,string message)
        {
            StreamWriter swlog;
            string fileName = "LogFile.txt";

            if (!File.Exists(fileName)) 
            { 
                swlog = new StreamWriter(fileName);
            }
            else
            {
                swlog = File.AppendText(fileName);
            }

            swlog.WriteLine("log entry");
            swlog.WriteLine("{0}{1}",DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            swlog.Close();
        }
    }
}
