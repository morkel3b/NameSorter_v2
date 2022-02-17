using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    class Converters
    {
        //converts the list of strings to a list of Name objects
        public List<Name> ConvertToObject(List<string> names)
        {
            List<Name> namesList = new List<Name>();
            foreach (string name in names)
                namesList.Add(new Name(name));
            return namesList;
        }

        //converts the list of Name objects to a list of strings
        public List<string> ConvertToString(List<Name> namesList)
        {
            List<string> sortedNames = new List<string>();
            foreach (Name name in namesList)
                sortedNames.Add(name.givenName + " " + name.lastName);
            return sortedNames;
        }
    }
}