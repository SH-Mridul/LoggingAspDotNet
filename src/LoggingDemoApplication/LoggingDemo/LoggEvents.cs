using System.IO;
namespace LoggingDemo
{
    public static class LoggEvents
    {
        public static void LogToFile(string title,string message,IWebHostEnvironment env)
        {
            bool exist = Directory.Exists(env.WebRootPath + "\\" + "LogFolder");
            if (!exist)
            {
                Directory.CreateDirectory(env.WebRootPath + "\\" + "LogFolder");
            }

            StreamWriter swlog;
            string logPath = string.Empty;
            string fileName = DateTime.Now.ToString("ddMMyyyy")+".txt";
            logPath = Path.Combine(env.WebRootPath + "\\" + "LogFolder", fileName);
            

            if (!File.Exists(logPath)) 
            { 
                swlog = new StreamWriter(logPath);
            }
            else
            {
                swlog = File.AppendText(logPath);
            }

            swlog.WriteLine("log entry");
            swlog.WriteLine("{0}{1}",DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            swlog.WriteLine("Message Title :{0}",title);
            swlog.WriteLine("Message :{0}",message);
            swlog.WriteLine("---------------------------------------------------------\n");
            swlog.Close();
        }
    }
}
