using System;
using System.Collections.Generic;

namespace NameSorter
{
    interface IFileSaver
    {
        bool Save(List<string> names);
    }
}