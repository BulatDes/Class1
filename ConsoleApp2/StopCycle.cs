﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StopCycle
    {
        public void Print(int arg)
        {
            if (arg > 25) 
            {
                Console.WriteLine("Квадрат числа больше 25!");
                Console.ReadKey();
                Environment.Exit(0);
            }
                
        }
    }
}
