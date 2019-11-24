using System;
using System.IO;
using SingleTone;


namespace  singleTone
{
    public  sealed class Log : Ilogger
    {
        private  static Lazy<Log> LogInstatnce = new Lazy<Log>(() => new Log());
        private Log()
        {
            Console.WriteLine("Go To check  singleTone Pattern");
        }
        public  static Log GetInstance
        {
            get => LogInstatnce.Value;
        }
        public void LogToText( string text)
        {
            if (!File.Exists(@"D:\ singleTone.txt"))
            {
                File.Create(@"D:\ singleTone.txt").Close();
            }
            File.WriteAllText(@"D:\ singleTone.txt", text);
        }


        public void ReadFileText()
        {
            if (!File.Exists(@"D:\ singleTone.txt"))
            {
                Console.WriteLine(" sorry File not exi st");
                return;
            }

            using (var file = new StreamReader(@"D:\ singleTone.txt"))
            {
                var content = file.ReadLine();
                Console.WriteLine(content);
            }
        }
    }
}
