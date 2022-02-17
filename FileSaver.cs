using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileSaver : IFileSaver
    {
        //Saves the list of strings to the "sorted-names-list.txt" file in the local directory
        public bool Save(List<string> names)
        {
            try
            {
                string saveFileName = "sorted-names-list.txt";
                FileStream outfile = new FileStream(saveFileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outfile);
                foreach (string name in names)
                    writer.WriteLine(name);
                writer.Close();
                outfile.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}