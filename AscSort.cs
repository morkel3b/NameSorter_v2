using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    class AscSort : ISort
    {
        //Sorts the list of strings in ascending order by last name then given names
        public List<string> Sort(List<string> names)
        {
            Converters converters = new Converters();
            var namesList = converters.ConvertToObject(names);
            var sortedList = namesList.OrderBy(x => x.lastName).ThenBy(x => x.givenName).ToList();
            return converters.ConvertToString(sortedList);
        }
    }
}