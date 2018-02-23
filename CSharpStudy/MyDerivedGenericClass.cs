using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class MyDerivedGenericClass<T> : MyGenericClass<T>
    {
        public T prop
        {
            set;
            get;
        }


        public MyDerivedGenericClass():base() { }

        public MyDerivedGenericClass(T val)
            : base(val)
        {
            prop = val;
        }

        public T ShowYourself()
        {
            Console.WriteLine("Show myself ; {0}", prop.ToString());

            return prop;
        }
    }
}
