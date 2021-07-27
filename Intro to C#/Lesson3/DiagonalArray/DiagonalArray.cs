﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalArray {
    class Program {
        static void Main(string[] args) {
            double[,] array = {
                { 1.1, 1.2, 1.3, 1.4, 1.5 },
                { 2.1, 2.2, 2.3, 2.4, 2.5 },
                { 3.1, 3.2, 3.3, 3.4, 3.5 },
                { 4.1, 4.2, 4.3, 4.4, 4.5 },
                { 5.1, 5.2, 5.3, 5.4, 5.5 }
            };

            for( int i = 0; i < array.GetLength(0); i++ ) {
                for( int j = 0; j < array.GetLength(1); j++) {
                    if(i == j) {
                        Console.WriteLine($"{array[i, j]}");
                    }
                }
            }
        }
    }
}