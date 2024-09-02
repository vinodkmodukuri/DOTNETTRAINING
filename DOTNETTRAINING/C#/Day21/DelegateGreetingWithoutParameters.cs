using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public delegate void GreetingDelegate();

    internal class DelegateGreetingWithoutParameters
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, everyone");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye, everyone");

        }

        public static void Main(string[] args)
        {


/*            Creating the instance of an object and calling the methods
*/
            DelegateGreetingWithoutParameters delegateGreeting = new DelegateGreetingWithoutParameters();
            /*            delegateGreeting.SayHello();
                        delegateGreeting.SayGoodbye;*/

            GreetingDelegate greetingDelegate = new GreetingDelegate(delegateGreeting.SayHello);
            GreetingDelegate greetingDelegate1 = new GreetingDelegate(delegateGreeting.SayGoodbye);



            Console.ReadKey();
        }

    }
}
