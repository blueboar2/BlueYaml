﻿using System;

namespace BlueYamlTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new PegExamples.ExpressionParser();
            var result = parser.Parse("2+2*2");
            Console.WriteLine(result); // Outputs "11.1".
        }
    }
}
