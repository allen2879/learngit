using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class MyGenericClass<T>
    {
        private T genericMemberVar;


        public MyGenericClass()
        { }


        public MyGenericClass(T val)
        {
            genericMemberVar = val;
        }

        public T genericMethod(T genericPar)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericPar);

            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVar);

            return genericMemberVar;
        }

        public T genericProperty { get; set; }
            
    }
}
