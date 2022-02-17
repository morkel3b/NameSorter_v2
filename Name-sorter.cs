using System;
using static System.Console;

namespace NameSorter
{
    class NameSorter
    {
        static void Main(string[] args)
        {
            //checks if arguments were used at program execution
            if (args.Length == 0)
            {
                WriteLine("No arguments used!");
                WriteLine("This program must be executed with arguments. eg. name-sorter <file-name.txt>");
                Environment.Exit(0);
            }
            ISort sort;
            IFileLoader fileLoader = new FileLoader();
            IFileSaver fileSaver = new FileSaver();
            bool isDesc = false;
            
            //Default sorter is ascending (AscSort). Checks if second argument is "desc" and if so, uses DescSort
            if (args.Length > 1)
                if (args[1] == "desc")
                    isDesc = true;
            if (isDesc)
                sort = new DescSort();
            else
                sort = new AscSort();
            
            //Loads the textfile using the filename from the first argument
            var names = fileLoader.Load(args[0]);
            if (names == null)
                Environment.Exit(0);
            
            //Sorts the list of names using the appropriate sort function
            names = sort.Sort(names);
            names.ForEach(WriteLine);
            
            //Saves the list of names to text file
            bool isSaved = fileSaver.Save(names);
            ProgramExit(isSaved);
        }
        static void ProgramExit(bool isSaved)
        {
            if (!isSaved)
            {
                WriteLine("\nAn error has occured.");
                WriteLine("The program will now terminate. Press any key to close...");
            }
            else
            {
                WriteLine("\nSorted names saved successfully to sorted-names-list.txt");
                WriteLine("The program will now terminate. Press any key to close...");
            }
            ReadKey();
        }
    }
}
