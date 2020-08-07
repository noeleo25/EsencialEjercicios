using System;
using System.Collections.Generic;
using System.Text;

namespace EsencialPractica
{
    class Concat<T>
    {
        public string result;
        public void Add(T obj)
        {
            result += obj.ToString();
        }
    }
}
