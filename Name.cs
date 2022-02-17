using System;

namespace NameSorter
{
    class Name
    {
        public string lastName { get; set; }
        public string givenName { get; set; }

        //The constructor uses the last part of the string as the last name and all other parts as the given name
        //After using 3 given names, the rest of the name is ignored.
        public Name(string name)
        {
            string[] splitName = name.Split(' ');
            string tempGivenName;
            lastName = splitName[splitName.Length - 1];
            tempGivenName = splitName[0];
            if (splitName.Length > 2)
                tempGivenName += " " + splitName[1];
            if (splitName.Length > 3)
                tempGivenName += " " + splitName[2];
            givenName = tempGivenName;
        }
    }
}