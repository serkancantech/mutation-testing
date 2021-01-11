﻿using System;

namespace CalculatorApp
{
	public class Calculator
	{
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
        
        public double Divide(int x, int y)
        {
            return Convert.ToDouble(x / y);
        }
    }
}
