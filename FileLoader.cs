using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileLoader : IFileLoader
    {

        //Loads a list of strings from an external .txt file in the directory using the file name given
        public List<string> Load(string fileName)
        {
            //Checks if the file exists
            if (!File.Exists(fileName))
            {
                WriteLine("File not found: {0}", fileName);
                return null;
            }

            FileStream infile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            string recordIn;
            List<string> names = new List<string>();
            recordIn = reader.ReadLine();
            //Adds the records from the stream reader to a list
            while (recordIn != null)
            {
                names.Add(recordIn);
                recordIn = reader.ReadLine();
            }
            reader.Close();
            infile.Close();
            return names;

        }
    }
}
