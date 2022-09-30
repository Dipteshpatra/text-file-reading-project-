using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace text_file_reading
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Ripon2.txt");
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);    
            FileInfo fileInfo = new FileInfo(filepath);
            string files = fileInfo.Name;
            string files1=fileInfo.Extension;
            Console.WriteLine(files);
            Console.WriteLine(files1);
            int c = 2;    
            for(int i=0; i<file.Length; i++)
            {
                Console.WriteLine(file[i]);
                if (file[i] == ' ' )
                    c++;
            }
            Console.WriteLine("total no of words:-"+c);

            ////File.Delete(@"C:\Users\moback\Documents\Ripon1.txt");
            //System.IO.File.Copy(@"C:\Projects\text read from file\Ripon.txt", @"C:\Users\moback\Documents\Ripon1.txt", true);
           

        }
    }
}
