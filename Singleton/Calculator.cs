﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Calculator
    {
        private static object syncRoot = new Object();

        private bool IsCalculating;
        private static Calculator _Instance;
        public static Calculator Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (_Instance == null)
                    {
                        _Instance = new Calculator();
                    }
                }

                return _Instance;
            }
        }

        private Calculator()
        {
            Console.WriteLine("Starting");
        }


        public void Calc()
        {
            if (IsCalculating)
            {
                Console.WriteLine("is calculating...");
                return;
            }
            IsCalculating = true;
            Console.WriteLine("Boiling...");
            IsCalculating = false;
        }

    }
}