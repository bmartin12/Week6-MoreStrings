using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'n' tähte on
            //lauses "don't panic"
            string dontPanic = "Don't panic";
            int counter = 0;
            for(int i = 0; i < dontPanic.Length; i++)
            {
                if(dontPanic[i] == 'n')
                {
                    counter++;
                }
                
            }
            Console.WriteLine($"lauses {dontPanic} on counter 'n' tähte");
        }
    }
}
