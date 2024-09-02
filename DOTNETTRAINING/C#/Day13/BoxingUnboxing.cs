using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class BoxingUnboxing
    {

        public static void Main(string[] args)
        {
            //Boxing means converting value type to reference type 
            int x = 10; //Value type 
            object myobject; //Referency type - Create a new object by using object  - 
            myobject = x; //Implicit conversion  //Someting whic is understand and but not described clearly or directly
            Console.WriteLine(x);
            Console.WriteLine(myobject);

            //Unboxing - Expeclicitly Converting reference type to value type  - Very clear without vagueness 
            
            object variable1 = 30;
            int a;
            a = Convert.ToInt32(variable1);
            Console.WriteLine(variable1);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

