using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleTone;

namespace  SingleTone
{
  
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Please write  Some text");
            var text = Console.ReadLine();
            Log.GetInstance.LogToText(text);
            Console.WriteLine("Please wait read all file text");
            Log.GetInstance.ReadFileText();
            Console.ReadLine();
            
        }

      
    }
}
