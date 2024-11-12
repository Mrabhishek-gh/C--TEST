using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TEST
{
    internal class GenClass<T>
    {
        List<T> list = new List<T>();
        public void add( T obj)
        {

            list.Add(obj);        
        }

        public void remove( int ind ) 
        {
            list.RemoveAt(ind);
        }
        
        public IEnumerable <T> Getobject()
        {
                return list;
        }
    }
}
