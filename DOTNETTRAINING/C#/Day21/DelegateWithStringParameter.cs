using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{

    public delegate void SpeakDelegate(string message);
    internal class DelegateWithStringParameter
    {

        public void SayHello(string message) 
        { 
            Console.WriteLine("Hello {0}", message);
        }

        public void SayGoodbye(string message)
        {
            Console.WriteLine("Goodbye {0}", message);
        }

        public void SayThankyou(string message)
        {
            Console.WriteLine("Thankyou {0}", message);
        }


        public static void Main(string[] args)
        {

            DelegateWithStringParameter delegateWithStringParameter = new DelegateWithStringParameter();
            
            /*
                        delegateWithStringParameter.SayHello("Tim");
                        delegateWithStringParameter.SayHello("Tom");
                        delegateWithStringParameter.SayHello("David");*/

            SpeakDelegate speakDelegate = new SpeakDelegate(delegateWithStringParameter.SayHello);
            speakDelegate("Jenny");

            SpeakDelegate speakDelegate1 = new SpeakDelegate(delegateWithStringParameter.SayGoodbye);
            speakDelegate("Patrik");

            SpeakDelegate speakDelegate2 = new SpeakDelegate(delegateWithStringParameter.SayThankyou);
            speakDelegate("Kim");

            Console.ReadLine();
        }
    }
}
