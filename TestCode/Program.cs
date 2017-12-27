using System;

namespace TestCode
{
    public delegate void nonEventDelegate();
    class Program
    {
        
        // thisDelegate2 dee;

        static void Main(string[] args)
        {



            // DelegateTester delegateTester1 = new DelegateTester();
            // delegateTester1.instanceOfTV(3);
            /*
            int i = int.Parse(Console.ReadLine());

            thisDelegate2 dee;


            dee = Double;
            dee += triple;
            dee += Double;
            //  dee += triple;
            double x = dee(i);
            Console.WriteLine(x);


            Notifications2 note2 = new Notifications2();
            note2.nonEventEvent += User3.Checkhandler;
            note2.nonEventEvent += User3.Checkhandler;
            note2.NotifyOnCell2();



            NotificationofMethods obj = new NotificationofMethods();

            obj.thisDelegateEvent += User1.Xhandler;
            obj.thisDelegateEvent += User2.Yhandler;
            obj.thisDelegateEvent -= User1.Xhandler;
            obj.thisDelegateEvent += User2.Yhandler;
            obj.thisNonNumber += User1.anotherTestMethod;
            obj.NotifyOnCell(i);

            Console.ReadLine();
            */
            /*
            firstClass firstClass1 = new firstClass();
            
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
            Console.ReadLine();
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
           // Environment.Exit(0);
        }
        */

        }
        static int Double(int input)
        {
            return (input * 2);
        }
        static int triple(int input)
        {
            return (input * 3);
        }
    }

    class Notifications2
    {
        public int testInt;

        public nonEventDelegate nonEventEvent;
        public void NotifyOnCell2()
        {
            if (nonEventEvent != null)
            {
                nonEventEvent();
            }
        }

    }
    class User3
    {
        static anotherClass aClass= new anotherClass();

        static int x = 1;
        public static void Checkhandler()
        {
            aClass.anotherMethod(6);
            Console.WriteLine("the tird" + x);
            x++;
            
        }
    }
    class anotherClass{
        public void anotherMethod(int x)
        {

            Console.WriteLine("the fort" + x);
        }
     }

    class NotificationofMethods
    {
        public delegate void thisDelegate(int num);
        public event thisDelegate thisDelegateEvent;
        public delegate void nonNumDelegate();
        public event nonNumDelegate thisNonNumber;
        static int c;
        public void NotifyOnCell(int x)
        {
            Console.WriteLine("test");
            if(thisDelegateEvent!= null)
            {
                thisDelegateEvent(x);
                thisNonNumber();
                Console.WriteLine(c+"what");
                c++;
            }
        }
    }
    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by  user1");
        }
        public static void anotherTestMethod()
        {
            Console.WriteLine(1 + 2);
        }
    }
    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event received by  user2");
        }
    }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}