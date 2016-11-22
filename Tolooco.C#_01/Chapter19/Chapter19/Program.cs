using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter19
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public enum FileAttributes
    {
        Hidden = 1, // 1
        System = 2, // 2
        Archive = 4, // 3
        Readonly = 8, // 4
        Compressed = 13 // 5
    }

    public class File
    {
        public string FileName;
        public FileAttributes Attribute;

        public File(string fileName)
        {
            FileName = fileName;
        }

        public File(string fileName, FileAttributes attribute)
        {
            FileName = fileName;
            Attribute = attribute;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\n Filename: {0}, Attribute: {1}.", FileName, Attribute);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            File oFile = new File("Temp.tmp");

            oFile.Attribute = FileAttributes.Readonly;
            int a = Convert.ToInt32(8 | 1 | 4);
            oFile.Attribute = FileAttributes.Readonly | FileAttributes.Hidden | FileAttributes.Archive; // 13

            if (oFile.Attribute == FileAttributes.Hidden)
            {
                System.Console.WriteLine("This file is Hidden");
            }
            else
            {
                System.Console.WriteLine("This file is not Hidden");
            }

            // Wrong Usage!
            // if (oFile.Attribute & FileAttributes.Hidden == FileAttributes.Hidden)
            if ((oFile.Attribute & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                System.Console.WriteLine("This file is Hidden");
            }
            else
            {
                System.Console.WriteLine("This file is not Hidden");
            }

            if ((oFile.Attribute & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                System.Console.WriteLine("This file is Compressed");
            }
            else
            {
                System.Console.WriteLine("This file is not Compressed");
            }

            oFile.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
