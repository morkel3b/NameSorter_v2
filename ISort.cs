using System;
using System.Collections.Generic;

namespace NameSorter
{
    public interface ISort
    {
        List<string> Sort(List<string> names);
    }
}