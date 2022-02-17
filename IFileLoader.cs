using System;
using System.Collections.Generic;

namespace NameSorter
{
    interface IFileLoader
    {
        List<string> Load(string fileName);
    }
}