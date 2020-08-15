using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers anum = new AddNumbers();
            anum.ev_EvenNumber += new AddNumbers.dg_EvenNumber(EventMessage);
            anum.Add();
            Console.Read();
        }
        static void EventMessage()
        {
            Console.WriteLine("-- Event Executed : This is even number --");
        }
    
    }
    class AddNumbers
    {
        public delegate void dg_EvenNumber();
        public event dg_EvenNumber ev_EvenNumber;

        public void Add()
        {
            int res;
            res = 10 + 12;
            Console.WriteLine(res.ToString());

            if((res% 2 == 0)&&(ev_EvenNumber != null))
            {
                ev_EvenNumber();
            }
        }
    }

}
