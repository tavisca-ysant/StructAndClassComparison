﻿using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace StructAndClassComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var Summary = BenchmarkRunner.Run<Comparison>();
            Console.ReadKey(true);
        }
    }
}
