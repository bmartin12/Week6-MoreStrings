﻿using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o'
            //ja 'l' tähte on lauses "hello, world!"
            string hellow = "hello world!".ToLower();

            int counterH = 0;
            int counterO = 0;
            int counterL = 0;
            for(int i = 0; i < hellow.Length; i++)
            {
                if(hellow[i] == 'h')
                {
                    counterH++;
                }
                else if(hellow[i] == 'o')
                {
                    counterO++;
                }
                else if (hellow[i]) == 'l')
                        {
                counterL++;
            }
            else
            {
                continue;
            }

            }
        }
    }
}
