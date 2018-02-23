using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {

        //定义一个委托变量
        public delegate T add<T>(T val1, T val2);       

        static void Main(string[] args)
        {

            //MyGenericClass<int> intGenericObj = new MyGenericClass<int>(20);

            //int intRet = intGenericObj.genericMethod(50);



            //MyGenericClass<string> stringGenericObj = new MyGenericClass<string>("asdasd");

            //string stringRet = stringGenericObj.genericMethod("world");

            //MyStringDerivedClass strDeObj = new MyStringDerivedClass("pual");

            //strDeObj.genericMethod("chris");

            //strDeObj.SayYourName();


            //MyDerivedGenericClass<string> deObj = new MyDerivedGenericClass<string>("prop");

            //deObj.genericMethod("par");

            //deObj.ShowYourself();

            //测试泛型委托
            add<int> sum1 = AddInt;
            Console.WriteLine("sum1 = {0}", sum1(10, 87));

            add<string> sum2 = AddString;
            Console.WriteLine("sum2 = {0}", sum2("10", "87"));


            Console.ReadLine();
        }

        public static int AddInt(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string AddString(string val1, string val2)
        {
            return val1 + val2;
        }
    }
}
