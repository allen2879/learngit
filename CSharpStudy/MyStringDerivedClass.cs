using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class MyStringDerivedClass : MyGenericClass<string>
    {

        public string name
        {
            get;
            set;
        }

        public string SayYourName()
        {
            Console.WriteLine("My name is {0}", name);

            return name;
        }

        public MyStringDerivedClass()
        {
            name = "susi";
        }

        public MyStringDerivedClass(string val)
            : base(val)
        {
            name = val;
        }
    }
}
