using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    class DescSort : ISort
    {
        //Sorts the list of strings in descending order by last name then given names
        public List<string> Sort(List<string> names)
        {
            Converters converters = new Converters();
            var namesList = converters.ConvertToObject(names);
            var sortedList = namesList.OrderByDescending(x => x.lastName).ThenByDescending(x => x.givenName).ToList();
            return converters.ConvertToString(sortedList);
        }
    }
}